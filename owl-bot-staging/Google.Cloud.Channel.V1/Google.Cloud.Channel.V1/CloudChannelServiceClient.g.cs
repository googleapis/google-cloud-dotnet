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

namespace Google.Cloud.Channel.V1
{
    /// <summary>Settings for <see cref="CloudChannelServiceClient"/> instances.</summary>
    public sealed partial class CloudChannelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CloudChannelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CloudChannelServiceSettings"/>.</returns>
        public static CloudChannelServiceSettings GetDefault() => new CloudChannelServiceSettings();

        /// <summary>Constructs a new <see cref="CloudChannelServiceSettings"/> object with default settings.</summary>
        public CloudChannelServiceSettings()
        {
        }

        private CloudChannelServiceSettings(CloudChannelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListCustomersSettings = existing.ListCustomersSettings;
            GetCustomerSettings = existing.GetCustomerSettings;
            CheckCloudIdentityAccountsExistSettings = existing.CheckCloudIdentityAccountsExistSettings;
            CreateCustomerSettings = existing.CreateCustomerSettings;
            UpdateCustomerSettings = existing.UpdateCustomerSettings;
            DeleteCustomerSettings = existing.DeleteCustomerSettings;
            ImportCustomerSettings = existing.ImportCustomerSettings;
            ProvisionCloudIdentitySettings = existing.ProvisionCloudIdentitySettings;
            ProvisionCloudIdentityOperationsSettings = existing.ProvisionCloudIdentityOperationsSettings.Clone();
            ListEntitlementsSettings = existing.ListEntitlementsSettings;
            ListTransferableSkusSettings = existing.ListTransferableSkusSettings;
            ListTransferableOffersSettings = existing.ListTransferableOffersSettings;
            GetEntitlementSettings = existing.GetEntitlementSettings;
            CreateEntitlementSettings = existing.CreateEntitlementSettings;
            CreateEntitlementOperationsSettings = existing.CreateEntitlementOperationsSettings.Clone();
            ChangeParametersSettings = existing.ChangeParametersSettings;
            ChangeParametersOperationsSettings = existing.ChangeParametersOperationsSettings.Clone();
            ChangeRenewalSettingsSettings = existing.ChangeRenewalSettingsSettings;
            ChangeRenewalSettingsOperationsSettings = existing.ChangeRenewalSettingsOperationsSettings.Clone();
            ChangeOfferSettings = existing.ChangeOfferSettings;
            ChangeOfferOperationsSettings = existing.ChangeOfferOperationsSettings.Clone();
            StartPaidServiceSettings = existing.StartPaidServiceSettings;
            StartPaidServiceOperationsSettings = existing.StartPaidServiceOperationsSettings.Clone();
            SuspendEntitlementSettings = existing.SuspendEntitlementSettings;
            SuspendEntitlementOperationsSettings = existing.SuspendEntitlementOperationsSettings.Clone();
            CancelEntitlementSettings = existing.CancelEntitlementSettings;
            CancelEntitlementOperationsSettings = existing.CancelEntitlementOperationsSettings.Clone();
            ActivateEntitlementSettings = existing.ActivateEntitlementSettings;
            ActivateEntitlementOperationsSettings = existing.ActivateEntitlementOperationsSettings.Clone();
            TransferEntitlementsSettings = existing.TransferEntitlementsSettings;
            TransferEntitlementsOperationsSettings = existing.TransferEntitlementsOperationsSettings.Clone();
            TransferEntitlementsToGoogleSettings = existing.TransferEntitlementsToGoogleSettings;
            TransferEntitlementsToGoogleOperationsSettings = existing.TransferEntitlementsToGoogleOperationsSettings.Clone();
            ListChannelPartnerLinksSettings = existing.ListChannelPartnerLinksSettings;
            GetChannelPartnerLinkSettings = existing.GetChannelPartnerLinkSettings;
            CreateChannelPartnerLinkSettings = existing.CreateChannelPartnerLinkSettings;
            UpdateChannelPartnerLinkSettings = existing.UpdateChannelPartnerLinkSettings;
            GetCustomerRepricingConfigSettings = existing.GetCustomerRepricingConfigSettings;
            ListCustomerRepricingConfigsSettings = existing.ListCustomerRepricingConfigsSettings;
            CreateCustomerRepricingConfigSettings = existing.CreateCustomerRepricingConfigSettings;
            UpdateCustomerRepricingConfigSettings = existing.UpdateCustomerRepricingConfigSettings;
            DeleteCustomerRepricingConfigSettings = existing.DeleteCustomerRepricingConfigSettings;
            GetChannelPartnerRepricingConfigSettings = existing.GetChannelPartnerRepricingConfigSettings;
            ListChannelPartnerRepricingConfigsSettings = existing.ListChannelPartnerRepricingConfigsSettings;
            CreateChannelPartnerRepricingConfigSettings = existing.CreateChannelPartnerRepricingConfigSettings;
            UpdateChannelPartnerRepricingConfigSettings = existing.UpdateChannelPartnerRepricingConfigSettings;
            DeleteChannelPartnerRepricingConfigSettings = existing.DeleteChannelPartnerRepricingConfigSettings;
            ListSkuGroupsSettings = existing.ListSkuGroupsSettings;
            ListSkuGroupBillableSkusSettings = existing.ListSkuGroupBillableSkusSettings;
            LookupOfferSettings = existing.LookupOfferSettings;
            ListProductsSettings = existing.ListProductsSettings;
            ListSkusSettings = existing.ListSkusSettings;
            ListOffersSettings = existing.ListOffersSettings;
            ListPurchasableSkusSettings = existing.ListPurchasableSkusSettings;
            ListPurchasableOffersSettings = existing.ListPurchasableOffersSettings;
            QueryEligibleBillingAccountsSettings = existing.QueryEligibleBillingAccountsSettings;
            RegisterSubscriberSettings = existing.RegisterSubscriberSettings;
            UnregisterSubscriberSettings = existing.UnregisterSubscriberSettings;
            ListSubscribersSettings = existing.ListSubscribersSettings;
            ListEntitlementChangesSettings = existing.ListEntitlementChangesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CloudChannelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListCustomers</c> and <c>CloudChannelServiceClient.ListCustomersAsync</c>.
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
        public gaxgrpc::CallSettings ListCustomersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.GetCustomer</c> and <c>CloudChannelServiceClient.GetCustomerAsync</c>.
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
        public gaxgrpc::CallSettings GetCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.CheckCloudIdentityAccountsExist</c> and
        /// <c>CloudChannelServiceClient.CheckCloudIdentityAccountsExistAsync</c>.
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
        public gaxgrpc::CallSettings CheckCloudIdentityAccountsExistSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.CreateCustomer</c> and <c>CloudChannelServiceClient.CreateCustomerAsync</c>.
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
        public gaxgrpc::CallSettings CreateCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.UpdateCustomer</c> and <c>CloudChannelServiceClient.UpdateCustomerAsync</c>.
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
        public gaxgrpc::CallSettings UpdateCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.DeleteCustomer</c> and <c>CloudChannelServiceClient.DeleteCustomerAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ImportCustomer</c> and <c>CloudChannelServiceClient.ImportCustomerAsync</c>.
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
        public gaxgrpc::CallSettings ImportCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ProvisionCloudIdentity</c> and
        /// <c>CloudChannelServiceClient.ProvisionCloudIdentityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ProvisionCloudIdentitySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.ProvisionCloudIdentity</c> and
        /// <c>CloudChannelServiceClient.ProvisionCloudIdentityAsync</c>.
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
        public lro::OperationsSettings ProvisionCloudIdentityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListEntitlements</c> and <c>CloudChannelServiceClient.ListEntitlementsAsync</c>
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
        public gaxgrpc::CallSettings ListEntitlementsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListTransferableSkus</c> and
        /// <c>CloudChannelServiceClient.ListTransferableSkusAsync</c>.
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
        public gaxgrpc::CallSettings ListTransferableSkusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListTransferableOffers</c> and
        /// <c>CloudChannelServiceClient.ListTransferableOffersAsync</c>.
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
        public gaxgrpc::CallSettings ListTransferableOffersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.GetEntitlement</c> and <c>CloudChannelServiceClient.GetEntitlementAsync</c>.
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
        public gaxgrpc::CallSettings GetEntitlementSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.CreateEntitlement</c> and <c>CloudChannelServiceClient.CreateEntitlementAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntitlementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.CreateEntitlement</c> and
        /// <c>CloudChannelServiceClient.CreateEntitlementAsync</c>.
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
        public lro::OperationsSettings CreateEntitlementOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ChangeParameters</c> and <c>CloudChannelServiceClient.ChangeParametersAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ChangeParametersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.ChangeParameters</c> and
        /// <c>CloudChannelServiceClient.ChangeParametersAsync</c>.
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
        public lro::OperationsSettings ChangeParametersOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ChangeRenewalSettings</c> and
        /// <c>CloudChannelServiceClient.ChangeRenewalSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ChangeRenewalSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.ChangeRenewalSettings</c> and
        /// <c>CloudChannelServiceClient.ChangeRenewalSettingsAsync</c>.
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
        public lro::OperationsSettings ChangeRenewalSettingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ChangeOffer</c> and <c>CloudChannelServiceClient.ChangeOfferAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ChangeOfferSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.ChangeOffer</c> and
        /// <c>CloudChannelServiceClient.ChangeOfferAsync</c>.
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
        public lro::OperationsSettings ChangeOfferOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.StartPaidService</c> and <c>CloudChannelServiceClient.StartPaidServiceAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings StartPaidServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.StartPaidService</c> and
        /// <c>CloudChannelServiceClient.StartPaidServiceAsync</c>.
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
        public lro::OperationsSettings StartPaidServiceOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.SuspendEntitlement</c> and <c>CloudChannelServiceClient.SuspendEntitlementAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SuspendEntitlementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.SuspendEntitlement</c> and
        /// <c>CloudChannelServiceClient.SuspendEntitlementAsync</c>.
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
        public lro::OperationsSettings SuspendEntitlementOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.CancelEntitlement</c> and <c>CloudChannelServiceClient.CancelEntitlementAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelEntitlementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.CancelEntitlement</c> and
        /// <c>CloudChannelServiceClient.CancelEntitlementAsync</c>.
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
        public lro::OperationsSettings CancelEntitlementOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ActivateEntitlement</c> and
        /// <c>CloudChannelServiceClient.ActivateEntitlementAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ActivateEntitlementSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.ActivateEntitlement</c> and
        /// <c>CloudChannelServiceClient.ActivateEntitlementAsync</c>.
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
        public lro::OperationsSettings ActivateEntitlementOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.TransferEntitlements</c> and
        /// <c>CloudChannelServiceClient.TransferEntitlementsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TransferEntitlementsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.TransferEntitlements</c> and
        /// <c>CloudChannelServiceClient.TransferEntitlementsAsync</c>.
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
        public lro::OperationsSettings TransferEntitlementsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.TransferEntitlementsToGoogle</c> and
        /// <c>CloudChannelServiceClient.TransferEntitlementsToGoogleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings TransferEntitlementsToGoogleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CloudChannelServiceClient.TransferEntitlementsToGoogle</c>
        /// and <c>CloudChannelServiceClient.TransferEntitlementsToGoogleAsync</c>.
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
        public lro::OperationsSettings TransferEntitlementsToGoogleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListChannelPartnerLinks</c> and
        /// <c>CloudChannelServiceClient.ListChannelPartnerLinksAsync</c>.
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
        public gaxgrpc::CallSettings ListChannelPartnerLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.GetChannelPartnerLink</c> and
        /// <c>CloudChannelServiceClient.GetChannelPartnerLinkAsync</c>.
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
        public gaxgrpc::CallSettings GetChannelPartnerLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.CreateChannelPartnerLink</c> and
        /// <c>CloudChannelServiceClient.CreateChannelPartnerLinkAsync</c>.
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
        public gaxgrpc::CallSettings CreateChannelPartnerLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.UpdateChannelPartnerLink</c> and
        /// <c>CloudChannelServiceClient.UpdateChannelPartnerLinkAsync</c>.
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
        public gaxgrpc::CallSettings UpdateChannelPartnerLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.GetCustomerRepricingConfig</c> and
        /// <c>CloudChannelServiceClient.GetCustomerRepricingConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetCustomerRepricingConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListCustomerRepricingConfigs</c> and
        /// <c>CloudChannelServiceClient.ListCustomerRepricingConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListCustomerRepricingConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.CreateCustomerRepricingConfig</c> and
        /// <c>CloudChannelServiceClient.CreateCustomerRepricingConfigAsync</c>.
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
        public gaxgrpc::CallSettings CreateCustomerRepricingConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.UpdateCustomerRepricingConfig</c> and
        /// <c>CloudChannelServiceClient.UpdateCustomerRepricingConfigAsync</c>.
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
        public gaxgrpc::CallSettings UpdateCustomerRepricingConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.DeleteCustomerRepricingConfig</c> and
        /// <c>CloudChannelServiceClient.DeleteCustomerRepricingConfigAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCustomerRepricingConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.GetChannelPartnerRepricingConfig</c> and
        /// <c>CloudChannelServiceClient.GetChannelPartnerRepricingConfigAsync</c>.
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
        public gaxgrpc::CallSettings GetChannelPartnerRepricingConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListChannelPartnerRepricingConfigs</c> and
        /// <c>CloudChannelServiceClient.ListChannelPartnerRepricingConfigsAsync</c>.
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
        public gaxgrpc::CallSettings ListChannelPartnerRepricingConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.CreateChannelPartnerRepricingConfig</c> and
        /// <c>CloudChannelServiceClient.CreateChannelPartnerRepricingConfigAsync</c>.
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
        public gaxgrpc::CallSettings CreateChannelPartnerRepricingConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.UpdateChannelPartnerRepricingConfig</c> and
        /// <c>CloudChannelServiceClient.UpdateChannelPartnerRepricingConfigAsync</c>.
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
        public gaxgrpc::CallSettings UpdateChannelPartnerRepricingConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.DeleteChannelPartnerRepricingConfig</c> and
        /// <c>CloudChannelServiceClient.DeleteChannelPartnerRepricingConfigAsync</c>.
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
        public gaxgrpc::CallSettings DeleteChannelPartnerRepricingConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListSkuGroups</c> and <c>CloudChannelServiceClient.ListSkuGroupsAsync</c>.
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
        public gaxgrpc::CallSettings ListSkuGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListSkuGroupBillableSkus</c> and
        /// <c>CloudChannelServiceClient.ListSkuGroupBillableSkusAsync</c>.
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
        public gaxgrpc::CallSettings ListSkuGroupBillableSkusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.LookupOffer</c> and <c>CloudChannelServiceClient.LookupOfferAsync</c>.
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
        public gaxgrpc::CallSettings LookupOfferSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListProducts</c> and <c>CloudChannelServiceClient.ListProductsAsync</c>.
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
        public gaxgrpc::CallSettings ListProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListSkus</c> and <c>CloudChannelServiceClient.ListSkusAsync</c>.
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
        /// <c>CloudChannelServiceClient.ListOffers</c> and <c>CloudChannelServiceClient.ListOffersAsync</c>.
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
        public gaxgrpc::CallSettings ListOffersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListPurchasableSkus</c> and
        /// <c>CloudChannelServiceClient.ListPurchasableSkusAsync</c>.
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
        public gaxgrpc::CallSettings ListPurchasableSkusSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListPurchasableOffers</c> and
        /// <c>CloudChannelServiceClient.ListPurchasableOffersAsync</c>.
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
        public gaxgrpc::CallSettings ListPurchasableOffersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.QueryEligibleBillingAccounts</c> and
        /// <c>CloudChannelServiceClient.QueryEligibleBillingAccountsAsync</c>.
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
        public gaxgrpc::CallSettings QueryEligibleBillingAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.RegisterSubscriber</c> and <c>CloudChannelServiceClient.RegisterSubscriberAsync</c>
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
        public gaxgrpc::CallSettings RegisterSubscriberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.UnregisterSubscriber</c> and
        /// <c>CloudChannelServiceClient.UnregisterSubscriberAsync</c>.
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
        public gaxgrpc::CallSettings UnregisterSubscriberSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListSubscribers</c> and <c>CloudChannelServiceClient.ListSubscribersAsync</c>.
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
        public gaxgrpc::CallSettings ListSubscribersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CloudChannelServiceClient.ListEntitlementChanges</c> and
        /// <c>CloudChannelServiceClient.ListEntitlementChangesAsync</c>.
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
        public gaxgrpc::CallSettings ListEntitlementChangesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CloudChannelServiceSettings"/> object.</returns>
        public CloudChannelServiceSettings Clone() => new CloudChannelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CloudChannelServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CloudChannelServiceClientBuilder : gaxgrpc::ClientBuilderBase<CloudChannelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CloudChannelServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CloudChannelServiceClientBuilder() : base(CloudChannelServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CloudChannelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CloudChannelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CloudChannelServiceClient Build()
        {
            CloudChannelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CloudChannelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CloudChannelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CloudChannelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CloudChannelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CloudChannelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudChannelServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudChannelServiceClient.ChannelPool;
    }

    /// <summary>CloudChannelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// CloudChannelService lets Google cloud resellers and distributors manage
    /// their customers, channel partners, entitlements, and reports.
    /// 
    /// Using this service:
    /// 1. Resellers and distributors can manage a customer entity.
    /// 2. Distributors can register an authorized reseller in their channel and
    /// provide them with delegated admin access.
    /// 3. Resellers and distributors can manage customer entitlements.
    /// 
    /// CloudChannelService exposes the following resources:
    /// - [Customer][google.cloud.channel.v1.Customer]s: An entity-usually an
    /// enterprise-managed by a reseller or distributor.
    /// 
    /// - [Entitlement][google.cloud.channel.v1.Entitlement]s: An entity that
    /// provides a customer with the means to use a service. Entitlements are created
    /// or updated as a result of a successful fulfillment.
    /// 
    /// - [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s: An
    /// entity that identifies links between distributors and their indirect
    /// resellers in a channel.
    /// </remarks>
    public abstract partial class CloudChannelServiceClient
    {
        /// <summary>
        /// The default endpoint for the CloudChannelService service, which is a host of "cloudchannel.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "cloudchannel.googleapis.com:443";

        /// <summary>The default CloudChannelService scopes.</summary>
        /// <remarks>
        /// The default CloudChannelService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/apps.order</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/apps.order",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CloudChannelService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CloudChannelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CloudChannelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CloudChannelServiceClient"/>.</returns>
        public static stt::Task<CloudChannelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CloudChannelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CloudChannelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CloudChannelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CloudChannelServiceClient"/>.</returns>
        public static CloudChannelServiceClient Create() => new CloudChannelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CloudChannelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CloudChannelServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CloudChannelServiceClient"/>.</returns>
        internal static CloudChannelServiceClient Create(grpccore::CallInvoker callInvoker, CloudChannelServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudChannelService.CloudChannelServiceClient grpcClient = new CloudChannelService.CloudChannelServiceClient(callInvoker);
            return new CloudChannelServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CloudChannelService client</summary>
        public virtual CloudChannelService.CloudChannelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// List [Customer][google.cloud.channel.v1.Customer]s.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// List of [Customer][google.cloud.channel.v1.Customer]s, or an empty list if
        /// there are no customers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomersResponse, Customer> ListCustomers(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [Customer][google.cloud.channel.v1.Customer]s.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// List of [Customer][google.cloud.channel.v1.Customer]s, or an empty list if
        /// there are no customers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomersResponse, Customer> ListCustomersAsync(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer GetCustomer(GetCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(GetCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(GetCustomerRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to retrieve.
        /// Name uses the format: accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer GetCustomer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomer(new GetCustomerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to retrieve.
        /// Name uses the format: accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerAsync(new GetCustomerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to retrieve.
        /// Name uses the format: accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to retrieve.
        /// Name uses the format: accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer GetCustomer(CustomerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomer(new GetCustomerRequest
            {
                CustomerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to retrieve.
        /// Name uses the format: accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(CustomerName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerAsync(new GetCustomerRequest
            {
                CustomerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to retrieve.
        /// Name uses the format: accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> GetCustomerAsync(CustomerName name, st::CancellationToken cancellationToken) =>
            GetCustomerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Confirms the existence of Cloud Identity accounts based on the domain and
        /// if the Cloud Identity accounts are owned by the reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INVALID_VALUE: Invalid domain value in the request.
        /// 
        /// Return value:
        /// A list of
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources for the domain (may be empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources match the domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckCloudIdentityAccountsExistResponse CheckCloudIdentityAccountsExist(CheckCloudIdentityAccountsExistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Confirms the existence of Cloud Identity accounts based on the domain and
        /// if the Cloud Identity accounts are owned by the reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INVALID_VALUE: Invalid domain value in the request.
        /// 
        /// Return value:
        /// A list of
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources for the domain (may be empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources match the domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckCloudIdentityAccountsExistResponse> CheckCloudIdentityAccountsExistAsync(CheckCloudIdentityAccountsExistRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Confirms the existence of Cloud Identity accounts based on the domain and
        /// if the Cloud Identity accounts are owned by the reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INVALID_VALUE: Invalid domain value in the request.
        /// 
        /// Return value:
        /// A list of
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources for the domain (may be empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources match the domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckCloudIdentityAccountsExistResponse> CheckCloudIdentityAccountsExistAsync(CheckCloudIdentityAccountsExistRequest request, st::CancellationToken cancellationToken) =>
            CheckCloudIdentityAccountsExistAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under
        /// the reseller or distributor account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to create a customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Domain field value doesn't match the primary email domain.
        /// 
        /// Return value:
        /// The newly created [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer CreateCustomer(CreateCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under
        /// the reseller or distributor account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to create a customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Domain field value doesn't match the primary email domain.
        /// 
        /// Return value:
        /// The newly created [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> CreateCustomerAsync(CreateCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under
        /// the reseller or distributor account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to create a customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Domain field value doesn't match the primary email domain.
        /// 
        /// Return value:
        /// The newly created [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> CreateCustomerAsync(CreateCustomerRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource
        /// for the reseller or distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// 
        /// Return value:
        /// The updated [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer UpdateCustomer(UpdateCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource
        /// for the reseller or distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// 
        /// Return value:
        /// The updated [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> UpdateCustomerAsync(UpdateCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource
        /// for the reseller or distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// 
        /// Return value:
        /// The updated [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> UpdateCustomerAsync(UpdateCustomerRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomer(DeleteCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerAsync(DeleteCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerAsync(DeleteCustomerRequest request, st::CancellationToken cancellationToken) =>
            DeleteCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomer(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomer(new DeleteCustomerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomerAsync(new DeleteCustomerRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCustomerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomer(CustomerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomer(new DeleteCustomerRequest
            {
                CustomerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerAsync(CustomerName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomerAsync(new DeleteCustomerRequest
            {
                CustomerName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerAsync(CustomerName name, st::CancellationToken cancellationToken) =>
            DeleteCustomerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports a [Customer][google.cloud.channel.v1.Customer] from the Cloud
        /// Identity associated with the provided Cloud Identity ID or domain before a
        /// TransferEntitlements call. If a linked Customer already exists and
        /// overwrite_if_exists is true, it will update that Customer's data.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to import the customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * NOT_FOUND: Cloud Identity doesn't exist or was deleted.
        /// * INVALID_ARGUMENT: Required parameters are missing, or the auth_token is
        /// expired or invalid.
        /// * ALREADY_EXISTS: A customer already exists and has conflicting critical
        /// fields. Requires an overwrite.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Customer ImportCustomer(ImportCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a [Customer][google.cloud.channel.v1.Customer] from the Cloud
        /// Identity associated with the provided Cloud Identity ID or domain before a
        /// TransferEntitlements call. If a linked Customer already exists and
        /// overwrite_if_exists is true, it will update that Customer's data.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to import the customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * NOT_FOUND: Cloud Identity doesn't exist or was deleted.
        /// * INVALID_ARGUMENT: Required parameters are missing, or the auth_token is
        /// expired or invalid.
        /// * ALREADY_EXISTS: A customer already exists and has conflicting critical
        /// fields. Requires an overwrite.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> ImportCustomerAsync(ImportCustomerRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports a [Customer][google.cloud.channel.v1.Customer] from the Cloud
        /// Identity associated with the provided Cloud Identity ID or domain before a
        /// TransferEntitlements call. If a linked Customer already exists and
        /// overwrite_if_exists is true, it will update that Customer's data.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to import the customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * NOT_FOUND: Cloud Identity doesn't exist or was deleted.
        /// * INVALID_ARGUMENT: Required parameters are missing, or the auth_token is
        /// expired or invalid.
        /// * ALREADY_EXISTS: A customer already exists and has conflicting critical
        /// fields. Requires an overwrite.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Customer> ImportCustomerAsync(ImportCustomerRequest request, st::CancellationToken cancellationToken) =>
            ImportCustomerAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Cloud Identity for the given customer using the customer's
        /// information, or the information provided here.
        /// 
        /// Possible error codes:
        /// 
        /// *  PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * You are not authorized to provision cloud identity id. See
        /// https://support.google.com/channelservices/answer/9759265
        /// *  INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// *  NOT_FOUND: The customer was not found.
        /// *  ALREADY_EXISTS: The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Customer, OperationMetadata> ProvisionCloudIdentity(ProvisionCloudIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud Identity for the given customer using the customer's
        /// information, or the information provided here.
        /// 
        /// Possible error codes:
        /// 
        /// *  PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * You are not authorized to provision cloud identity id. See
        /// https://support.google.com/channelservices/answer/9759265
        /// *  INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// *  NOT_FOUND: The customer was not found.
        /// *  ALREADY_EXISTS: The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Customer, OperationMetadata>> ProvisionCloudIdentityAsync(ProvisionCloudIdentityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a Cloud Identity for the given customer using the customer's
        /// information, or the information provided here.
        /// 
        /// Possible error codes:
        /// 
        /// *  PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * You are not authorized to provision cloud identity id. See
        /// https://support.google.com/channelservices/answer/9759265
        /// *  INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// *  NOT_FOUND: The customer was not found.
        /// *  ALREADY_EXISTS: The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Customer, OperationMetadata>> ProvisionCloudIdentityAsync(ProvisionCloudIdentityRequest request, st::CancellationToken cancellationToken) =>
            ProvisionCloudIdentityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ProvisionCloudIdentity</c>.</summary>
        public virtual lro::OperationsClient ProvisionCloudIdentityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ProvisionCloudIdentity</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Customer, OperationMetadata> PollOnceProvisionCloudIdentity(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Customer, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ProvisionCloudIdentityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ProvisionCloudIdentity</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Customer, OperationMetadata>> PollOnceProvisionCloudIdentityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Customer, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ProvisionCloudIdentityOperationsClient, callSettings);

        /// <summary>
        /// Lists [Entitlement][google.cloud.channel.v1.Entitlement]s belonging to a
        /// customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's
        /// [Entitlement][google.cloud.channel.v1.Entitlement]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Entitlement][google.cloud.channel.v1.Entitlement]s belonging to a
        /// customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's
        /// [Entitlement][google.cloud.channel.v1.Entitlement]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [TransferableSku][google.cloud.channel.v1.TransferableSku]s of a
        /// customer based on the Cloud Identity ID or Customer Name in the request.
        /// 
        /// Use this method to list the entitlements information of an
        /// unowned customer. You should provide the customer's
        /// Cloud Identity ID or Customer Name.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller and has no auth token.
        /// * The supplied auth token is invalid.
        /// * The reseller account making the request is different
        /// from the reseller account in the query.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's
        /// [TransferableSku][google.cloud.channel.v1.TransferableSku].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferableSku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferableSkusResponse, TransferableSku> ListTransferableSkus(ListTransferableSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [TransferableSku][google.cloud.channel.v1.TransferableSku]s of a
        /// customer based on the Cloud Identity ID or Customer Name in the request.
        /// 
        /// Use this method to list the entitlements information of an
        /// unowned customer. You should provide the customer's
        /// Cloud Identity ID or Customer Name.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller and has no auth token.
        /// * The supplied auth token is invalid.
        /// * The reseller account making the request is different
        /// from the reseller account in the query.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's
        /// [TransferableSku][google.cloud.channel.v1.TransferableSku].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferableSku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferableSkusResponse, TransferableSku> ListTransferableSkusAsync(ListTransferableSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [TransferableOffer][google.cloud.channel.v1.TransferableOffer]s of a
        /// customer based on Cloud Identity ID or Customer Name in the request.
        /// 
        /// Use this method when a reseller gets the entitlement information of an
        /// unowned customer. The reseller should provide the customer's
        /// Cloud Identity ID or Customer Name.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller and has no auth token.
        /// * The customer provided incorrect reseller information when generating
        /// auth token.
        /// * The reseller account making the request is different
        /// from the reseller account in the query.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// List of [TransferableOffer][google.cloud.channel.v1.TransferableOffer] for
        /// the given customer and SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferableOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferableOffersResponse, TransferableOffer> ListTransferableOffers(ListTransferableOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [TransferableOffer][google.cloud.channel.v1.TransferableOffer]s of a
        /// customer based on Cloud Identity ID or Customer Name in the request.
        /// 
        /// Use this method when a reseller gets the entitlement information of an
        /// unowned customer. The reseller should provide the customer's
        /// Cloud Identity ID or Customer Name.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller and has no auth token.
        /// * The customer provided incorrect reseller information when generating
        /// auth token.
        /// * The reseller account making the request is different
        /// from the reseller account in the query.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// List of [TransferableOffer][google.cloud.channel.v1.TransferableOffer] for
        /// the given customer and SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferableOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferableOffersResponse, TransferableOffer> ListTransferableOffersAsync(ListTransferableOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer entitlement was not found.
        /// 
        /// Return value:
        /// The requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entitlement GetEntitlement(GetEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer entitlement was not found.
        /// 
        /// Return value:
        /// The requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entitlement> GetEntitlementAsync(GetEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer entitlement was not found.
        /// 
        /// Return value:
        /// The requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entitlement> GetEntitlementAsync(GetEntitlementRequest request, st::CancellationToken cancellationToken) =>
            GetEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an entitlement for a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * There is already a customer entitlement for a SKU from the same
        /// product family.
        /// * INVALID_VALUE: Make sure the OfferId is valid. If it is, contact
        /// Google Channel support for further troubleshooting.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS:
        /// * The SKU was already purchased for the customer.
        /// * The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The domain required for purchasing a SKU has not been verified.
        /// * A pre-requisite SKU required to purchase an Add-On SKU is missing.
        /// For example, Google Workspace Business Starter is required to purchase
        /// Vault or Drive.
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> CreateEntitlement(CreateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entitlement for a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * There is already a customer entitlement for a SKU from the same
        /// product family.
        /// * INVALID_VALUE: Make sure the OfferId is valid. If it is, contact
        /// Google Channel support for further troubleshooting.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS:
        /// * The SKU was already purchased for the customer.
        /// * The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The domain required for purchasing a SKU has not been verified.
        /// * A pre-requisite SKU required to purchase an Add-On SKU is missing.
        /// For example, Google Workspace Business Starter is required to purchase
        /// Vault or Drive.
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(CreateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an entitlement for a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * There is already a customer entitlement for a SKU from the same
        /// product family.
        /// * INVALID_VALUE: Make sure the OfferId is valid. If it is, contact
        /// Google Channel support for further troubleshooting.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS:
        /// * The SKU was already purchased for the customer.
        /// * The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The domain required for purchasing a SKU has not been verified.
        /// * A pre-requisite SKU required to purchase an Add-On SKU is missing.
        /// For example, Google Workspace Business Starter is required to purchase
        /// Vault or Drive.
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(CreateEntitlementRequest request, st::CancellationToken cancellationToken) =>
            CreateEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEntitlement</c>.</summary>
        public virtual lro::OperationsClient CreateEntitlementOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEntitlement</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceCreateEntitlement(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEntitlement</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceCreateEntitlementAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Change parameters of the entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// For example, the number of seats being changed is greater than the allowed
        /// number of max seats, or decreasing seats for a commitment based plan.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> ChangeParameters(ChangeParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Change parameters of the entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// For example, the number of seats being changed is greater than the allowed
        /// number of max seats, or decreasing seats for a commitment based plan.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeParametersAsync(ChangeParametersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Change parameters of the entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// For example, the number of seats being changed is greater than the allowed
        /// number of max seats, or decreasing seats for a commitment based plan.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeParametersAsync(ChangeParametersRequest request, st::CancellationToken cancellationToken) =>
            ChangeParametersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ChangeParameters</c>.</summary>
        public virtual lro::OperationsClient ChangeParametersOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ChangeParameters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceChangeParameters(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ChangeParametersOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ChangeParameters</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceChangeParametersAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ChangeParametersOperationsClient, callSettings);

        /// <summary>
        /// Updates the renewal settings for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_COMMITMENT_PLAN: Renewal Settings are only applicable for a
        /// commitment plan. Can't enable or disable renewals for non-commitment plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> ChangeRenewalSettings(ChangeRenewalSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the renewal settings for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_COMMITMENT_PLAN: Renewal Settings are only applicable for a
        /// commitment plan. Can't enable or disable renewals for non-commitment plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeRenewalSettingsAsync(ChangeRenewalSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the renewal settings for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_COMMITMENT_PLAN: Renewal Settings are only applicable for a
        /// commitment plan. Can't enable or disable renewals for non-commitment plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeRenewalSettingsAsync(ChangeRenewalSettingsRequest request, st::CancellationToken cancellationToken) =>
            ChangeRenewalSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ChangeRenewalSettings</c>.</summary>
        public virtual lro::OperationsClient ChangeRenewalSettingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ChangeRenewalSettings</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceChangeRenewalSettings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ChangeRenewalSettingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ChangeRenewalSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceChangeRenewalSettingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ChangeRenewalSettingsOperationsClient, callSettings);

        /// <summary>
        /// Updates the Offer for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Offer or Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> ChangeOffer(ChangeOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Offer for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Offer or Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeOfferAsync(ChangeOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Offer for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Offer or Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeOfferAsync(ChangeOfferRequest request, st::CancellationToken cancellationToken) =>
            ChangeOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ChangeOffer</c>.</summary>
        public virtual lro::OperationsClient ChangeOfferOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ChangeOffer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceChangeOffer(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ChangeOfferOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ChangeOffer</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceChangeOfferAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ChangeOfferOperationsClient, callSettings);

        /// <summary>
        /// Starts paid service for a trial entitlement.
        /// 
        /// Starts paid service for a trial entitlement immediately. This method is
        /// only applicable if a plan is set up for a trial entitlement but has some
        /// trial days remaining.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * FAILED_PRECONDITION/NOT_IN_TRIAL: This method only works for
        /// entitlement on trial plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> StartPaidService(StartPaidServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts paid service for a trial entitlement.
        /// 
        /// Starts paid service for a trial entitlement immediately. This method is
        /// only applicable if a plan is set up for a trial entitlement but has some
        /// trial days remaining.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * FAILED_PRECONDITION/NOT_IN_TRIAL: This method only works for
        /// entitlement on trial plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> StartPaidServiceAsync(StartPaidServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts paid service for a trial entitlement.
        /// 
        /// Starts paid service for a trial entitlement immediately. This method is
        /// only applicable if a plan is set up for a trial entitlement but has some
        /// trial days remaining.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * FAILED_PRECONDITION/NOT_IN_TRIAL: This method only works for
        /// entitlement on trial plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> StartPaidServiceAsync(StartPaidServiceRequest request, st::CancellationToken cancellationToken) =>
            StartPaidServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>StartPaidService</c>.</summary>
        public virtual lro::OperationsClient StartPaidServiceOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>StartPaidService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceStartPaidService(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartPaidServiceOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>StartPaidService</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceStartPaidServiceAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), StartPaidServiceOperationsClient, callSettings);

        /// <summary>
        /// Suspends a previously fulfilled entitlement.
        /// 
        /// An entitlement suspension is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_ACTIVE: Entitlement is not active.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> SuspendEntitlement(SuspendEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suspends a previously fulfilled entitlement.
        /// 
        /// An entitlement suspension is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_ACTIVE: Entitlement is not active.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> SuspendEntitlementAsync(SuspendEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suspends a previously fulfilled entitlement.
        /// 
        /// An entitlement suspension is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_ACTIVE: Entitlement is not active.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> SuspendEntitlementAsync(SuspendEntitlementRequest request, st::CancellationToken cancellationToken) =>
            SuspendEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SuspendEntitlement</c>.</summary>
        public virtual lro::OperationsClient SuspendEntitlementOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SuspendEntitlement</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceSuspendEntitlement(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuspendEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SuspendEntitlement</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceSuspendEntitlementAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuspendEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Cancels a previously fulfilled entitlement.
        /// 
        /// An entitlement cancellation is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * FAILED_PRECONDITION: There are Google Cloud projects linked to the
        /// Google Cloud entitlement's Cloud Billing subaccount.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * DELETION_TYPE_NOT_ALLOWED: Cancel is only allowed for Google Workspace
        /// add-ons, or entitlements for Google Cloud's development platform.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> CancelEntitlement(CancelEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a previously fulfilled entitlement.
        /// 
        /// An entitlement cancellation is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * FAILED_PRECONDITION: There are Google Cloud projects linked to the
        /// Google Cloud entitlement's Cloud Billing subaccount.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * DELETION_TYPE_NOT_ALLOWED: Cancel is only allowed for Google Workspace
        /// add-ons, or entitlements for Google Cloud's development platform.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> CancelEntitlementAsync(CancelEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels a previously fulfilled entitlement.
        /// 
        /// An entitlement cancellation is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * FAILED_PRECONDITION: There are Google Cloud projects linked to the
        /// Google Cloud entitlement's Cloud Billing subaccount.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * DELETION_TYPE_NOT_ALLOWED: Cancel is only allowed for Google Workspace
        /// add-ons, or entitlements for Google Cloud's development platform.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> CancelEntitlementAsync(CancelEntitlementRequest request, st::CancellationToken cancellationToken) =>
            CancelEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CancelEntitlement</c>.</summary>
        public virtual lro::OperationsClient CancelEntitlementOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CancelEntitlement</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceCancelEntitlement(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CancelEntitlement</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceCancelEntitlementAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CancelEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Activates a previously suspended entitlement. Entitlements suspended for
        /// pending ToS acceptance can't be activated using this method.
        /// 
        /// An entitlement activation is a long-running operation and it updates
        /// the state of the customer entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * SUSPENSION_NOT_RESELLER_INITIATED: Can only activate reseller-initiated
        /// suspensions and entitlements that have accepted the TOS.
        /// * NOT_SUSPENDED: Can only activate suspended entitlements not in an ACTIVE
        /// state.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> ActivateEntitlement(ActivateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a previously suspended entitlement. Entitlements suspended for
        /// pending ToS acceptance can't be activated using this method.
        /// 
        /// An entitlement activation is a long-running operation and it updates
        /// the state of the customer entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * SUSPENSION_NOT_RESELLER_INITIATED: Can only activate reseller-initiated
        /// suspensions and entitlements that have accepted the TOS.
        /// * NOT_SUSPENDED: Can only activate suspended entitlements not in an ACTIVE
        /// state.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> ActivateEntitlementAsync(ActivateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activates a previously suspended entitlement. Entitlements suspended for
        /// pending ToS acceptance can't be activated using this method.
        /// 
        /// An entitlement activation is a long-running operation and it updates
        /// the state of the customer entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * SUSPENSION_NOT_RESELLER_INITIATED: Can only activate reseller-initiated
        /// suspensions and entitlements that have accepted the TOS.
        /// * NOT_SUSPENDED: Can only activate suspended entitlements not in an ACTIVE
        /// state.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> ActivateEntitlementAsync(ActivateEntitlementRequest request, st::CancellationToken cancellationToken) =>
            ActivateEntitlementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ActivateEntitlement</c>.</summary>
        public virtual lro::OperationsClient ActivateEntitlementOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ActivateEntitlement</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Entitlement, OperationMetadata> PollOnceActivateEntitlement(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ActivateEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ActivateEntitlement</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Entitlement, OperationMetadata>> PollOnceActivateEntitlementAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Entitlement, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ActivateEntitlementOperationsClient, callSettings);

        /// <summary>
        /// Transfers customer entitlements to new reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * Specify all transferring entitlements.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<TransferEntitlementsResponse, OperationMetadata> TransferEntitlements(TransferEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Transfers customer entitlements to new reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * Specify all transferring entitlements.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TransferEntitlementsResponse, OperationMetadata>> TransferEntitlementsAsync(TransferEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Transfers customer entitlements to new reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * Specify all transferring entitlements.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<TransferEntitlementsResponse, OperationMetadata>> TransferEntitlementsAsync(TransferEntitlementsRequest request, st::CancellationToken cancellationToken) =>
            TransferEntitlementsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TransferEntitlements</c>.</summary>
        public virtual lro::OperationsClient TransferEntitlementsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>TransferEntitlements</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<TransferEntitlementsResponse, OperationMetadata> PollOnceTransferEntitlements(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TransferEntitlementsResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TransferEntitlementsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TransferEntitlements</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<TransferEntitlementsResponse, OperationMetadata>> PollOnceTransferEntitlementsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<TransferEntitlementsResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TransferEntitlementsOperationsClient, callSettings);

        /// <summary>
        /// Transfers customer entitlements from their current reseller to Google.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> TransferEntitlementsToGoogle(TransferEntitlementsToGoogleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Transfers customer entitlements from their current reseller to Google.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> TransferEntitlementsToGoogleAsync(TransferEntitlementsToGoogleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Transfers customer entitlements from their current reseller to Google.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> TransferEntitlementsToGoogleAsync(TransferEntitlementsToGoogleRequest request, st::CancellationToken cancellationToken) =>
            TransferEntitlementsToGoogleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>TransferEntitlementsToGoogle</c>.</summary>
        public virtual lro::OperationsClient TransferEntitlementsToGoogleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TransferEntitlementsToGoogle</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceTransferEntitlementsToGoogle(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TransferEntitlementsToGoogleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>TransferEntitlementsToGoogle</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceTransferEntitlementsToGoogleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), TransferEntitlementsToGoogleOperationsClient, callSettings);

        /// <summary>
        /// List [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s
        /// belonging to a distributor. You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// The list of the distributor account's
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChannelPartnerLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelPartnerLinksResponse, ChannelPartnerLink> ListChannelPartnerLinks(ListChannelPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s
        /// belonging to a distributor. You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// The list of the distributor account's
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChannelPartnerLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelPartnerLinksResponse, ChannelPartnerLink> ListChannelPartnerLinksAsync(ListChannelPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: ChannelPartnerLink resource not found because of an
        /// invalid channel partner link name.
        /// 
        /// Return value:
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerLink GetChannelPartnerLink(GetChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: ChannelPartnerLink resource not found because of an
        /// invalid channel partner link name.
        /// 
        /// Return value:
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerLink> GetChannelPartnerLinkAsync(GetChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: ChannelPartnerLink resource not found because of an
        /// invalid channel partner link name.
        /// 
        /// Return value:
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerLink> GetChannelPartnerLinkAsync(GetChannelPartnerLinkRequest request, st::CancellationToken cancellationToken) =>
            GetChannelPartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Initiates a channel partner link between a distributor and a reseller, or
        /// between resellers in an n-tier reseller channel.
        /// Invited partners need to follow the invite_link_uri provided in the
        /// response to accept. After accepting the invitation, a link is set up
        /// between the two parties.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * ALREADY_EXISTS: The ChannelPartnerLink sent in the request already
        /// exists.
        /// * NOT_FOUND: No Cloud Identity customer exists for provided domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerLink CreateChannelPartnerLink(CreateChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a channel partner link between a distributor and a reseller, or
        /// between resellers in an n-tier reseller channel.
        /// Invited partners need to follow the invite_link_uri provided in the
        /// response to accept. After accepting the invitation, a link is set up
        /// between the two parties.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * ALREADY_EXISTS: The ChannelPartnerLink sent in the request already
        /// exists.
        /// * NOT_FOUND: No Cloud Identity customer exists for provided domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerLink> CreateChannelPartnerLinkAsync(CreateChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Initiates a channel partner link between a distributor and a reseller, or
        /// between resellers in an n-tier reseller channel.
        /// Invited partners need to follow the invite_link_uri provided in the
        /// response to accept. After accepting the invitation, a link is set up
        /// between the two parties.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * ALREADY_EXISTS: The ChannelPartnerLink sent in the request already
        /// exists.
        /// * NOT_FOUND: No Cloud Identity customer exists for provided domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerLink> CreateChannelPartnerLinkAsync(CreateChannelPartnerLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateChannelPartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a channel partner link. Distributors call this method to change a
        /// link's status. For example, to suspend a partner link.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Link state cannot change from invited to active or suspended.
        /// * Cannot send reseller_cloud_identity_id, invite_url, or name in update
        /// mask.
        /// * NOT_FOUND: ChannelPartnerLink resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The updated
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerLink UpdateChannelPartnerLink(UpdateChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a channel partner link. Distributors call this method to change a
        /// link's status. For example, to suspend a partner link.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Link state cannot change from invited to active or suspended.
        /// * Cannot send reseller_cloud_identity_id, invite_url, or name in update
        /// mask.
        /// * NOT_FOUND: ChannelPartnerLink resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The updated
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerLink> UpdateChannelPartnerLinkAsync(UpdateChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a channel partner link. Distributors call this method to change a
        /// link's status. For example, to suspend a partner link.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Link state cannot change from invited to active or suspended.
        /// * Cannot send reseller_cloud_identity_id, invite_url, or name in update
        /// mask.
        /// * NOT_FOUND: ChannelPartnerLink resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The updated
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerLink> UpdateChannelPartnerLinkAsync(UpdateChannelPartnerLinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateChannelPartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomerRepricingConfig GetCustomerRepricingConfig(GetCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> GetCustomerRepricingConfigAsync(GetCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> GetCustomerRepricingConfigAsync(GetCustomerRepricingConfigRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerRepricingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomerRepricingConfig.
        /// Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomerRepricingConfig GetCustomerRepricingConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerRepricingConfig(new GetCustomerRepricingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomerRepricingConfig.
        /// Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> GetCustomerRepricingConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerRepricingConfigAsync(new GetCustomerRepricingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomerRepricingConfig.
        /// Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> GetCustomerRepricingConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetCustomerRepricingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomerRepricingConfig.
        /// Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomerRepricingConfig GetCustomerRepricingConfig(CustomerRepricingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerRepricingConfig(new GetCustomerRepricingConfigRequest
            {
                CustomerRepricingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomerRepricingConfig.
        /// Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> GetCustomerRepricingConfigAsync(CustomerRepricingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerRepricingConfigAsync(new GetCustomerRepricingConfigRequest
            {
                CustomerRepricingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the CustomerRepricingConfig.
        /// Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> GetCustomerRepricingConfigAsync(CustomerRepricingConfigName name, st::CancellationToken cancellationToken) =>
            GetCustomerRepricingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Customer ID
        /// * [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement]
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [CustomerRepricingConfig.update_time][google.cloud.channel.v1.CustomerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomerRepricingConfigsResponse, CustomerRepricingConfig> ListCustomerRepricingConfigs(ListCustomerRepricingConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Customer ID
        /// * [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement]
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [CustomerRepricingConfig.update_time][google.cloud.channel.v1.CustomerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomerRepricingConfigsResponse, CustomerRepricingConfig> ListCustomerRepricingConfigsAsync(ListCustomerRepricingConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Customer ID
        /// * [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement]
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [CustomerRepricingConfig.update_time][google.cloud.channel.v1.CustomerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer.
        /// Parent uses the format: accounts/{account_id}/customers/{customer_id}.
        /// Supports accounts/{account_id}/customers/- to retrieve configs for all
        /// customers.
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
        /// <returns>A pageable sequence of <see cref="CustomerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomerRepricingConfigsResponse, CustomerRepricingConfig> ListCustomerRepricingConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomerRepricingConfigsRequest request = new ListCustomerRepricingConfigsRequest
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
            return ListCustomerRepricingConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Customer ID
        /// * [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement]
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [CustomerRepricingConfig.update_time][google.cloud.channel.v1.CustomerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer.
        /// Parent uses the format: accounts/{account_id}/customers/{customer_id}.
        /// Supports accounts/{account_id}/customers/- to retrieve configs for all
        /// customers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomerRepricingConfigsResponse, CustomerRepricingConfig> ListCustomerRepricingConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomerRepricingConfigsRequest request = new ListCustomerRepricingConfigsRequest
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
            return ListCustomerRepricingConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Customer ID
        /// * [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement]
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [CustomerRepricingConfig.update_time][google.cloud.channel.v1.CustomerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer.
        /// Parent uses the format: accounts/{account_id}/customers/{customer_id}.
        /// Supports accounts/{account_id}/customers/- to retrieve configs for all
        /// customers.
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
        /// <returns>A pageable sequence of <see cref="CustomerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCustomerRepricingConfigsResponse, CustomerRepricingConfig> ListCustomerRepricingConfigs(CustomerName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomerRepricingConfigsRequest request = new ListCustomerRepricingConfigsRequest
            {
                ParentAsCustomerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomerRepricingConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Customer ID
        /// * [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement]
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [CustomerRepricingConfig.update_time][google.cloud.channel.v1.CustomerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer.
        /// Parent uses the format: accounts/{account_id}/customers/{customer_id}.
        /// Supports accounts/{account_id}/customers/- to retrieve configs for all
        /// customers.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CustomerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomerRepricingConfigsResponse, CustomerRepricingConfig> ListCustomerRepricingConfigsAsync(CustomerName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCustomerRepricingConfigsRequest request = new ListCustomerRepricingConfigsRequest
            {
                ParentAsCustomerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCustomerRepricingConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomerRepricingConfig CreateCustomerRepricingConfig(CreateCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> CreateCustomerRepricingConfigAsync(CreateCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> CreateCustomerRepricingConfigAsync(CreateCustomerRepricingConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateCustomerRepricingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer that will receive this
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomerRepricingConfig CreateCustomerRepricingConfig(string parent, CustomerRepricingConfig customerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomerRepricingConfig(new CreateCustomerRepricingConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomerRepricingConfig = gax::GaxPreconditions.CheckNotNull(customerRepricingConfig, nameof(customerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer that will receive this
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> CreateCustomerRepricingConfigAsync(string parent, CustomerRepricingConfig customerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomerRepricingConfigAsync(new CreateCustomerRepricingConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomerRepricingConfig = gax::GaxPreconditions.CheckNotNull(customerRepricingConfig, nameof(customerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer that will receive this
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> CreateCustomerRepricingConfigAsync(string parent, CustomerRepricingConfig customerRepricingConfig, st::CancellationToken cancellationToken) =>
            CreateCustomerRepricingConfigAsync(parent, customerRepricingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer that will receive this
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomerRepricingConfig CreateCustomerRepricingConfig(CustomerName parent, CustomerRepricingConfig customerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomerRepricingConfig(new CreateCustomerRepricingConfigRequest
            {
                ParentAsCustomerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomerRepricingConfig = gax::GaxPreconditions.CheckNotNull(customerRepricingConfig, nameof(customerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer that will receive this
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> CreateCustomerRepricingConfigAsync(CustomerName parent, CustomerRepricingConfig customerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateCustomerRepricingConfigAsync(new CreateCustomerRepricingConfigRequest
            {
                ParentAsCustomerName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CustomerRepricingConfig = gax::GaxPreconditions.CheckNotNull(customerRepricingConfig, nameof(customerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the customer that will receive this
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/customers/{customer_id}
        /// </param>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> CreateCustomerRepricingConfigAsync(CustomerName parent, CustomerRepricingConfig customerRepricingConfig, st::CancellationToken cancellationToken) =>
            CreateCustomerRepricingConfigAsync(parent, customerRepricingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. This method overwrites the existing
        /// CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateCustomerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateCustomerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomerRepricingConfig UpdateCustomerRepricingConfig(UpdateCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. This method overwrites the existing
        /// CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateCustomerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateCustomerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> UpdateCustomerRepricingConfigAsync(UpdateCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. This method overwrites the existing
        /// CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateCustomerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateCustomerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> UpdateCustomerRepricingConfigAsync(UpdateCustomerRepricingConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateCustomerRepricingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. This method overwrites the existing
        /// CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateCustomerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateCustomerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CustomerRepricingConfig UpdateCustomerRepricingConfig(CustomerRepricingConfig customerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomerRepricingConfig(new UpdateCustomerRepricingConfigRequest
            {
                CustomerRepricingConfig = gax::GaxPreconditions.CheckNotNull(customerRepricingConfig, nameof(customerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. This method overwrites the existing
        /// CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateCustomerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateCustomerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> UpdateCustomerRepricingConfigAsync(CustomerRepricingConfig customerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCustomerRepricingConfigAsync(new UpdateCustomerRepricingConfigRequest
            {
                CustomerRepricingConfig = gax::GaxPreconditions.CheckNotNull(customerRepricingConfig, nameof(customerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. This method overwrites the existing
        /// CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateCustomerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateCustomerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="customerRepricingConfig">
        /// Required. The CustomerRepricingConfig object to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CustomerRepricingConfig> UpdateCustomerRepricingConfigAsync(CustomerRepricingConfig customerRepricingConfig, st::CancellationToken cancellationToken) =>
            UpdateCustomerRepricingConfigAsync(customerRepricingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomerRepricingConfig(DeleteCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerRepricingConfigAsync(DeleteCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerRepricingConfigAsync(DeleteCustomerRepricingConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteCustomerRepricingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer repricing config rule to
        /// delete. Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomerRepricingConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomerRepricingConfig(new DeleteCustomerRepricingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer repricing config rule to
        /// delete. Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerRepricingConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomerRepricingConfigAsync(new DeleteCustomerRepricingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer repricing config rule to
        /// delete. Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerRepricingConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCustomerRepricingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer repricing config rule to
        /// delete. Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteCustomerRepricingConfig(CustomerRepricingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomerRepricingConfig(new DeleteCustomerRepricingConfigRequest
            {
                CustomerRepricingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer repricing config rule to
        /// delete. Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerRepricingConfigAsync(CustomerRepricingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCustomerRepricingConfigAsync(new DeleteCustomerRepricingConfigRequest
            {
                CustomerRepricingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer repricing config rule to
        /// delete. Format:
        /// accounts/{account_id}/customers/{customer_id}/customerRepricingConfigs/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerRepricingConfigAsync(CustomerRepricingConfigName name, st::CancellationToken cancellationToken) =>
            DeleteCustomerRepricingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerRepricingConfig GetChannelPartnerRepricingConfig(GetChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> GetChannelPartnerRepricingConfigAsync(GetChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> GetChannelPartnerRepricingConfigAsync(GetChannelPartnerRepricingConfigRequest request, st::CancellationToken cancellationToken) =>
            GetChannelPartnerRepricingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ChannelPartnerRepricingConfig
        /// Format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}/channelPartnerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerRepricingConfig GetChannelPartnerRepricingConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelPartnerRepricingConfig(new GetChannelPartnerRepricingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ChannelPartnerRepricingConfig
        /// Format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}/channelPartnerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> GetChannelPartnerRepricingConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelPartnerRepricingConfigAsync(new GetChannelPartnerRepricingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ChannelPartnerRepricingConfig
        /// Format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}/channelPartnerRepricingConfigs/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> GetChannelPartnerRepricingConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetChannelPartnerRepricingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ChannelPartnerRepricingConfig
        /// Format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}/channelPartnerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerRepricingConfig GetChannelPartnerRepricingConfig(ChannelPartnerRepricingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelPartnerRepricingConfig(new GetChannelPartnerRepricingConfigRequest
            {
                ChannelPartnerRepricingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ChannelPartnerRepricingConfig
        /// Format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}/channelPartnerRepricingConfigs/{id}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> GetChannelPartnerRepricingConfigAsync(ChannelPartnerRepricingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetChannelPartnerRepricingConfigAsync(new GetChannelPartnerRepricingConfigRequest
            {
                ChannelPartnerRepricingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the ChannelPartnerRepricingConfig
        /// Format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}/channelPartnerRepricingConfigs/{id}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> GetChannelPartnerRepricingConfigAsync(ChannelPartnerRepricingConfigName name, st::CancellationToken cancellationToken) =>
            GetChannelPartnerRepricingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Channel Partner ID
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [ChannelPartnerRepricingConfig.update_time][google.cloud.channel.v1.ChannelPartnerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChannelPartnerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig> ListChannelPartnerRepricingConfigs(ListChannelPartnerRepricingConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Channel Partner ID
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [ChannelPartnerRepricingConfig.update_time][google.cloud.channel.v1.ChannelPartnerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ChannelPartnerRepricingConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig> ListChannelPartnerRepricingConfigsAsync(ListChannelPartnerRepricingConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Channel Partner ID
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [ChannelPartnerRepricingConfig.update_time][google.cloud.channel.v1.ChannelPartnerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account's
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]. Parent
        /// uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}.
        /// Supports accounts/{account_id}/channelPartnerLinks/- to retrieve configs
        /// for all channel partners.
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
        /// <returns>A pageable sequence of <see cref="ChannelPartnerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig> ListChannelPartnerRepricingConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelPartnerRepricingConfigsRequest request = new ListChannelPartnerRepricingConfigsRequest
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
            return ListChannelPartnerRepricingConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Channel Partner ID
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [ChannelPartnerRepricingConfig.update_time][google.cloud.channel.v1.ChannelPartnerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account's
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]. Parent
        /// uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}.
        /// Supports accounts/{account_id}/channelPartnerLinks/- to retrieve configs
        /// for all channel partners.
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
        /// A pageable asynchronous sequence of <see cref="ChannelPartnerRepricingConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig> ListChannelPartnerRepricingConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelPartnerRepricingConfigsRequest request = new ListChannelPartnerRepricingConfigsRequest
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
            return ListChannelPartnerRepricingConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Channel Partner ID
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [ChannelPartnerRepricingConfig.update_time][google.cloud.channel.v1.ChannelPartnerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account's
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]. Parent
        /// uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}.
        /// Supports accounts/{account_id}/channelPartnerLinks/- to retrieve configs
        /// for all channel partners.
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
        /// <returns>A pageable sequence of <see cref="ChannelPartnerRepricingConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig> ListChannelPartnerRepricingConfigs(ChannelPartnerLinkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelPartnerRepricingConfigsRequest request = new ListChannelPartnerRepricingConfigsRequest
            {
                ParentAsChannelPartnerLinkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListChannelPartnerRepricingConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Channel Partner ID
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [ChannelPartnerRepricingConfig.update_time][google.cloud.channel.v1.ChannelPartnerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account's
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]. Parent
        /// uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}.
        /// Supports accounts/{account_id}/channelPartnerLinks/- to retrieve configs
        /// for all channel partners.
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
        /// A pageable asynchronous sequence of <see cref="ChannelPartnerRepricingConfig"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig> ListChannelPartnerRepricingConfigsAsync(ChannelPartnerLinkName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListChannelPartnerRepricingConfigsRequest request = new ListChannelPartnerRepricingConfigsRequest
            {
                ParentAsChannelPartnerLinkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListChannelPartnerRepricingConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerRepricingConfig CreateChannelPartnerRepricingConfig(CreateChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> CreateChannelPartnerRepricingConfigAsync(CreateChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> CreateChannelPartnerRepricingConfigAsync(CreateChannelPartnerRepricingConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateChannelPartnerRepricingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ChannelPartner that will receive the
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}
        /// </param>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerRepricingConfig CreateChannelPartnerRepricingConfig(string parent, ChannelPartnerRepricingConfig channelPartnerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelPartnerRepricingConfig(new CreateChannelPartnerRepricingConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ChannelPartnerRepricingConfig = gax::GaxPreconditions.CheckNotNull(channelPartnerRepricingConfig, nameof(channelPartnerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ChannelPartner that will receive the
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}
        /// </param>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> CreateChannelPartnerRepricingConfigAsync(string parent, ChannelPartnerRepricingConfig channelPartnerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelPartnerRepricingConfigAsync(new CreateChannelPartnerRepricingConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ChannelPartnerRepricingConfig = gax::GaxPreconditions.CheckNotNull(channelPartnerRepricingConfig, nameof(channelPartnerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ChannelPartner that will receive the
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}
        /// </param>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> CreateChannelPartnerRepricingConfigAsync(string parent, ChannelPartnerRepricingConfig channelPartnerRepricingConfig, st::CancellationToken cancellationToken) =>
            CreateChannelPartnerRepricingConfigAsync(parent, channelPartnerRepricingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ChannelPartner that will receive the
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}
        /// </param>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerRepricingConfig CreateChannelPartnerRepricingConfig(ChannelPartnerLinkName parent, ChannelPartnerRepricingConfig channelPartnerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelPartnerRepricingConfig(new CreateChannelPartnerRepricingConfigRequest
            {
                ParentAsChannelPartnerLinkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ChannelPartnerRepricingConfig = gax::GaxPreconditions.CheckNotNull(channelPartnerRepricingConfig, nameof(channelPartnerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ChannelPartner that will receive the
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}
        /// </param>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> CreateChannelPartnerRepricingConfigAsync(ChannelPartnerLinkName parent, ChannelPartnerRepricingConfig channelPartnerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateChannelPartnerRepricingConfigAsync(new CreateChannelPartnerRepricingConfigRequest
            {
                ParentAsChannelPartnerLinkName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ChannelPartnerRepricingConfig = gax::GaxPreconditions.CheckNotNull(channelPartnerRepricingConfig, nameof(channelPartnerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the ChannelPartner that will receive the
        /// repricing config. Parent uses the format:
        /// accounts/{account_id}/channelPartnerLinks/{channel_partner_id}
        /// </param>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> CreateChannelPartnerRepricingConfigAsync(ChannelPartnerLinkName parent, ChannelPartnerRepricingConfig channelPartnerRepricingConfig, st::CancellationToken cancellationToken) =>
            CreateChannelPartnerRepricingConfigAsync(parent, channelPartnerRepricingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. This method overwrites
        /// the existing CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateChannelPartnerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateChannelPartnerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerRepricingConfig UpdateChannelPartnerRepricingConfig(UpdateChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. This method overwrites
        /// the existing CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateChannelPartnerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateChannelPartnerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> UpdateChannelPartnerRepricingConfigAsync(UpdateChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. This method overwrites
        /// the existing CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateChannelPartnerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateChannelPartnerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> UpdateChannelPartnerRepricingConfigAsync(UpdateChannelPartnerRepricingConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateChannelPartnerRepricingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. This method overwrites
        /// the existing CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateChannelPartnerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateChannelPartnerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerRepricingConfig UpdateChannelPartnerRepricingConfig(ChannelPartnerRepricingConfig channelPartnerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            UpdateChannelPartnerRepricingConfig(new UpdateChannelPartnerRepricingConfigRequest
            {
                ChannelPartnerRepricingConfig = gax::GaxPreconditions.CheckNotNull(channelPartnerRepricingConfig, nameof(channelPartnerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. This method overwrites
        /// the existing CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateChannelPartnerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateChannelPartnerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> UpdateChannelPartnerRepricingConfigAsync(ChannelPartnerRepricingConfig channelPartnerRepricingConfig, gaxgrpc::CallSettings callSettings = null) =>
            UpdateChannelPartnerRepricingConfigAsync(new UpdateChannelPartnerRepricingConfigRequest
            {
                ChannelPartnerRepricingConfig = gax::GaxPreconditions.CheckNotNull(channelPartnerRepricingConfig, nameof(channelPartnerRepricingConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. This method overwrites
        /// the existing CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateChannelPartnerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateChannelPartnerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="channelPartnerRepricingConfig">
        /// Required. The ChannelPartnerRepricingConfig object to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerRepricingConfig> UpdateChannelPartnerRepricingConfigAsync(ChannelPartnerRepricingConfig channelPartnerRepricingConfig, st::CancellationToken cancellationToken) =>
            UpdateChannelPartnerRepricingConfigAsync(channelPartnerRepricingConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteChannelPartnerRepricingConfig(DeleteChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteChannelPartnerRepricingConfigAsync(DeleteChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteChannelPartnerRepricingConfigAsync(DeleteChannelPartnerRepricingConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteChannelPartnerRepricingConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the channel partner repricing config rule to
        /// delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteChannelPartnerRepricingConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelPartnerRepricingConfig(new DeleteChannelPartnerRepricingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the channel partner repricing config rule to
        /// delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteChannelPartnerRepricingConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelPartnerRepricingConfigAsync(new DeleteChannelPartnerRepricingConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the channel partner repricing config rule to
        /// delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteChannelPartnerRepricingConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteChannelPartnerRepricingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the channel partner repricing config rule to
        /// delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteChannelPartnerRepricingConfig(ChannelPartnerRepricingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelPartnerRepricingConfig(new DeleteChannelPartnerRepricingConfigRequest
            {
                ChannelPartnerRepricingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the channel partner repricing config rule to
        /// delete.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteChannelPartnerRepricingConfigAsync(ChannelPartnerRepricingConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteChannelPartnerRepricingConfigAsync(new DeleteChannelPartnerRepricingConfigRequest
            {
                ChannelPartnerRepricingConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the channel partner repricing config rule to
        /// delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteChannelPartnerRepricingConfigAsync(ChannelPartnerRepricingConfigName name, st::CancellationToken cancellationToken) =>
            DeleteChannelPartnerRepricingConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Rebilling supported SKU groups the account is authorized to
        /// sell.
        /// Reference: https://cloud.google.com/skus/sku-groups
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different, or the account doesn't exist.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the [SkuGroup][google.cloud.channel.v1.SkuGroup] resources.
        /// The data for each resource is displayed in the alphabetical order of SKU
        /// group display name.
        /// The data for each resource is displayed in the ascending order of
        /// [SkuGroup.display_name][google.cloud.channel.v1.SkuGroup.display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SkuGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroups(ListSkuGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Rebilling supported SKU groups the account is authorized to
        /// sell.
        /// Reference: https://cloud.google.com/skus/sku-groups
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different, or the account doesn't exist.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the [SkuGroup][google.cloud.channel.v1.SkuGroup] resources.
        /// The data for each resource is displayed in the alphabetical order of SKU
        /// group display name.
        /// The data for each resource is displayed in the ascending order of
        /// [SkuGroup.display_name][google.cloud.channel.v1.SkuGroup.display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SkuGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroupsAsync(ListSkuGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Rebilling supported SKU groups the account is authorized to
        /// sell.
        /// Reference: https://cloud.google.com/skus/sku-groups
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different, or the account doesn't exist.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the [SkuGroup][google.cloud.channel.v1.SkuGroup] resources.
        /// The data for each resource is displayed in the alphabetical order of SKU
        /// group display name.
        /// The data for each resource is displayed in the ascending order of
        /// [SkuGroup.display_name][google.cloud.channel.v1.SkuGroup.display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account from which to list SKU groups.
        /// Parent uses the format: accounts/{account}.
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
        /// <returns>A pageable sequence of <see cref="SkuGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkuGroupsRequest request = new ListSkuGroupsRequest
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
            return ListSkuGroups(request, callSettings);
        }

        /// <summary>
        /// Lists the Rebilling supported SKU groups the account is authorized to
        /// sell.
        /// Reference: https://cloud.google.com/skus/sku-groups
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different, or the account doesn't exist.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the [SkuGroup][google.cloud.channel.v1.SkuGroup] resources.
        /// The data for each resource is displayed in the alphabetical order of SKU
        /// group display name.
        /// The data for each resource is displayed in the ascending order of
        /// [SkuGroup.display_name][google.cloud.channel.v1.SkuGroup.display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the account from which to list SKU groups.
        /// Parent uses the format: accounts/{account}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SkuGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkuGroupsRequest request = new ListSkuGroupsRequest
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
            return ListSkuGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Billable SKUs in a given SKU group.
        /// 
        /// Possible error codes:
        /// PERMISSION_DENIED: If the account making the request and the account
        /// being queried for are different, or the account doesn't exist.
        /// INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request.
        /// INTERNAL: Any non-user error related to technical issue in the
        /// backend. In this case, contact cloud channel support.
        /// 
        /// Return Value:
        /// If successful, the [BillableSku][google.cloud.channel.v1.BillableSku]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * [BillableSku.service_display_name][google.cloud.channel.v1.BillableSku.service_display_name]
        /// * [BillableSku.sku_display_name][google.cloud.channel.v1.BillableSku.sku_display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BillableSku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkuGroupBillableSkusResponse, BillableSku> ListSkuGroupBillableSkus(ListSkuGroupBillableSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Billable SKUs in a given SKU group.
        /// 
        /// Possible error codes:
        /// PERMISSION_DENIED: If the account making the request and the account
        /// being queried for are different, or the account doesn't exist.
        /// INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request.
        /// INTERNAL: Any non-user error related to technical issue in the
        /// backend. In this case, contact cloud channel support.
        /// 
        /// Return Value:
        /// If successful, the [BillableSku][google.cloud.channel.v1.BillableSku]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * [BillableSku.service_display_name][google.cloud.channel.v1.BillableSku.service_display_name]
        /// * [BillableSku.sku_display_name][google.cloud.channel.v1.BillableSku.sku_display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BillableSku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkuGroupBillableSkusResponse, BillableSku> ListSkuGroupBillableSkusAsync(ListSkuGroupBillableSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Billable SKUs in a given SKU group.
        /// 
        /// Possible error codes:
        /// PERMISSION_DENIED: If the account making the request and the account
        /// being queried for are different, or the account doesn't exist.
        /// INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request.
        /// INTERNAL: Any non-user error related to technical issue in the
        /// backend. In this case, contact cloud channel support.
        /// 
        /// Return Value:
        /// If successful, the [BillableSku][google.cloud.channel.v1.BillableSku]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * [BillableSku.service_display_name][google.cloud.channel.v1.BillableSku.service_display_name]
        /// * [BillableSku.sku_display_name][google.cloud.channel.v1.BillableSku.sku_display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the SKU group.
        /// Format: accounts/{account}/skuGroups/{sku_group}.
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
        /// <returns>A pageable sequence of <see cref="BillableSku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkuGroupBillableSkusResponse, BillableSku> ListSkuGroupBillableSkus(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkuGroupBillableSkusRequest request = new ListSkuGroupBillableSkusRequest
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
            return ListSkuGroupBillableSkus(request, callSettings);
        }

        /// <summary>
        /// Lists the Billable SKUs in a given SKU group.
        /// 
        /// Possible error codes:
        /// PERMISSION_DENIED: If the account making the request and the account
        /// being queried for are different, or the account doesn't exist.
        /// INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request.
        /// INTERNAL: Any non-user error related to technical issue in the
        /// backend. In this case, contact cloud channel support.
        /// 
        /// Return Value:
        /// If successful, the [BillableSku][google.cloud.channel.v1.BillableSku]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * [BillableSku.service_display_name][google.cloud.channel.v1.BillableSku.service_display_name]
        /// * [BillableSku.sku_display_name][google.cloud.channel.v1.BillableSku.sku_display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the SKU group.
        /// Format: accounts/{account}/skuGroups/{sku_group}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BillableSku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkuGroupBillableSkusResponse, BillableSku> ListSkuGroupBillableSkusAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkuGroupBillableSkusRequest request = new ListSkuGroupBillableSkusRequest
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
            return ListSkuGroupBillableSkusAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the Billable SKUs in a given SKU group.
        /// 
        /// Possible error codes:
        /// PERMISSION_DENIED: If the account making the request and the account
        /// being queried for are different, or the account doesn't exist.
        /// INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request.
        /// INTERNAL: Any non-user error related to technical issue in the
        /// backend. In this case, contact cloud channel support.
        /// 
        /// Return Value:
        /// If successful, the [BillableSku][google.cloud.channel.v1.BillableSku]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * [BillableSku.service_display_name][google.cloud.channel.v1.BillableSku.service_display_name]
        /// * [BillableSku.sku_display_name][google.cloud.channel.v1.BillableSku.sku_display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the SKU group.
        /// Format: accounts/{account}/skuGroups/{sku_group}.
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
        /// <returns>A pageable sequence of <see cref="BillableSku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkuGroupBillableSkusResponse, BillableSku> ListSkuGroupBillableSkus(SkuGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkuGroupBillableSkusRequest request = new ListSkuGroupBillableSkusRequest
            {
                ParentAsSkuGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSkuGroupBillableSkus(request, callSettings);
        }

        /// <summary>
        /// Lists the Billable SKUs in a given SKU group.
        /// 
        /// Possible error codes:
        /// PERMISSION_DENIED: If the account making the request and the account
        /// being queried for are different, or the account doesn't exist.
        /// INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request.
        /// INTERNAL: Any non-user error related to technical issue in the
        /// backend. In this case, contact cloud channel support.
        /// 
        /// Return Value:
        /// If successful, the [BillableSku][google.cloud.channel.v1.BillableSku]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * [BillableSku.service_display_name][google.cloud.channel.v1.BillableSku.service_display_name]
        /// * [BillableSku.sku_display_name][google.cloud.channel.v1.BillableSku.sku_display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="parent">
        /// Required. Resource name of the SKU group.
        /// Format: accounts/{account}/skuGroups/{sku_group}.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BillableSku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkuGroupBillableSkusResponse, BillableSku> ListSkuGroupBillableSkusAsync(SkuGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkuGroupBillableSkusRequest request = new ListSkuGroupBillableSkusRequest
            {
                ParentAsSkuGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSkuGroupBillableSkusAsync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested [Offer][google.cloud.channel.v1.Offer] resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The entitlement doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement or offer was not found.
        /// 
        /// Return value:
        /// The [Offer][google.cloud.channel.v1.Offer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Offer LookupOffer(LookupOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Offer][google.cloud.channel.v1.Offer] resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The entitlement doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement or offer was not found.
        /// 
        /// Return value:
        /// The [Offer][google.cloud.channel.v1.Offer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Offer> LookupOfferAsync(LookupOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Offer][google.cloud.channel.v1.Offer] resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The entitlement doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement or offer was not found.
        /// 
        /// Return value:
        /// The [Offer][google.cloud.channel.v1.Offer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Offer> LookupOfferAsync(LookupOfferRequest request, st::CancellationToken cancellationToken) =>
            LookupOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the Products the reseller is authorized to sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Products the reseller is authorized to sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the SKUs for a product the reseller is authorized to sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the SKUs for a product the reseller is authorized to sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Offers the reseller can sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Offer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListOffersResponse, Offer> ListOffers(ListOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the Offers the reseller can sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Offer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListOffersResponse, Offer> ListOffersAsync(ListOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the following:
        /// 
        /// * SKUs that you can purchase for a customer
        /// * SKUs that you can upgrade or downgrade for an entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PurchasableSku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPurchasableSkusResponse, PurchasableSku> ListPurchasableSkus(ListPurchasableSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the following:
        /// 
        /// * SKUs that you can purchase for a customer
        /// * SKUs that you can upgrade or downgrade for an entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PurchasableSku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPurchasableSkusResponse, PurchasableSku> ListPurchasableSkusAsync(ListPurchasableSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the following:
        /// 
        /// * Offers that you can purchase for a customer.
        /// * Offers that you can change for an entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PurchasableOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPurchasableOffersResponse, PurchasableOffer> ListPurchasableOffers(ListPurchasableOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the following:
        /// 
        /// * Offers that you can purchase for a customer.
        /// * Offers that you can change for an entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PurchasableOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPurchasableOffersResponse, PurchasableOffer> ListPurchasableOffersAsync(ListPurchasableOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the billing accounts that are eligible to purchase particular SKUs
        /// for a given customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// Based on the provided list of SKUs, returns a list of SKU groups that must
        /// be purchased using the same billing account and the billing accounts
        /// eligible to purchase each SKU group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual QueryEligibleBillingAccountsResponse QueryEligibleBillingAccounts(QueryEligibleBillingAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the billing accounts that are eligible to purchase particular SKUs
        /// for a given customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// Based on the provided list of SKUs, returns a list of SKU groups that must
        /// be purchased using the same billing account and the billing accounts
        /// eligible to purchase each SKU group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryEligibleBillingAccountsResponse> QueryEligibleBillingAccountsAsync(QueryEligibleBillingAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the billing accounts that are eligible to purchase particular SKUs
        /// for a given customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// Based on the provided list of SKUs, returns a list of SKU groups that must
        /// be purchased using the same billing account and the billing accounts
        /// eligible to purchase each SKU group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<QueryEligibleBillingAccountsResponse> QueryEligibleBillingAccountsAsync(QueryEligibleBillingAccountsRequest request, st::CancellationToken cancellationToken) =>
            QueryEligibleBillingAccountsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub
        /// topic for this Channel Services account. After you create a
        /// subscriber, you get the events through
        /// [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name with the registered service email address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RegisterSubscriberResponse RegisterSubscriber(RegisterSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub
        /// topic for this Channel Services account. After you create a
        /// subscriber, you get the events through
        /// [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name with the registered service email address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterSubscriberResponse> RegisterSubscriberAsync(RegisterSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub
        /// topic for this Channel Services account. After you create a
        /// subscriber, you get the events through
        /// [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name with the registered service email address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RegisterSubscriberResponse> RegisterSubscriberAsync(RegisterSubscriberRequest request, st::CancellationToken cancellationToken) =>
            RegisterSubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unregisters a service account with subscriber privileges on the Cloud
        /// Pub/Sub topic created for this Channel Services account. If there are no
        /// service accounts left with subscriber privileges, this deletes the topic.
        /// You can call ListSubscribers to check for these accounts.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name that unregistered the service email address.
        /// Returns a success response if the service email address wasn't registered
        /// with the topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UnregisterSubscriberResponse UnregisterSubscriber(UnregisterSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unregisters a service account with subscriber privileges on the Cloud
        /// Pub/Sub topic created for this Channel Services account. If there are no
        /// service accounts left with subscriber privileges, this deletes the topic.
        /// You can call ListSubscribers to check for these accounts.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name that unregistered the service email address.
        /// Returns a success response if the service email address wasn't registered
        /// with the topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnregisterSubscriberResponse> UnregisterSubscriberAsync(UnregisterSubscriberRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unregisters a service account with subscriber privileges on the Cloud
        /// Pub/Sub topic created for this Channel Services account. If there are no
        /// service accounts left with subscriber privileges, this deletes the topic.
        /// You can call ListSubscribers to check for these accounts.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name that unregistered the service email address.
        /// Returns a success response if the service email address wasn't registered
        /// with the topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UnregisterSubscriberResponse> UnregisterSubscriberAsync(UnregisterSubscriberRequest request, st::CancellationToken cancellationToken) =>
            UnregisterSubscriberAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists service accounts with subscriber privileges on the Cloud Pub/Sub
        /// topic created for this Channel Services account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// A list of service email addresses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSubscribersResponse, string> ListSubscribers(ListSubscribersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists service accounts with subscriber privileges on the Cloud Pub/Sub
        /// topic created for this Channel Services account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// A list of service email addresses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSubscribersResponse, string> ListSubscribersAsync(ListSubscribersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List entitlement history.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different.
        /// * INVALID_ARGUMENT: Missing or invalid required fields in the request.
        /// * NOT_FOUND: The parent resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// * INTERNAL: Any non-user error related to a technical issue in the backend.
        /// In this case, contact CloudChannel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// In this case, contact Cloud Channel support.
        /// 
        /// Return value:
        /// List of [EntitlementChange][google.cloud.channel.v1.EntitlementChange]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntitlementChange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementChangesResponse, EntitlementChange> ListEntitlementChanges(ListEntitlementChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List entitlement history.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different.
        /// * INVALID_ARGUMENT: Missing or invalid required fields in the request.
        /// * NOT_FOUND: The parent resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// * INTERNAL: Any non-user error related to a technical issue in the backend.
        /// In this case, contact CloudChannel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// In this case, contact Cloud Channel support.
        /// 
        /// Return value:
        /// List of [EntitlementChange][google.cloud.channel.v1.EntitlementChange]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntitlementChange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementChangesResponse, EntitlementChange> ListEntitlementChangesAsync(ListEntitlementChangesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List entitlement history.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different.
        /// * INVALID_ARGUMENT: Missing or invalid required fields in the request.
        /// * NOT_FOUND: The parent resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// * INTERNAL: Any non-user error related to a technical issue in the backend.
        /// In this case, contact CloudChannel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// In this case, contact Cloud Channel support.
        /// 
        /// Return value:
        /// List of [EntitlementChange][google.cloud.channel.v1.EntitlementChange]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entitlement for which to list
        /// entitlement changes. The `-` wildcard may be used to match entitlements
        /// across a customer. Formats:
        /// 
        /// * accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
        /// * accounts/{account_id}/customers/{customer_id}/entitlements/-
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
        /// <returns>A pageable sequence of <see cref="EntitlementChange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementChangesResponse, EntitlementChange> ListEntitlementChanges(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementChangesRequest request = new ListEntitlementChangesRequest
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
            return ListEntitlementChanges(request, callSettings);
        }

        /// <summary>
        /// List entitlement history.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different.
        /// * INVALID_ARGUMENT: Missing or invalid required fields in the request.
        /// * NOT_FOUND: The parent resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// * INTERNAL: Any non-user error related to a technical issue in the backend.
        /// In this case, contact CloudChannel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// In this case, contact Cloud Channel support.
        /// 
        /// Return value:
        /// List of [EntitlementChange][google.cloud.channel.v1.EntitlementChange]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entitlement for which to list
        /// entitlement changes. The `-` wildcard may be used to match entitlements
        /// across a customer. Formats:
        /// 
        /// * accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
        /// * accounts/{account_id}/customers/{customer_id}/entitlements/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntitlementChange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementChangesResponse, EntitlementChange> ListEntitlementChangesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementChangesRequest request = new ListEntitlementChangesRequest
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
            return ListEntitlementChangesAsync(request, callSettings);
        }

        /// <summary>
        /// List entitlement history.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different.
        /// * INVALID_ARGUMENT: Missing or invalid required fields in the request.
        /// * NOT_FOUND: The parent resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// * INTERNAL: Any non-user error related to a technical issue in the backend.
        /// In this case, contact CloudChannel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// In this case, contact Cloud Channel support.
        /// 
        /// Return value:
        /// List of [EntitlementChange][google.cloud.channel.v1.EntitlementChange]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entitlement for which to list
        /// entitlement changes. The `-` wildcard may be used to match entitlements
        /// across a customer. Formats:
        /// 
        /// * accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
        /// * accounts/{account_id}/customers/{customer_id}/entitlements/-
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
        /// <returns>A pageable sequence of <see cref="EntitlementChange"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementChangesResponse, EntitlementChange> ListEntitlementChanges(EntitlementName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementChangesRequest request = new ListEntitlementChangesRequest
            {
                ParentAsEntitlementName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitlementChanges(request, callSettings);
        }

        /// <summary>
        /// List entitlement history.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different.
        /// * INVALID_ARGUMENT: Missing or invalid required fields in the request.
        /// * NOT_FOUND: The parent resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// * INTERNAL: Any non-user error related to a technical issue in the backend.
        /// In this case, contact CloudChannel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// In this case, contact Cloud Channel support.
        /// 
        /// Return value:
        /// List of [EntitlementChange][google.cloud.channel.v1.EntitlementChange]s.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entitlement for which to list
        /// entitlement changes. The `-` wildcard may be used to match entitlements
        /// across a customer. Formats:
        /// 
        /// * accounts/{account_id}/customers/{customer_id}/entitlements/{entitlement_id}
        /// * accounts/{account_id}/customers/{customer_id}/entitlements/-
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntitlementChange"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementChangesResponse, EntitlementChange> ListEntitlementChangesAsync(EntitlementName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntitlementChangesRequest request = new ListEntitlementChangesRequest
            {
                ParentAsEntitlementName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntitlementChangesAsync(request, callSettings);
        }
    }

    /// <summary>CloudChannelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// CloudChannelService lets Google cloud resellers and distributors manage
    /// their customers, channel partners, entitlements, and reports.
    /// 
    /// Using this service:
    /// 1. Resellers and distributors can manage a customer entity.
    /// 2. Distributors can register an authorized reseller in their channel and
    /// provide them with delegated admin access.
    /// 3. Resellers and distributors can manage customer entitlements.
    /// 
    /// CloudChannelService exposes the following resources:
    /// - [Customer][google.cloud.channel.v1.Customer]s: An entity-usually an
    /// enterprise-managed by a reseller or distributor.
    /// 
    /// - [Entitlement][google.cloud.channel.v1.Entitlement]s: An entity that
    /// provides a customer with the means to use a service. Entitlements are created
    /// or updated as a result of a successful fulfillment.
    /// 
    /// - [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s: An
    /// entity that identifies links between distributors and their indirect
    /// resellers in a channel.
    /// </remarks>
    public sealed partial class CloudChannelServiceClientImpl : CloudChannelServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListCustomersRequest, ListCustomersResponse> _callListCustomers;

        private readonly gaxgrpc::ApiCall<GetCustomerRequest, Customer> _callGetCustomer;

        private readonly gaxgrpc::ApiCall<CheckCloudIdentityAccountsExistRequest, CheckCloudIdentityAccountsExistResponse> _callCheckCloudIdentityAccountsExist;

        private readonly gaxgrpc::ApiCall<CreateCustomerRequest, Customer> _callCreateCustomer;

        private readonly gaxgrpc::ApiCall<UpdateCustomerRequest, Customer> _callUpdateCustomer;

        private readonly gaxgrpc::ApiCall<DeleteCustomerRequest, wkt::Empty> _callDeleteCustomer;

        private readonly gaxgrpc::ApiCall<ImportCustomerRequest, Customer> _callImportCustomer;

        private readonly gaxgrpc::ApiCall<ProvisionCloudIdentityRequest, lro::Operation> _callProvisionCloudIdentity;

        private readonly gaxgrpc::ApiCall<ListEntitlementsRequest, ListEntitlementsResponse> _callListEntitlements;

        private readonly gaxgrpc::ApiCall<ListTransferableSkusRequest, ListTransferableSkusResponse> _callListTransferableSkus;

        private readonly gaxgrpc::ApiCall<ListTransferableOffersRequest, ListTransferableOffersResponse> _callListTransferableOffers;

        private readonly gaxgrpc::ApiCall<GetEntitlementRequest, Entitlement> _callGetEntitlement;

        private readonly gaxgrpc::ApiCall<CreateEntitlementRequest, lro::Operation> _callCreateEntitlement;

        private readonly gaxgrpc::ApiCall<ChangeParametersRequest, lro::Operation> _callChangeParameters;

        private readonly gaxgrpc::ApiCall<ChangeRenewalSettingsRequest, lro::Operation> _callChangeRenewalSettings;

        private readonly gaxgrpc::ApiCall<ChangeOfferRequest, lro::Operation> _callChangeOffer;

        private readonly gaxgrpc::ApiCall<StartPaidServiceRequest, lro::Operation> _callStartPaidService;

        private readonly gaxgrpc::ApiCall<SuspendEntitlementRequest, lro::Operation> _callSuspendEntitlement;

        private readonly gaxgrpc::ApiCall<CancelEntitlementRequest, lro::Operation> _callCancelEntitlement;

        private readonly gaxgrpc::ApiCall<ActivateEntitlementRequest, lro::Operation> _callActivateEntitlement;

        private readonly gaxgrpc::ApiCall<TransferEntitlementsRequest, lro::Operation> _callTransferEntitlements;

        private readonly gaxgrpc::ApiCall<TransferEntitlementsToGoogleRequest, lro::Operation> _callTransferEntitlementsToGoogle;

        private readonly gaxgrpc::ApiCall<ListChannelPartnerLinksRequest, ListChannelPartnerLinksResponse> _callListChannelPartnerLinks;

        private readonly gaxgrpc::ApiCall<GetChannelPartnerLinkRequest, ChannelPartnerLink> _callGetChannelPartnerLink;

        private readonly gaxgrpc::ApiCall<CreateChannelPartnerLinkRequest, ChannelPartnerLink> _callCreateChannelPartnerLink;

        private readonly gaxgrpc::ApiCall<UpdateChannelPartnerLinkRequest, ChannelPartnerLink> _callUpdateChannelPartnerLink;

        private readonly gaxgrpc::ApiCall<GetCustomerRepricingConfigRequest, CustomerRepricingConfig> _callGetCustomerRepricingConfig;

        private readonly gaxgrpc::ApiCall<ListCustomerRepricingConfigsRequest, ListCustomerRepricingConfigsResponse> _callListCustomerRepricingConfigs;

        private readonly gaxgrpc::ApiCall<CreateCustomerRepricingConfigRequest, CustomerRepricingConfig> _callCreateCustomerRepricingConfig;

        private readonly gaxgrpc::ApiCall<UpdateCustomerRepricingConfigRequest, CustomerRepricingConfig> _callUpdateCustomerRepricingConfig;

        private readonly gaxgrpc::ApiCall<DeleteCustomerRepricingConfigRequest, wkt::Empty> _callDeleteCustomerRepricingConfig;

        private readonly gaxgrpc::ApiCall<GetChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig> _callGetChannelPartnerRepricingConfig;

        private readonly gaxgrpc::ApiCall<ListChannelPartnerRepricingConfigsRequest, ListChannelPartnerRepricingConfigsResponse> _callListChannelPartnerRepricingConfigs;

        private readonly gaxgrpc::ApiCall<CreateChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig> _callCreateChannelPartnerRepricingConfig;

        private readonly gaxgrpc::ApiCall<UpdateChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig> _callUpdateChannelPartnerRepricingConfig;

        private readonly gaxgrpc::ApiCall<DeleteChannelPartnerRepricingConfigRequest, wkt::Empty> _callDeleteChannelPartnerRepricingConfig;

        private readonly gaxgrpc::ApiCall<ListSkuGroupsRequest, ListSkuGroupsResponse> _callListSkuGroups;

        private readonly gaxgrpc::ApiCall<ListSkuGroupBillableSkusRequest, ListSkuGroupBillableSkusResponse> _callListSkuGroupBillableSkus;

        private readonly gaxgrpc::ApiCall<LookupOfferRequest, Offer> _callLookupOffer;

        private readonly gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> _callListProducts;

        private readonly gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> _callListSkus;

        private readonly gaxgrpc::ApiCall<ListOffersRequest, ListOffersResponse> _callListOffers;

        private readonly gaxgrpc::ApiCall<ListPurchasableSkusRequest, ListPurchasableSkusResponse> _callListPurchasableSkus;

        private readonly gaxgrpc::ApiCall<ListPurchasableOffersRequest, ListPurchasableOffersResponse> _callListPurchasableOffers;

        private readonly gaxgrpc::ApiCall<QueryEligibleBillingAccountsRequest, QueryEligibleBillingAccountsResponse> _callQueryEligibleBillingAccounts;

        private readonly gaxgrpc::ApiCall<RegisterSubscriberRequest, RegisterSubscriberResponse> _callRegisterSubscriber;

        private readonly gaxgrpc::ApiCall<UnregisterSubscriberRequest, UnregisterSubscriberResponse> _callUnregisterSubscriber;

        private readonly gaxgrpc::ApiCall<ListSubscribersRequest, ListSubscribersResponse> _callListSubscribers;

        private readonly gaxgrpc::ApiCall<ListEntitlementChangesRequest, ListEntitlementChangesResponse> _callListEntitlementChanges;

        /// <summary>
        /// Constructs a client wrapper for the CloudChannelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudChannelServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CloudChannelServiceClientImpl(CloudChannelService.CloudChannelServiceClient grpcClient, CloudChannelServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CloudChannelServiceSettings effectiveSettings = settings ?? CloudChannelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ProvisionCloudIdentityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ProvisionCloudIdentityOperationsSettings, logger);
            CreateEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEntitlementOperationsSettings, logger);
            ChangeParametersOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ChangeParametersOperationsSettings, logger);
            ChangeRenewalSettingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ChangeRenewalSettingsOperationsSettings, logger);
            ChangeOfferOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ChangeOfferOperationsSettings, logger);
            StartPaidServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartPaidServiceOperationsSettings, logger);
            SuspendEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SuspendEntitlementOperationsSettings, logger);
            CancelEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CancelEntitlementOperationsSettings, logger);
            ActivateEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ActivateEntitlementOperationsSettings, logger);
            TransferEntitlementsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TransferEntitlementsOperationsSettings, logger);
            TransferEntitlementsToGoogleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TransferEntitlementsToGoogleOperationsSettings, logger);
            _callListCustomers = clientHelper.BuildApiCall<ListCustomersRequest, ListCustomersResponse>("ListCustomers", grpcClient.ListCustomersAsync, grpcClient.ListCustomers, effectiveSettings.ListCustomersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomers);
            Modify_ListCustomersApiCall(ref _callListCustomers);
            _callGetCustomer = clientHelper.BuildApiCall<GetCustomerRequest, Customer>("GetCustomer", grpcClient.GetCustomerAsync, grpcClient.GetCustomer, effectiveSettings.GetCustomerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomer);
            Modify_GetCustomerApiCall(ref _callGetCustomer);
            _callCheckCloudIdentityAccountsExist = clientHelper.BuildApiCall<CheckCloudIdentityAccountsExistRequest, CheckCloudIdentityAccountsExistResponse>("CheckCloudIdentityAccountsExist", grpcClient.CheckCloudIdentityAccountsExistAsync, grpcClient.CheckCloudIdentityAccountsExist, effectiveSettings.CheckCloudIdentityAccountsExistSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCheckCloudIdentityAccountsExist);
            Modify_CheckCloudIdentityAccountsExistApiCall(ref _callCheckCloudIdentityAccountsExist);
            _callCreateCustomer = clientHelper.BuildApiCall<CreateCustomerRequest, Customer>("CreateCustomer", grpcClient.CreateCustomerAsync, grpcClient.CreateCustomer, effectiveSettings.CreateCustomerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomer);
            Modify_CreateCustomerApiCall(ref _callCreateCustomer);
            _callUpdateCustomer = clientHelper.BuildApiCall<UpdateCustomerRequest, Customer>("UpdateCustomer", grpcClient.UpdateCustomerAsync, grpcClient.UpdateCustomer, effectiveSettings.UpdateCustomerSettings).WithGoogleRequestParam("customer.name", request => request.Customer?.Name);
            Modify_ApiCall(ref _callUpdateCustomer);
            Modify_UpdateCustomerApiCall(ref _callUpdateCustomer);
            _callDeleteCustomer = clientHelper.BuildApiCall<DeleteCustomerRequest, wkt::Empty>("DeleteCustomer", grpcClient.DeleteCustomerAsync, grpcClient.DeleteCustomer, effectiveSettings.DeleteCustomerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCustomer);
            Modify_DeleteCustomerApiCall(ref _callDeleteCustomer);
            _callImportCustomer = clientHelper.BuildApiCall<ImportCustomerRequest, Customer>("ImportCustomer", grpcClient.ImportCustomerAsync, grpcClient.ImportCustomer, effectiveSettings.ImportCustomerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportCustomer);
            Modify_ImportCustomerApiCall(ref _callImportCustomer);
            _callProvisionCloudIdentity = clientHelper.BuildApiCall<ProvisionCloudIdentityRequest, lro::Operation>("ProvisionCloudIdentity", grpcClient.ProvisionCloudIdentityAsync, grpcClient.ProvisionCloudIdentity, effectiveSettings.ProvisionCloudIdentitySettings).WithGoogleRequestParam("customer", request => request.Customer);
            Modify_ApiCall(ref _callProvisionCloudIdentity);
            Modify_ProvisionCloudIdentityApiCall(ref _callProvisionCloudIdentity);
            _callListEntitlements = clientHelper.BuildApiCall<ListEntitlementsRequest, ListEntitlementsResponse>("ListEntitlements", grpcClient.ListEntitlementsAsync, grpcClient.ListEntitlements, effectiveSettings.ListEntitlementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntitlements);
            Modify_ListEntitlementsApiCall(ref _callListEntitlements);
            _callListTransferableSkus = clientHelper.BuildApiCall<ListTransferableSkusRequest, ListTransferableSkusResponse>("ListTransferableSkus", grpcClient.ListTransferableSkusAsync, grpcClient.ListTransferableSkus, effectiveSettings.ListTransferableSkusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransferableSkus);
            Modify_ListTransferableSkusApiCall(ref _callListTransferableSkus);
            _callListTransferableOffers = clientHelper.BuildApiCall<ListTransferableOffersRequest, ListTransferableOffersResponse>("ListTransferableOffers", grpcClient.ListTransferableOffersAsync, grpcClient.ListTransferableOffers, effectiveSettings.ListTransferableOffersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransferableOffers);
            Modify_ListTransferableOffersApiCall(ref _callListTransferableOffers);
            _callGetEntitlement = clientHelper.BuildApiCall<GetEntitlementRequest, Entitlement>("GetEntitlement", grpcClient.GetEntitlementAsync, grpcClient.GetEntitlement, effectiveSettings.GetEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntitlement);
            Modify_GetEntitlementApiCall(ref _callGetEntitlement);
            _callCreateEntitlement = clientHelper.BuildApiCall<CreateEntitlementRequest, lro::Operation>("CreateEntitlement", grpcClient.CreateEntitlementAsync, grpcClient.CreateEntitlement, effectiveSettings.CreateEntitlementSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntitlement);
            Modify_CreateEntitlementApiCall(ref _callCreateEntitlement);
            _callChangeParameters = clientHelper.BuildApiCall<ChangeParametersRequest, lro::Operation>("ChangeParameters", grpcClient.ChangeParametersAsync, grpcClient.ChangeParameters, effectiveSettings.ChangeParametersSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callChangeParameters);
            Modify_ChangeParametersApiCall(ref _callChangeParameters);
            _callChangeRenewalSettings = clientHelper.BuildApiCall<ChangeRenewalSettingsRequest, lro::Operation>("ChangeRenewalSettings", grpcClient.ChangeRenewalSettingsAsync, grpcClient.ChangeRenewalSettings, effectiveSettings.ChangeRenewalSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callChangeRenewalSettings);
            Modify_ChangeRenewalSettingsApiCall(ref _callChangeRenewalSettings);
            _callChangeOffer = clientHelper.BuildApiCall<ChangeOfferRequest, lro::Operation>("ChangeOffer", grpcClient.ChangeOfferAsync, grpcClient.ChangeOffer, effectiveSettings.ChangeOfferSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callChangeOffer);
            Modify_ChangeOfferApiCall(ref _callChangeOffer);
            _callStartPaidService = clientHelper.BuildApiCall<StartPaidServiceRequest, lro::Operation>("StartPaidService", grpcClient.StartPaidServiceAsync, grpcClient.StartPaidService, effectiveSettings.StartPaidServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartPaidService);
            Modify_StartPaidServiceApiCall(ref _callStartPaidService);
            _callSuspendEntitlement = clientHelper.BuildApiCall<SuspendEntitlementRequest, lro::Operation>("SuspendEntitlement", grpcClient.SuspendEntitlementAsync, grpcClient.SuspendEntitlement, effectiveSettings.SuspendEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSuspendEntitlement);
            Modify_SuspendEntitlementApiCall(ref _callSuspendEntitlement);
            _callCancelEntitlement = clientHelper.BuildApiCall<CancelEntitlementRequest, lro::Operation>("CancelEntitlement", grpcClient.CancelEntitlementAsync, grpcClient.CancelEntitlement, effectiveSettings.CancelEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelEntitlement);
            Modify_CancelEntitlementApiCall(ref _callCancelEntitlement);
            _callActivateEntitlement = clientHelper.BuildApiCall<ActivateEntitlementRequest, lro::Operation>("ActivateEntitlement", grpcClient.ActivateEntitlementAsync, grpcClient.ActivateEntitlement, effectiveSettings.ActivateEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callActivateEntitlement);
            Modify_ActivateEntitlementApiCall(ref _callActivateEntitlement);
            _callTransferEntitlements = clientHelper.BuildApiCall<TransferEntitlementsRequest, lro::Operation>("TransferEntitlements", grpcClient.TransferEntitlementsAsync, grpcClient.TransferEntitlements, effectiveSettings.TransferEntitlementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTransferEntitlements);
            Modify_TransferEntitlementsApiCall(ref _callTransferEntitlements);
            _callTransferEntitlementsToGoogle = clientHelper.BuildApiCall<TransferEntitlementsToGoogleRequest, lro::Operation>("TransferEntitlementsToGoogle", grpcClient.TransferEntitlementsToGoogleAsync, grpcClient.TransferEntitlementsToGoogle, effectiveSettings.TransferEntitlementsToGoogleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTransferEntitlementsToGoogle);
            Modify_TransferEntitlementsToGoogleApiCall(ref _callTransferEntitlementsToGoogle);
            _callListChannelPartnerLinks = clientHelper.BuildApiCall<ListChannelPartnerLinksRequest, ListChannelPartnerLinksResponse>("ListChannelPartnerLinks", grpcClient.ListChannelPartnerLinksAsync, grpcClient.ListChannelPartnerLinks, effectiveSettings.ListChannelPartnerLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChannelPartnerLinks);
            Modify_ListChannelPartnerLinksApiCall(ref _callListChannelPartnerLinks);
            _callGetChannelPartnerLink = clientHelper.BuildApiCall<GetChannelPartnerLinkRequest, ChannelPartnerLink>("GetChannelPartnerLink", grpcClient.GetChannelPartnerLinkAsync, grpcClient.GetChannelPartnerLink, effectiveSettings.GetChannelPartnerLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChannelPartnerLink);
            Modify_GetChannelPartnerLinkApiCall(ref _callGetChannelPartnerLink);
            _callCreateChannelPartnerLink = clientHelper.BuildApiCall<CreateChannelPartnerLinkRequest, ChannelPartnerLink>("CreateChannelPartnerLink", grpcClient.CreateChannelPartnerLinkAsync, grpcClient.CreateChannelPartnerLink, effectiveSettings.CreateChannelPartnerLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateChannelPartnerLink);
            Modify_CreateChannelPartnerLinkApiCall(ref _callCreateChannelPartnerLink);
            _callUpdateChannelPartnerLink = clientHelper.BuildApiCall<UpdateChannelPartnerLinkRequest, ChannelPartnerLink>("UpdateChannelPartnerLink", grpcClient.UpdateChannelPartnerLinkAsync, grpcClient.UpdateChannelPartnerLink, effectiveSettings.UpdateChannelPartnerLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateChannelPartnerLink);
            Modify_UpdateChannelPartnerLinkApiCall(ref _callUpdateChannelPartnerLink);
            _callGetCustomerRepricingConfig = clientHelper.BuildApiCall<GetCustomerRepricingConfigRequest, CustomerRepricingConfig>("GetCustomerRepricingConfig", grpcClient.GetCustomerRepricingConfigAsync, grpcClient.GetCustomerRepricingConfig, effectiveSettings.GetCustomerRepricingConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomerRepricingConfig);
            Modify_GetCustomerRepricingConfigApiCall(ref _callGetCustomerRepricingConfig);
            _callListCustomerRepricingConfigs = clientHelper.BuildApiCall<ListCustomerRepricingConfigsRequest, ListCustomerRepricingConfigsResponse>("ListCustomerRepricingConfigs", grpcClient.ListCustomerRepricingConfigsAsync, grpcClient.ListCustomerRepricingConfigs, effectiveSettings.ListCustomerRepricingConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomerRepricingConfigs);
            Modify_ListCustomerRepricingConfigsApiCall(ref _callListCustomerRepricingConfigs);
            _callCreateCustomerRepricingConfig = clientHelper.BuildApiCall<CreateCustomerRepricingConfigRequest, CustomerRepricingConfig>("CreateCustomerRepricingConfig", grpcClient.CreateCustomerRepricingConfigAsync, grpcClient.CreateCustomerRepricingConfig, effectiveSettings.CreateCustomerRepricingConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomerRepricingConfig);
            Modify_CreateCustomerRepricingConfigApiCall(ref _callCreateCustomerRepricingConfig);
            _callUpdateCustomerRepricingConfig = clientHelper.BuildApiCall<UpdateCustomerRepricingConfigRequest, CustomerRepricingConfig>("UpdateCustomerRepricingConfig", grpcClient.UpdateCustomerRepricingConfigAsync, grpcClient.UpdateCustomerRepricingConfig, effectiveSettings.UpdateCustomerRepricingConfigSettings).WithGoogleRequestParam("customer_repricing_config.name", request => request.CustomerRepricingConfig?.Name);
            Modify_ApiCall(ref _callUpdateCustomerRepricingConfig);
            Modify_UpdateCustomerRepricingConfigApiCall(ref _callUpdateCustomerRepricingConfig);
            _callDeleteCustomerRepricingConfig = clientHelper.BuildApiCall<DeleteCustomerRepricingConfigRequest, wkt::Empty>("DeleteCustomerRepricingConfig", grpcClient.DeleteCustomerRepricingConfigAsync, grpcClient.DeleteCustomerRepricingConfig, effectiveSettings.DeleteCustomerRepricingConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCustomerRepricingConfig);
            Modify_DeleteCustomerRepricingConfigApiCall(ref _callDeleteCustomerRepricingConfig);
            _callGetChannelPartnerRepricingConfig = clientHelper.BuildApiCall<GetChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig>("GetChannelPartnerRepricingConfig", grpcClient.GetChannelPartnerRepricingConfigAsync, grpcClient.GetChannelPartnerRepricingConfig, effectiveSettings.GetChannelPartnerRepricingConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChannelPartnerRepricingConfig);
            Modify_GetChannelPartnerRepricingConfigApiCall(ref _callGetChannelPartnerRepricingConfig);
            _callListChannelPartnerRepricingConfigs = clientHelper.BuildApiCall<ListChannelPartnerRepricingConfigsRequest, ListChannelPartnerRepricingConfigsResponse>("ListChannelPartnerRepricingConfigs", grpcClient.ListChannelPartnerRepricingConfigsAsync, grpcClient.ListChannelPartnerRepricingConfigs, effectiveSettings.ListChannelPartnerRepricingConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChannelPartnerRepricingConfigs);
            Modify_ListChannelPartnerRepricingConfigsApiCall(ref _callListChannelPartnerRepricingConfigs);
            _callCreateChannelPartnerRepricingConfig = clientHelper.BuildApiCall<CreateChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig>("CreateChannelPartnerRepricingConfig", grpcClient.CreateChannelPartnerRepricingConfigAsync, grpcClient.CreateChannelPartnerRepricingConfig, effectiveSettings.CreateChannelPartnerRepricingConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateChannelPartnerRepricingConfig);
            Modify_CreateChannelPartnerRepricingConfigApiCall(ref _callCreateChannelPartnerRepricingConfig);
            _callUpdateChannelPartnerRepricingConfig = clientHelper.BuildApiCall<UpdateChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig>("UpdateChannelPartnerRepricingConfig", grpcClient.UpdateChannelPartnerRepricingConfigAsync, grpcClient.UpdateChannelPartnerRepricingConfig, effectiveSettings.UpdateChannelPartnerRepricingConfigSettings).WithGoogleRequestParam("channel_partner_repricing_config.name", request => request.ChannelPartnerRepricingConfig?.Name);
            Modify_ApiCall(ref _callUpdateChannelPartnerRepricingConfig);
            Modify_UpdateChannelPartnerRepricingConfigApiCall(ref _callUpdateChannelPartnerRepricingConfig);
            _callDeleteChannelPartnerRepricingConfig = clientHelper.BuildApiCall<DeleteChannelPartnerRepricingConfigRequest, wkt::Empty>("DeleteChannelPartnerRepricingConfig", grpcClient.DeleteChannelPartnerRepricingConfigAsync, grpcClient.DeleteChannelPartnerRepricingConfig, effectiveSettings.DeleteChannelPartnerRepricingConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteChannelPartnerRepricingConfig);
            Modify_DeleteChannelPartnerRepricingConfigApiCall(ref _callDeleteChannelPartnerRepricingConfig);
            _callListSkuGroups = clientHelper.BuildApiCall<ListSkuGroupsRequest, ListSkuGroupsResponse>("ListSkuGroups", grpcClient.ListSkuGroupsAsync, grpcClient.ListSkuGroups, effectiveSettings.ListSkuGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkuGroups);
            Modify_ListSkuGroupsApiCall(ref _callListSkuGroups);
            _callListSkuGroupBillableSkus = clientHelper.BuildApiCall<ListSkuGroupBillableSkusRequest, ListSkuGroupBillableSkusResponse>("ListSkuGroupBillableSkus", grpcClient.ListSkuGroupBillableSkusAsync, grpcClient.ListSkuGroupBillableSkus, effectiveSettings.ListSkuGroupBillableSkusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkuGroupBillableSkus);
            Modify_ListSkuGroupBillableSkusApiCall(ref _callListSkuGroupBillableSkus);
            _callLookupOffer = clientHelper.BuildApiCall<LookupOfferRequest, Offer>("LookupOffer", grpcClient.LookupOfferAsync, grpcClient.LookupOffer, effectiveSettings.LookupOfferSettings).WithGoogleRequestParam("entitlement", request => request.Entitlement);
            Modify_ApiCall(ref _callLookupOffer);
            Modify_LookupOfferApiCall(ref _callLookupOffer);
            _callListProducts = clientHelper.BuildApiCall<ListProductsRequest, ListProductsResponse>("ListProducts", grpcClient.ListProductsAsync, grpcClient.ListProducts, effectiveSettings.ListProductsSettings);
            Modify_ApiCall(ref _callListProducts);
            Modify_ListProductsApiCall(ref _callListProducts);
            _callListSkus = clientHelper.BuildApiCall<ListSkusRequest, ListSkusResponse>("ListSkus", grpcClient.ListSkusAsync, grpcClient.ListSkus, effectiveSettings.ListSkusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkus);
            Modify_ListSkusApiCall(ref _callListSkus);
            _callListOffers = clientHelper.BuildApiCall<ListOffersRequest, ListOffersResponse>("ListOffers", grpcClient.ListOffersAsync, grpcClient.ListOffers, effectiveSettings.ListOffersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOffers);
            Modify_ListOffersApiCall(ref _callListOffers);
            _callListPurchasableSkus = clientHelper.BuildApiCall<ListPurchasableSkusRequest, ListPurchasableSkusResponse>("ListPurchasableSkus", grpcClient.ListPurchasableSkusAsync, grpcClient.ListPurchasableSkus, effectiveSettings.ListPurchasableSkusSettings).WithGoogleRequestParam("customer", request => request.Customer);
            Modify_ApiCall(ref _callListPurchasableSkus);
            Modify_ListPurchasableSkusApiCall(ref _callListPurchasableSkus);
            _callListPurchasableOffers = clientHelper.BuildApiCall<ListPurchasableOffersRequest, ListPurchasableOffersResponse>("ListPurchasableOffers", grpcClient.ListPurchasableOffersAsync, grpcClient.ListPurchasableOffers, effectiveSettings.ListPurchasableOffersSettings).WithGoogleRequestParam("customer", request => request.Customer);
            Modify_ApiCall(ref _callListPurchasableOffers);
            Modify_ListPurchasableOffersApiCall(ref _callListPurchasableOffers);
            _callQueryEligibleBillingAccounts = clientHelper.BuildApiCall<QueryEligibleBillingAccountsRequest, QueryEligibleBillingAccountsResponse>("QueryEligibleBillingAccounts", grpcClient.QueryEligibleBillingAccountsAsync, grpcClient.QueryEligibleBillingAccounts, effectiveSettings.QueryEligibleBillingAccountsSettings).WithGoogleRequestParam("customer", request => request.Customer);
            Modify_ApiCall(ref _callQueryEligibleBillingAccounts);
            Modify_QueryEligibleBillingAccountsApiCall(ref _callQueryEligibleBillingAccounts);
            _callRegisterSubscriber = clientHelper.BuildApiCall<RegisterSubscriberRequest, RegisterSubscriberResponse>("RegisterSubscriber", grpcClient.RegisterSubscriberAsync, grpcClient.RegisterSubscriber, effectiveSettings.RegisterSubscriberSettings).WithGoogleRequestParam("account", request => request.Account);
            Modify_ApiCall(ref _callRegisterSubscriber);
            Modify_RegisterSubscriberApiCall(ref _callRegisterSubscriber);
            _callUnregisterSubscriber = clientHelper.BuildApiCall<UnregisterSubscriberRequest, UnregisterSubscriberResponse>("UnregisterSubscriber", grpcClient.UnregisterSubscriberAsync, grpcClient.UnregisterSubscriber, effectiveSettings.UnregisterSubscriberSettings).WithGoogleRequestParam("account", request => request.Account);
            Modify_ApiCall(ref _callUnregisterSubscriber);
            Modify_UnregisterSubscriberApiCall(ref _callUnregisterSubscriber);
            _callListSubscribers = clientHelper.BuildApiCall<ListSubscribersRequest, ListSubscribersResponse>("ListSubscribers", grpcClient.ListSubscribersAsync, grpcClient.ListSubscribers, effectiveSettings.ListSubscribersSettings).WithGoogleRequestParam("account", request => request.Account);
            Modify_ApiCall(ref _callListSubscribers);
            Modify_ListSubscribersApiCall(ref _callListSubscribers);
            _callListEntitlementChanges = clientHelper.BuildApiCall<ListEntitlementChangesRequest, ListEntitlementChangesResponse>("ListEntitlementChanges", grpcClient.ListEntitlementChangesAsync, grpcClient.ListEntitlementChanges, effectiveSettings.ListEntitlementChangesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntitlementChanges);
            Modify_ListEntitlementChangesApiCall(ref _callListEntitlementChanges);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCustomersApiCall(ref gaxgrpc::ApiCall<ListCustomersRequest, ListCustomersResponse> call);

        partial void Modify_GetCustomerApiCall(ref gaxgrpc::ApiCall<GetCustomerRequest, Customer> call);

        partial void Modify_CheckCloudIdentityAccountsExistApiCall(ref gaxgrpc::ApiCall<CheckCloudIdentityAccountsExistRequest, CheckCloudIdentityAccountsExistResponse> call);

        partial void Modify_CreateCustomerApiCall(ref gaxgrpc::ApiCall<CreateCustomerRequest, Customer> call);

        partial void Modify_UpdateCustomerApiCall(ref gaxgrpc::ApiCall<UpdateCustomerRequest, Customer> call);

        partial void Modify_DeleteCustomerApiCall(ref gaxgrpc::ApiCall<DeleteCustomerRequest, wkt::Empty> call);

        partial void Modify_ImportCustomerApiCall(ref gaxgrpc::ApiCall<ImportCustomerRequest, Customer> call);

        partial void Modify_ProvisionCloudIdentityApiCall(ref gaxgrpc::ApiCall<ProvisionCloudIdentityRequest, lro::Operation> call);

        partial void Modify_ListEntitlementsApiCall(ref gaxgrpc::ApiCall<ListEntitlementsRequest, ListEntitlementsResponse> call);

        partial void Modify_ListTransferableSkusApiCall(ref gaxgrpc::ApiCall<ListTransferableSkusRequest, ListTransferableSkusResponse> call);

        partial void Modify_ListTransferableOffersApiCall(ref gaxgrpc::ApiCall<ListTransferableOffersRequest, ListTransferableOffersResponse> call);

        partial void Modify_GetEntitlementApiCall(ref gaxgrpc::ApiCall<GetEntitlementRequest, Entitlement> call);

        partial void Modify_CreateEntitlementApiCall(ref gaxgrpc::ApiCall<CreateEntitlementRequest, lro::Operation> call);

        partial void Modify_ChangeParametersApiCall(ref gaxgrpc::ApiCall<ChangeParametersRequest, lro::Operation> call);

        partial void Modify_ChangeRenewalSettingsApiCall(ref gaxgrpc::ApiCall<ChangeRenewalSettingsRequest, lro::Operation> call);

        partial void Modify_ChangeOfferApiCall(ref gaxgrpc::ApiCall<ChangeOfferRequest, lro::Operation> call);

        partial void Modify_StartPaidServiceApiCall(ref gaxgrpc::ApiCall<StartPaidServiceRequest, lro::Operation> call);

        partial void Modify_SuspendEntitlementApiCall(ref gaxgrpc::ApiCall<SuspendEntitlementRequest, lro::Operation> call);

        partial void Modify_CancelEntitlementApiCall(ref gaxgrpc::ApiCall<CancelEntitlementRequest, lro::Operation> call);

        partial void Modify_ActivateEntitlementApiCall(ref gaxgrpc::ApiCall<ActivateEntitlementRequest, lro::Operation> call);

        partial void Modify_TransferEntitlementsApiCall(ref gaxgrpc::ApiCall<TransferEntitlementsRequest, lro::Operation> call);

        partial void Modify_TransferEntitlementsToGoogleApiCall(ref gaxgrpc::ApiCall<TransferEntitlementsToGoogleRequest, lro::Operation> call);

        partial void Modify_ListChannelPartnerLinksApiCall(ref gaxgrpc::ApiCall<ListChannelPartnerLinksRequest, ListChannelPartnerLinksResponse> call);

        partial void Modify_GetChannelPartnerLinkApiCall(ref gaxgrpc::ApiCall<GetChannelPartnerLinkRequest, ChannelPartnerLink> call);

        partial void Modify_CreateChannelPartnerLinkApiCall(ref gaxgrpc::ApiCall<CreateChannelPartnerLinkRequest, ChannelPartnerLink> call);

        partial void Modify_UpdateChannelPartnerLinkApiCall(ref gaxgrpc::ApiCall<UpdateChannelPartnerLinkRequest, ChannelPartnerLink> call);

        partial void Modify_GetCustomerRepricingConfigApiCall(ref gaxgrpc::ApiCall<GetCustomerRepricingConfigRequest, CustomerRepricingConfig> call);

        partial void Modify_ListCustomerRepricingConfigsApiCall(ref gaxgrpc::ApiCall<ListCustomerRepricingConfigsRequest, ListCustomerRepricingConfigsResponse> call);

        partial void Modify_CreateCustomerRepricingConfigApiCall(ref gaxgrpc::ApiCall<CreateCustomerRepricingConfigRequest, CustomerRepricingConfig> call);

        partial void Modify_UpdateCustomerRepricingConfigApiCall(ref gaxgrpc::ApiCall<UpdateCustomerRepricingConfigRequest, CustomerRepricingConfig> call);

        partial void Modify_DeleteCustomerRepricingConfigApiCall(ref gaxgrpc::ApiCall<DeleteCustomerRepricingConfigRequest, wkt::Empty> call);

        partial void Modify_GetChannelPartnerRepricingConfigApiCall(ref gaxgrpc::ApiCall<GetChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig> call);

        partial void Modify_ListChannelPartnerRepricingConfigsApiCall(ref gaxgrpc::ApiCall<ListChannelPartnerRepricingConfigsRequest, ListChannelPartnerRepricingConfigsResponse> call);

        partial void Modify_CreateChannelPartnerRepricingConfigApiCall(ref gaxgrpc::ApiCall<CreateChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig> call);

        partial void Modify_UpdateChannelPartnerRepricingConfigApiCall(ref gaxgrpc::ApiCall<UpdateChannelPartnerRepricingConfigRequest, ChannelPartnerRepricingConfig> call);

        partial void Modify_DeleteChannelPartnerRepricingConfigApiCall(ref gaxgrpc::ApiCall<DeleteChannelPartnerRepricingConfigRequest, wkt::Empty> call);

        partial void Modify_ListSkuGroupsApiCall(ref gaxgrpc::ApiCall<ListSkuGroupsRequest, ListSkuGroupsResponse> call);

        partial void Modify_ListSkuGroupBillableSkusApiCall(ref gaxgrpc::ApiCall<ListSkuGroupBillableSkusRequest, ListSkuGroupBillableSkusResponse> call);

        partial void Modify_LookupOfferApiCall(ref gaxgrpc::ApiCall<LookupOfferRequest, Offer> call);

        partial void Modify_ListProductsApiCall(ref gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> call);

        partial void Modify_ListSkusApiCall(ref gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> call);

        partial void Modify_ListOffersApiCall(ref gaxgrpc::ApiCall<ListOffersRequest, ListOffersResponse> call);

        partial void Modify_ListPurchasableSkusApiCall(ref gaxgrpc::ApiCall<ListPurchasableSkusRequest, ListPurchasableSkusResponse> call);

        partial void Modify_ListPurchasableOffersApiCall(ref gaxgrpc::ApiCall<ListPurchasableOffersRequest, ListPurchasableOffersResponse> call);

        partial void Modify_QueryEligibleBillingAccountsApiCall(ref gaxgrpc::ApiCall<QueryEligibleBillingAccountsRequest, QueryEligibleBillingAccountsResponse> call);

        partial void Modify_RegisterSubscriberApiCall(ref gaxgrpc::ApiCall<RegisterSubscriberRequest, RegisterSubscriberResponse> call);

        partial void Modify_UnregisterSubscriberApiCall(ref gaxgrpc::ApiCall<UnregisterSubscriberRequest, UnregisterSubscriberResponse> call);

        partial void Modify_ListSubscribersApiCall(ref gaxgrpc::ApiCall<ListSubscribersRequest, ListSubscribersResponse> call);

        partial void Modify_ListEntitlementChangesApiCall(ref gaxgrpc::ApiCall<ListEntitlementChangesRequest, ListEntitlementChangesResponse> call);

        partial void OnConstruction(CloudChannelService.CloudChannelServiceClient grpcClient, CloudChannelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudChannelService client</summary>
        public override CloudChannelService.CloudChannelServiceClient GrpcClient { get; }

        partial void Modify_ListCustomersRequest(ref ListCustomersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomerRequest(ref GetCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckCloudIdentityAccountsExistRequest(ref CheckCloudIdentityAccountsExistRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomerRequest(ref CreateCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomerRequest(ref UpdateCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomerRequest(ref DeleteCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportCustomerRequest(ref ImportCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ProvisionCloudIdentityRequest(ref ProvisionCloudIdentityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntitlementsRequest(ref ListEntitlementsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTransferableSkusRequest(ref ListTransferableSkusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTransferableOffersRequest(ref ListTransferableOffersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntitlementRequest(ref GetEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntitlementRequest(ref CreateEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ChangeParametersRequest(ref ChangeParametersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ChangeRenewalSettingsRequest(ref ChangeRenewalSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ChangeOfferRequest(ref ChangeOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_StartPaidServiceRequest(ref StartPaidServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuspendEntitlementRequest(ref SuspendEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelEntitlementRequest(ref CancelEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ActivateEntitlementRequest(ref ActivateEntitlementRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TransferEntitlementsRequest(ref TransferEntitlementsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_TransferEntitlementsToGoogleRequest(ref TransferEntitlementsToGoogleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListChannelPartnerLinksRequest(ref ListChannelPartnerLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetChannelPartnerLinkRequest(ref GetChannelPartnerLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateChannelPartnerLinkRequest(ref CreateChannelPartnerLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateChannelPartnerLinkRequest(ref UpdateChannelPartnerLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomerRepricingConfigRequest(ref GetCustomerRepricingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCustomerRepricingConfigsRequest(ref ListCustomerRepricingConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomerRepricingConfigRequest(ref CreateCustomerRepricingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomerRepricingConfigRequest(ref UpdateCustomerRepricingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomerRepricingConfigRequest(ref DeleteCustomerRepricingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetChannelPartnerRepricingConfigRequest(ref GetChannelPartnerRepricingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListChannelPartnerRepricingConfigsRequest(ref ListChannelPartnerRepricingConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateChannelPartnerRepricingConfigRequest(ref CreateChannelPartnerRepricingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateChannelPartnerRepricingConfigRequest(ref UpdateChannelPartnerRepricingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteChannelPartnerRepricingConfigRequest(ref DeleteChannelPartnerRepricingConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkuGroupsRequest(ref ListSkuGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkuGroupBillableSkusRequest(ref ListSkuGroupBillableSkusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupOfferRequest(ref LookupOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductsRequest(ref ListProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkusRequest(ref ListSkusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOffersRequest(ref ListOffersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPurchasableSkusRequest(ref ListPurchasableSkusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPurchasableOffersRequest(ref ListPurchasableOffersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_QueryEligibleBillingAccountsRequest(ref QueryEligibleBillingAccountsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RegisterSubscriberRequest(ref RegisterSubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnregisterSubscriberRequest(ref UnregisterSubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubscribersRequest(ref ListSubscribersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntitlementChangesRequest(ref ListEntitlementChangesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// List [Customer][google.cloud.channel.v1.Customer]s.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// List of [Customer][google.cloud.channel.v1.Customer]s, or an empty list if
        /// there are no customers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Customer"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomersResponse, Customer> ListCustomers(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomersRequest, ListCustomersResponse, Customer>(_callListCustomers, request, callSettings);
        }

        /// <summary>
        /// List [Customer][google.cloud.channel.v1.Customer]s.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// List of [Customer][google.cloud.channel.v1.Customer]s, or an empty list if
        /// there are no customers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Customer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomersResponse, Customer> ListCustomersAsync(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomersRequest, ListCustomersResponse, Customer>(_callListCustomers, request, callSettings);
        }

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Customer GetCustomer(GetCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerRequest(ref request, ref callSettings);
            return _callGetCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Customer> GetCustomerAsync(GetCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerRequest(ref request, ref callSettings);
            return _callGetCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Confirms the existence of Cloud Identity accounts based on the domain and
        /// if the Cloud Identity accounts are owned by the reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INVALID_VALUE: Invalid domain value in the request.
        /// 
        /// Return value:
        /// A list of
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources for the domain (may be empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources match the domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckCloudIdentityAccountsExistResponse CheckCloudIdentityAccountsExist(CheckCloudIdentityAccountsExistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckCloudIdentityAccountsExistRequest(ref request, ref callSettings);
            return _callCheckCloudIdentityAccountsExist.Sync(request, callSettings);
        }

        /// <summary>
        /// Confirms the existence of Cloud Identity accounts based on the domain and
        /// if the Cloud Identity accounts are owned by the reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INVALID_VALUE: Invalid domain value in the request.
        /// 
        /// Return value:
        /// A list of
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources for the domain (may be empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no
        /// [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount]
        /// resources match the domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckCloudIdentityAccountsExistResponse> CheckCloudIdentityAccountsExistAsync(CheckCloudIdentityAccountsExistRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckCloudIdentityAccountsExistRequest(ref request, ref callSettings);
            return _callCheckCloudIdentityAccountsExist.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under
        /// the reseller or distributor account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to create a customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Domain field value doesn't match the primary email domain.
        /// 
        /// Return value:
        /// The newly created [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Customer CreateCustomer(CreateCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomerRequest(ref request, ref callSettings);
            return _callCreateCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under
        /// the reseller or distributor account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to create a customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Domain field value doesn't match the primary email domain.
        /// 
        /// Return value:
        /// The newly created [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Customer> CreateCustomerAsync(CreateCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomerRequest(ref request, ref callSettings);
            return _callCreateCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource
        /// for the reseller or distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// 
        /// Return value:
        /// The updated [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Customer UpdateCustomer(UpdateCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomerRequest(ref request, ref callSettings);
            return _callUpdateCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource
        /// for the reseller or distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// 
        /// Return value:
        /// The updated [Customer][google.cloud.channel.v1.Customer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Customer> UpdateCustomerAsync(UpdateCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomerRequest(ref request, ref callSettings);
            return _callUpdateCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCustomer(DeleteCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomerRequest(ref request, ref callSettings);
            _callDeleteCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the given [Customer][google.cloud.channel.v1.Customer] permanently.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The customer has existing entitlements.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found
        /// for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCustomerAsync(DeleteCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomerRequest(ref request, ref callSettings);
            return _callDeleteCustomer.Async(request, callSettings);
        }

        /// <summary>
        /// Imports a [Customer][google.cloud.channel.v1.Customer] from the Cloud
        /// Identity associated with the provided Cloud Identity ID or domain before a
        /// TransferEntitlements call. If a linked Customer already exists and
        /// overwrite_if_exists is true, it will update that Customer's data.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to import the customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * NOT_FOUND: Cloud Identity doesn't exist or was deleted.
        /// * INVALID_ARGUMENT: Required parameters are missing, or the auth_token is
        /// expired or invalid.
        /// * ALREADY_EXISTS: A customer already exists and has conflicting critical
        /// fields. Requires an overwrite.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Customer ImportCustomer(ImportCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportCustomerRequest(ref request, ref callSettings);
            return _callImportCustomer.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports a [Customer][google.cloud.channel.v1.Customer] from the Cloud
        /// Identity associated with the provided Cloud Identity ID or domain before a
        /// TransferEntitlements call. If a linked Customer already exists and
        /// overwrite_if_exists is true, it will update that Customer's data.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The reseller account making the request is different from the
        /// reseller account in the API request.
        /// * You are not authorized to import the customer. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * NOT_FOUND: Cloud Identity doesn't exist or was deleted.
        /// * INVALID_ARGUMENT: Required parameters are missing, or the auth_token is
        /// expired or invalid.
        /// * ALREADY_EXISTS: A customer already exists and has conflicting critical
        /// fields. Requires an overwrite.
        /// 
        /// Return value:
        /// The [Customer][google.cloud.channel.v1.Customer].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Customer> ImportCustomerAsync(ImportCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportCustomerRequest(ref request, ref callSettings);
            return _callImportCustomer.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ProvisionCloudIdentity</c>.</summary>
        public override lro::OperationsClient ProvisionCloudIdentityOperationsClient { get; }

        /// <summary>
        /// Creates a Cloud Identity for the given customer using the customer's
        /// information, or the information provided here.
        /// 
        /// Possible error codes:
        /// 
        /// *  PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * You are not authorized to provision cloud identity id. See
        /// https://support.google.com/channelservices/answer/9759265
        /// *  INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// *  NOT_FOUND: The customer was not found.
        /// *  ALREADY_EXISTS: The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Customer, OperationMetadata> ProvisionCloudIdentity(ProvisionCloudIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionCloudIdentityRequest(ref request, ref callSettings);
            return new lro::Operation<Customer, OperationMetadata>(_callProvisionCloudIdentity.Sync(request, callSettings), ProvisionCloudIdentityOperationsClient);
        }

        /// <summary>
        /// Creates a Cloud Identity for the given customer using the customer's
        /// information, or the information provided here.
        /// 
        /// Possible error codes:
        /// 
        /// *  PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * You are not authorized to provision cloud identity id. See
        /// https://support.google.com/channelservices/answer/9759265
        /// *  INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// *  NOT_FOUND: The customer was not found.
        /// *  ALREADY_EXISTS: The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata contains an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Customer, OperationMetadata>> ProvisionCloudIdentityAsync(ProvisionCloudIdentityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ProvisionCloudIdentityRequest(ref request, ref callSettings);
            return new lro::Operation<Customer, OperationMetadata>(await _callProvisionCloudIdentity.Async(request, callSettings).ConfigureAwait(false), ProvisionCloudIdentityOperationsClient);
        }

        /// <summary>
        /// Lists [Entitlement][google.cloud.channel.v1.Entitlement]s belonging to a
        /// customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's
        /// [Entitlement][google.cloud.channel.v1.Entitlement]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitlementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntitlementsRequest, ListEntitlementsResponse, Entitlement>(_callListEntitlements, request, callSettings);
        }

        /// <summary>
        /// Lists [Entitlement][google.cloud.channel.v1.Entitlement]s belonging to a
        /// customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's
        /// [Entitlement][google.cloud.channel.v1.Entitlement]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitlementsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntitlementsRequest, ListEntitlementsResponse, Entitlement>(_callListEntitlements, request, callSettings);
        }

        /// <summary>
        /// List [TransferableSku][google.cloud.channel.v1.TransferableSku]s of a
        /// customer based on the Cloud Identity ID or Customer Name in the request.
        /// 
        /// Use this method to list the entitlements information of an
        /// unowned customer. You should provide the customer's
        /// Cloud Identity ID or Customer Name.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller and has no auth token.
        /// * The supplied auth token is invalid.
        /// * The reseller account making the request is different
        /// from the reseller account in the query.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's
        /// [TransferableSku][google.cloud.channel.v1.TransferableSku].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferableSku"/> resources.</returns>
        public override gax::PagedEnumerable<ListTransferableSkusResponse, TransferableSku> ListTransferableSkus(ListTransferableSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferableSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTransferableSkusRequest, ListTransferableSkusResponse, TransferableSku>(_callListTransferableSkus, request, callSettings);
        }

        /// <summary>
        /// List [TransferableSku][google.cloud.channel.v1.TransferableSku]s of a
        /// customer based on the Cloud Identity ID or Customer Name in the request.
        /// 
        /// Use this method to list the entitlements information of an
        /// unowned customer. You should provide the customer's
        /// Cloud Identity ID or Customer Name.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller and has no auth token.
        /// * The supplied auth token is invalid.
        /// * The reseller account making the request is different
        /// from the reseller account in the query.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's
        /// [TransferableSku][google.cloud.channel.v1.TransferableSku].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferableSku"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTransferableSkusResponse, TransferableSku> ListTransferableSkusAsync(ListTransferableSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferableSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTransferableSkusRequest, ListTransferableSkusResponse, TransferableSku>(_callListTransferableSkus, request, callSettings);
        }

        /// <summary>
        /// List [TransferableOffer][google.cloud.channel.v1.TransferableOffer]s of a
        /// customer based on Cloud Identity ID or Customer Name in the request.
        /// 
        /// Use this method when a reseller gets the entitlement information of an
        /// unowned customer. The reseller should provide the customer's
        /// Cloud Identity ID or Customer Name.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller and has no auth token.
        /// * The customer provided incorrect reseller information when generating
        /// auth token.
        /// * The reseller account making the request is different
        /// from the reseller account in the query.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// List of [TransferableOffer][google.cloud.channel.v1.TransferableOffer] for
        /// the given customer and SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferableOffer"/> resources.</returns>
        public override gax::PagedEnumerable<ListTransferableOffersResponse, TransferableOffer> ListTransferableOffers(ListTransferableOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferableOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTransferableOffersRequest, ListTransferableOffersResponse, TransferableOffer>(_callListTransferableOffers, request, callSettings);
        }

        /// <summary>
        /// List [TransferableOffer][google.cloud.channel.v1.TransferableOffer]s of a
        /// customer based on Cloud Identity ID or Customer Name in the request.
        /// 
        /// Use this method when a reseller gets the entitlement information of an
        /// unowned customer. The reseller should provide the customer's
        /// Cloud Identity ID or Customer Name.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller and has no auth token.
        /// * The customer provided incorrect reseller information when generating
        /// auth token.
        /// * The reseller account making the request is different
        /// from the reseller account in the query.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// List of [TransferableOffer][google.cloud.channel.v1.TransferableOffer] for
        /// the given customer and SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferableOffer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTransferableOffersResponse, TransferableOffer> ListTransferableOffersAsync(ListTransferableOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTransferableOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTransferableOffersRequest, ListTransferableOffersResponse, TransferableOffer>(_callListTransferableOffers, request, callSettings);
        }

        /// <summary>
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer entitlement was not found.
        /// 
        /// Return value:
        /// The requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entitlement GetEntitlement(GetEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntitlementRequest(ref request, ref callSettings);
            return _callGetEntitlement.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement]
        /// resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer entitlement was not found.
        /// 
        /// Return value:
        /// The requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entitlement> GetEntitlementAsync(GetEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntitlementRequest(ref request, ref callSettings);
            return _callGetEntitlement.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEntitlement</c>.</summary>
        public override lro::OperationsClient CreateEntitlementOperationsClient { get; }

        /// <summary>
        /// Creates an entitlement for a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * There is already a customer entitlement for a SKU from the same
        /// product family.
        /// * INVALID_VALUE: Make sure the OfferId is valid. If it is, contact
        /// Google Channel support for further troubleshooting.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS:
        /// * The SKU was already purchased for the customer.
        /// * The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The domain required for purchasing a SKU has not been verified.
        /// * A pre-requisite SKU required to purchase an Add-On SKU is missing.
        /// For example, Google Workspace Business Starter is required to purchase
        /// Vault or Drive.
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> CreateEntitlement(CreateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callCreateEntitlement.Sync(request, callSettings), CreateEntitlementOperationsClient);
        }

        /// <summary>
        /// Creates an entitlement for a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * There is already a customer entitlement for a SKU from the same
        /// product family.
        /// * INVALID_VALUE: Make sure the OfferId is valid. If it is, contact
        /// Google Channel support for further troubleshooting.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS:
        /// * The SKU was already purchased for the customer.
        /// * The customer's primary email already exists. Retry
        /// after changing the customer's primary contact email.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The domain required for purchasing a SKU has not been verified.
        /// * A pre-requisite SKU required to purchase an Add-On SKU is missing.
        /// For example, Google Workspace Business Starter is required to purchase
        /// Vault or Drive.
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> CreateEntitlementAsync(CreateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callCreateEntitlement.Async(request, callSettings).ConfigureAwait(false), CreateEntitlementOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ChangeParameters</c>.</summary>
        public override lro::OperationsClient ChangeParametersOperationsClient { get; }

        /// <summary>
        /// Change parameters of the entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// For example, the number of seats being changed is greater than the allowed
        /// number of max seats, or decreasing seats for a commitment based plan.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> ChangeParameters(ChangeParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChangeParametersRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callChangeParameters.Sync(request, callSettings), ChangeParametersOperationsClient);
        }

        /// <summary>
        /// Change parameters of the entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// For example, the number of seats being changed is greater than the allowed
        /// number of max seats, or decreasing seats for a commitment based plan.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeParametersAsync(ChangeParametersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChangeParametersRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callChangeParameters.Async(request, callSettings).ConfigureAwait(false), ChangeParametersOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ChangeRenewalSettings</c>.</summary>
        public override lro::OperationsClient ChangeRenewalSettingsOperationsClient { get; }

        /// <summary>
        /// Updates the renewal settings for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_COMMITMENT_PLAN: Renewal Settings are only applicable for a
        /// commitment plan. Can't enable or disable renewals for non-commitment plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> ChangeRenewalSettings(ChangeRenewalSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChangeRenewalSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callChangeRenewalSettings.Sync(request, callSettings), ChangeRenewalSettingsOperationsClient);
        }

        /// <summary>
        /// Updates the renewal settings for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_COMMITMENT_PLAN: Renewal Settings are only applicable for a
        /// commitment plan. Can't enable or disable renewals for non-commitment plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeRenewalSettingsAsync(ChangeRenewalSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChangeRenewalSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callChangeRenewalSettings.Async(request, callSettings).ConfigureAwait(false), ChangeRenewalSettingsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ChangeOffer</c>.</summary>
        public override lro::OperationsClient ChangeOfferOperationsClient { get; }

        /// <summary>
        /// Updates the Offer for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Offer or Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> ChangeOffer(ChangeOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChangeOfferRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callChangeOffer.Sync(request, callSettings), ChangeOfferOperationsClient);
        }

        /// <summary>
        /// Updates the Offer for an existing customer entitlement.
        /// 
        /// An entitlement update is a long-running operation and it updates the
        /// entitlement as a result of fulfillment.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Offer or Entitlement resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> ChangeOfferAsync(ChangeOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ChangeOfferRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callChangeOffer.Async(request, callSettings).ConfigureAwait(false), ChangeOfferOperationsClient);
        }

        /// <summary>The long-running operations client for <c>StartPaidService</c>.</summary>
        public override lro::OperationsClient StartPaidServiceOperationsClient { get; }

        /// <summary>
        /// Starts paid service for a trial entitlement.
        /// 
        /// Starts paid service for a trial entitlement immediately. This method is
        /// only applicable if a plan is set up for a trial entitlement but has some
        /// trial days remaining.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * FAILED_PRECONDITION/NOT_IN_TRIAL: This method only works for
        /// entitlement on trial plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> StartPaidService(StartPaidServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartPaidServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callStartPaidService.Sync(request, callSettings), StartPaidServiceOperationsClient);
        }

        /// <summary>
        /// Starts paid service for a trial entitlement.
        /// 
        /// Starts paid service for a trial entitlement immediately. This method is
        /// only applicable if a plan is set up for a trial entitlement but has some
        /// trial days remaining.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * FAILED_PRECONDITION/NOT_IN_TRIAL: This method only works for
        /// entitlement on trial plans.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> StartPaidServiceAsync(StartPaidServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartPaidServiceRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callStartPaidService.Async(request, callSettings).ConfigureAwait(false), StartPaidServiceOperationsClient);
        }

        /// <summary>The long-running operations client for <c>SuspendEntitlement</c>.</summary>
        public override lro::OperationsClient SuspendEntitlementOperationsClient { get; }

        /// <summary>
        /// Suspends a previously fulfilled entitlement.
        /// 
        /// An entitlement suspension is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_ACTIVE: Entitlement is not active.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> SuspendEntitlement(SuspendEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuspendEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callSuspendEntitlement.Sync(request, callSettings), SuspendEntitlementOperationsClient);
        }

        /// <summary>
        /// Suspends a previously fulfilled entitlement.
        /// 
        /// An entitlement suspension is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * NOT_ACTIVE: Entitlement is not active.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> SuspendEntitlementAsync(SuspendEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuspendEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callSuspendEntitlement.Async(request, callSettings).ConfigureAwait(false), SuspendEntitlementOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CancelEntitlement</c>.</summary>
        public override lro::OperationsClient CancelEntitlementOperationsClient { get; }

        /// <summary>
        /// Cancels a previously fulfilled entitlement.
        /// 
        /// An entitlement cancellation is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * FAILED_PRECONDITION: There are Google Cloud projects linked to the
        /// Google Cloud entitlement's Cloud Billing subaccount.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * DELETION_TYPE_NOT_ALLOWED: Cancel is only allowed for Google Workspace
        /// add-ons, or entitlements for Google Cloud's development platform.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> CancelEntitlement(CancelEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callCancelEntitlement.Sync(request, callSettings), CancelEntitlementOperationsClient);
        }

        /// <summary>
        /// Cancels a previously fulfilled entitlement.
        /// 
        /// An entitlement cancellation is a long-running operation.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * FAILED_PRECONDITION: There are Google Cloud projects linked to the
        /// Google Cloud entitlement's Cloud Billing subaccount.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * DELETION_TYPE_NOT_ALLOWED: Cancel is only allowed for Google Workspace
        /// add-ons, or entitlements for Google Cloud's development platform.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> CancelEntitlementAsync(CancelEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callCancelEntitlement.Async(request, callSettings).ConfigureAwait(false), CancelEntitlementOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ActivateEntitlement</c>.</summary>
        public override lro::OperationsClient ActivateEntitlementOperationsClient { get; }

        /// <summary>
        /// Activates a previously suspended entitlement. Entitlements suspended for
        /// pending ToS acceptance can't be activated using this method.
        /// 
        /// An entitlement activation is a long-running operation and it updates
        /// the state of the customer entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * SUSPENSION_NOT_RESELLER_INITIATED: Can only activate reseller-initiated
        /// suspensions and entitlements that have accepted the TOS.
        /// * NOT_SUSPENDED: Can only activate suspended entitlements not in an ACTIVE
        /// state.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Entitlement, OperationMetadata> ActivateEntitlement(ActivateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ActivateEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(_callActivateEntitlement.Sync(request, callSettings), ActivateEntitlementOperationsClient);
        }

        /// <summary>
        /// Activates a previously suspended entitlement. Entitlements suspended for
        /// pending ToS acceptance can't be activated using this method.
        /// 
        /// An entitlement activation is a long-running operation and it updates
        /// the state of the customer entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement resource not found.
        /// * SUSPENSION_NOT_RESELLER_INITIATED: Can only activate reseller-initiated
        /// suspensions and entitlements that have accepted the TOS.
        /// * NOT_SUSPENDED: Can only activate suspended entitlements not in an ACTIVE
        /// state.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Entitlement, OperationMetadata>> ActivateEntitlementAsync(ActivateEntitlementRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ActivateEntitlementRequest(ref request, ref callSettings);
            return new lro::Operation<Entitlement, OperationMetadata>(await _callActivateEntitlement.Async(request, callSettings).ConfigureAwait(false), ActivateEntitlementOperationsClient);
        }

        /// <summary>The long-running operations client for <c>TransferEntitlements</c>.</summary>
        public override lro::OperationsClient TransferEntitlementsOperationsClient { get; }

        /// <summary>
        /// Transfers customer entitlements to new reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * Specify all transferring entitlements.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<TransferEntitlementsResponse, OperationMetadata> TransferEntitlements(TransferEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TransferEntitlementsRequest(ref request, ref callSettings);
            return new lro::Operation<TransferEntitlementsResponse, OperationMetadata>(_callTransferEntitlements.Sync(request, callSettings), TransferEntitlementsOperationsClient);
        }

        /// <summary>
        /// Transfers customer entitlements to new reseller.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller.
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * Specify all transferring entitlements.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<TransferEntitlementsResponse, OperationMetadata>> TransferEntitlementsAsync(TransferEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TransferEntitlementsRequest(ref request, ref callSettings);
            return new lro::Operation<TransferEntitlementsResponse, OperationMetadata>(await _callTransferEntitlements.Async(request, callSettings).ConfigureAwait(false), TransferEntitlementsOperationsClient);
        }

        /// <summary>The long-running operations client for <c>TransferEntitlementsToGoogle</c>.</summary>
        public override lro::OperationsClient TransferEntitlementsToGoogleOperationsClient { get; }

        /// <summary>
        /// Transfers customer entitlements from their current reseller to Google.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> TransferEntitlementsToGoogle(TransferEntitlementsToGoogleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TransferEntitlementsToGoogleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callTransferEntitlementsToGoogle.Sync(request, callSettings), TransferEntitlementsToGoogleOperationsClient);
        }

        /// <summary>
        /// Transfers customer entitlements from their current reseller to Google.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The customer or offer resource was not found.
        /// * ALREADY_EXISTS: The SKU was already transferred for the customer.
        /// * CONDITION_NOT_MET or FAILED_PRECONDITION:
        /// * The SKU requires domain verification to transfer, but the domain is
        /// not verified.
        /// * An Add-On SKU (example, Vault or Drive) is missing the
        /// pre-requisite SKU (example, G Suite Basic).
        /// * (Developer accounts only) Reseller and resold domain must meet the
        /// following naming requirements:
        /// * Domain names must start with goog-test.
        /// * Domain names must include the reseller domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The ID of a long-running operation.
        /// 
        /// To get the results of the operation, call the GetOperation method of
        /// CloudChannelOperationsService. The response will contain
        /// google.protobuf.Empty on success. The Operation metadata will contain an
        /// instance of [OperationMetadata][google.cloud.channel.v1.OperationMetadata].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> TransferEntitlementsToGoogleAsync(TransferEntitlementsToGoogleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_TransferEntitlementsToGoogleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callTransferEntitlementsToGoogle.Async(request, callSettings).ConfigureAwait(false), TransferEntitlementsToGoogleOperationsClient);
        }

        /// <summary>
        /// List [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s
        /// belonging to a distributor. You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// The list of the distributor account's
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChannelPartnerLink"/> resources.</returns>
        public override gax::PagedEnumerable<ListChannelPartnerLinksResponse, ChannelPartnerLink> ListChannelPartnerLinks(ListChannelPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelPartnerLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChannelPartnerLinksRequest, ListChannelPartnerLinksResponse, ChannelPartnerLink>(_callListChannelPartnerLinks, request, callSettings);
        }

        /// <summary>
        /// List [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s
        /// belonging to a distributor. You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// The list of the distributor account's
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChannelPartnerLink"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListChannelPartnerLinksResponse, ChannelPartnerLink> ListChannelPartnerLinksAsync(ListChannelPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelPartnerLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChannelPartnerLinksRequest, ListChannelPartnerLinksResponse, ChannelPartnerLink>(_callListChannelPartnerLinks, request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: ChannelPartnerLink resource not found because of an
        /// invalid channel partner link name.
        /// 
        /// Return value:
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChannelPartnerLink GetChannelPartnerLink(GetChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelPartnerLinkRequest(ref request, ref callSettings);
            return _callGetChannelPartnerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: ChannelPartnerLink resource not found because of an
        /// invalid channel partner link name.
        /// 
        /// Return value:
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChannelPartnerLink> GetChannelPartnerLinkAsync(GetChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelPartnerLinkRequest(ref request, ref callSettings);
            return _callGetChannelPartnerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Initiates a channel partner link between a distributor and a reseller, or
        /// between resellers in an n-tier reseller channel.
        /// Invited partners need to follow the invite_link_uri provided in the
        /// response to accept. After accepting the invitation, a link is set up
        /// between the two parties.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * ALREADY_EXISTS: The ChannelPartnerLink sent in the request already
        /// exists.
        /// * NOT_FOUND: No Cloud Identity customer exists for provided domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChannelPartnerLink CreateChannelPartnerLink(CreateChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelPartnerLinkRequest(ref request, ref callSettings);
            return _callCreateChannelPartnerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Initiates a channel partner link between a distributor and a reseller, or
        /// between resellers in an n-tier reseller channel.
        /// Invited partners need to follow the invite_link_uri provided in the
        /// response to accept. After accepting the invitation, a link is set up
        /// between the two parties.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * ALREADY_EXISTS: The ChannelPartnerLink sent in the request already
        /// exists.
        /// * NOT_FOUND: No Cloud Identity customer exists for provided domain.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]
        /// resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChannelPartnerLink> CreateChannelPartnerLinkAsync(CreateChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelPartnerLinkRequest(ref request, ref callSettings);
            return _callCreateChannelPartnerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a channel partner link. Distributors call this method to change a
        /// link's status. For example, to suspend a partner link.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Link state cannot change from invited to active or suspended.
        /// * Cannot send reseller_cloud_identity_id, invite_url, or name in update
        /// mask.
        /// * NOT_FOUND: ChannelPartnerLink resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The updated
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChannelPartnerLink UpdateChannelPartnerLink(UpdateChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChannelPartnerLinkRequest(ref request, ref callSettings);
            return _callUpdateChannelPartnerLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a channel partner link. Distributors call this method to change a
        /// link's status. For example, to suspend a partner link.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT:
        /// * Required request parameters are missing or invalid.
        /// * Link state cannot change from invited to active or suspended.
        /// * Cannot send reseller_cloud_identity_id, invite_url, or name in update
        /// mask.
        /// * NOT_FOUND: ChannelPartnerLink resource not found.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The updated
        /// [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChannelPartnerLink> UpdateChannelPartnerLinkAsync(UpdateChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChannelPartnerLinkRequest(ref request, ref callSettings);
            return _callUpdateChannelPartnerLink.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomerRepricingConfig GetCustomerRepricingConfig(GetCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerRepricingConfigRequest(ref request, ref callSettings);
            return _callGetCustomerRepricingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomerRepricingConfig> GetCustomerRepricingConfigAsync(GetCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerRepricingConfigRequest(ref request, ref callSettings);
            return _callGetCustomerRepricingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Customer ID
        /// * [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement]
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [CustomerRepricingConfig.update_time][google.cloud.channel.v1.CustomerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CustomerRepricingConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListCustomerRepricingConfigsResponse, CustomerRepricingConfig> ListCustomerRepricingConfigs(ListCustomerRepricingConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomerRepricingConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCustomerRepricingConfigsRequest, ListCustomerRepricingConfigsResponse, CustomerRepricingConfig>(_callListCustomerRepricingConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a Customer.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Customer ID
        /// * [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement]
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [CustomerRepricingConfig.update_time][google.cloud.channel.v1.CustomerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CustomerRepricingConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCustomerRepricingConfigsResponse, CustomerRepricingConfig> ListCustomerRepricingConfigsAsync(ListCustomerRepricingConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCustomerRepricingConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCustomerRepricingConfigsRequest, ListCustomerRepricingConfigsResponse, CustomerRepricingConfig>(_callListCustomerRepricingConfigs, request, callSettings);
        }

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomerRepricingConfig CreateCustomerRepricingConfig(CreateCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomerRepricingConfigRequest(ref request, ref callSettings);
            return _callCreateCustomerRepricingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. You can only create configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [CustomerRepricingConfig.repricing_config][google.cloud.channel.v1.CustomerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement].
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomerRepricingConfig> CreateCustomerRepricingConfigAsync(CreateCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCustomerRepricingConfigRequest(ref request, ref callSettings);
            return _callCreateCustomerRepricingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. This method overwrites the existing
        /// CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateCustomerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateCustomerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CustomerRepricingConfig UpdateCustomerRepricingConfig(UpdateCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomerRepricingConfigRequest(ref request, ref callSettings);
            return _callUpdateCustomerRepricingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a CustomerRepricingConfig. Call this method to set modifications
        /// for a specific customer's bill. This method overwrites the existing
        /// CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateCustomerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateCustomerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CustomerRepricingConfig> UpdateCustomerRepricingConfigAsync(UpdateCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCustomerRepricingConfigRequest(ref request, ref callSettings);
            return _callUpdateCustomerRepricingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteCustomerRepricingConfig(DeleteCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomerRepricingConfigRequest(ref request, ref callSettings);
            _callDeleteCustomerRepricingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the given
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [CustomerRepricingConfig][google.cloud.channel.v1.CustomerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCustomerRepricingConfigAsync(DeleteCustomerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomerRepricingConfigRequest(ref request, ref callSettings);
            return _callDeleteCustomerRepricingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChannelPartnerRepricingConfig GetChannelPartnerRepricingConfig(GetChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelPartnerRepricingConfigRequest(ref request, ref callSettings);
            return _callGetChannelPartnerRepricingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets information about how a Distributor modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// was not found.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChannelPartnerRepricingConfig> GetChannelPartnerRepricingConfigAsync(GetChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetChannelPartnerRepricingConfigRequest(ref request, ref callSettings);
            return _callGetChannelPartnerRepricingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Channel Partner ID
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [ChannelPartnerRepricingConfig.update_time][google.cloud.channel.v1.ChannelPartnerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChannelPartnerRepricingConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig> ListChannelPartnerRepricingConfigs(ListChannelPartnerRepricingConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelPartnerRepricingConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListChannelPartnerRepricingConfigsRequest, ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig>(_callListChannelPartnerRepricingConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists information about how a Reseller modifies their bill before sending
        /// it to a ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * Channel Partner ID
        /// * [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// * [ChannelPartnerRepricingConfig.update_time][google.cloud.channel.v1.ChannelPartnerRepricingConfig.update_time]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="ChannelPartnerRepricingConfig"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig> ListChannelPartnerRepricingConfigsAsync(ListChannelPartnerRepricingConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListChannelPartnerRepricingConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListChannelPartnerRepricingConfigsRequest, ListChannelPartnerRepricingConfigsResponse, ChannelPartnerRepricingConfig>(_callListChannelPartnerRepricingConfigs, request, callSettings);
        }

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChannelPartnerRepricingConfig CreateChannelPartnerRepricingConfig(CreateChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelPartnerRepricingConfigRequest(ref request, ref callSettings);
            return _callCreateChannelPartnerRepricingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. You can only create
        /// configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. If needed, you can create a config for the current
        /// month, with some restrictions.
        /// 
        /// When creating a config for a future month, make sure there are no existing
        /// configs for that
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// The following restrictions are for creating configs in the current month.
        /// 
        /// * This functionality is reserved for recovering from an erroneous config,
        /// and should not be used for regular business cases.
        /// * The new config will not modify exports used with other configs.
        /// Changes to the config may be immediate, but may take up to 24 hours.
        /// * There is a limit of ten configs for any ChannelPartner or
        /// [RepricingConfig.EntitlementGranularity.entitlement][google.cloud.channel.v1.RepricingConfig.EntitlementGranularity.entitlement],
        /// for any
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// * The contained
        /// [ChannelPartnerRepricingConfig.repricing_config][google.cloud.channel.v1.ChannelPartnerRepricingConfig.repricing_config]
        /// value must be different from the value used in the current config for a
        /// ChannelPartner.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChannelPartnerRepricingConfig> CreateChannelPartnerRepricingConfigAsync(CreateChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateChannelPartnerRepricingConfigRequest(ref request, ref callSettings);
            return _callCreateChannelPartnerRepricingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. This method overwrites
        /// the existing CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateChannelPartnerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateChannelPartnerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ChannelPartnerRepricingConfig UpdateChannelPartnerRepricingConfig(UpdateChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChannelPartnerRepricingConfigRequest(ref request, ref callSettings);
            return _callUpdateChannelPartnerRepricingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a ChannelPartnerRepricingConfig. Call this method to set
        /// modifications for a specific ChannelPartner's bill. This method overwrites
        /// the existing CustomerRepricingConfig.
        /// 
        /// You can only update configs if the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is a future month. To make changes to configs for the current month, use
        /// [CreateChannelPartnerRepricingConfig][google.cloud.channel.v1.CloudChannelService.CreateChannelPartnerRepricingConfig],
        /// taking note of its restrictions. You cannot update the
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month].
        /// 
        /// When updating a config in the future:
        /// 
        /// * This config must already exist.
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different.
        /// * INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request. Also displays if the updated config is for the current month or
        /// past months.
        /// * NOT_FOUND: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// specified does not exist or is not associated with the given account.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the updated
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// resource, otherwise returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ChannelPartnerRepricingConfig> UpdateChannelPartnerRepricingConfigAsync(UpdateChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateChannelPartnerRepricingConfigRequest(ref request, ref callSettings);
            return _callUpdateChannelPartnerRepricingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteChannelPartnerRepricingConfig(DeleteChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteChannelPartnerRepricingConfigRequest(ref request, ref callSettings);
            _callDeleteChannelPartnerRepricingConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the given
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// permanently. You can only delete configs if their
        /// [RepricingConfig.effective_invoice_month][google.cloud.channel.v1.RepricingConfig.effective_invoice_month]
        /// is set to a date after the current month.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The account making the request does not own
        /// this customer.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * FAILED_PRECONDITION: The
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// is active or in the past.
        /// * NOT_FOUND: No
        /// [ChannelPartnerRepricingConfig][google.cloud.channel.v1.ChannelPartnerRepricingConfig]
        /// found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteChannelPartnerRepricingConfigAsync(DeleteChannelPartnerRepricingConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteChannelPartnerRepricingConfigRequest(ref request, ref callSettings);
            return _callDeleteChannelPartnerRepricingConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Rebilling supported SKU groups the account is authorized to
        /// sell.
        /// Reference: https://cloud.google.com/skus/sku-groups
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different, or the account doesn't exist.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the [SkuGroup][google.cloud.channel.v1.SkuGroup] resources.
        /// The data for each resource is displayed in the alphabetical order of SKU
        /// group display name.
        /// The data for each resource is displayed in the ascending order of
        /// [SkuGroup.display_name][google.cloud.channel.v1.SkuGroup.display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SkuGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroups(ListSkuGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkuGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSkuGroupsRequest, ListSkuGroupsResponse, SkuGroup>(_callListSkuGroups, request, callSettings);
        }

        /// <summary>
        /// Lists the Rebilling supported SKU groups the account is authorized to
        /// sell.
        /// Reference: https://cloud.google.com/skus/sku-groups
        /// 
        /// Possible Error Codes:
        /// 
        /// * PERMISSION_DENIED: If the account making the request and the account
        /// being queried are different, or the account doesn't exist.
        /// * INTERNAL: Any non-user error related to technical issues in the
        /// backend. In this case, contact Cloud Channel support.
        /// 
        /// Return Value:
        /// If successful, the [SkuGroup][google.cloud.channel.v1.SkuGroup] resources.
        /// The data for each resource is displayed in the alphabetical order of SKU
        /// group display name.
        /// The data for each resource is displayed in the ascending order of
        /// [SkuGroup.display_name][google.cloud.channel.v1.SkuGroup.display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SkuGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroupsAsync(ListSkuGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkuGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSkuGroupsRequest, ListSkuGroupsResponse, SkuGroup>(_callListSkuGroups, request, callSettings);
        }

        /// <summary>
        /// Lists the Billable SKUs in a given SKU group.
        /// 
        /// Possible error codes:
        /// PERMISSION_DENIED: If the account making the request and the account
        /// being queried for are different, or the account doesn't exist.
        /// INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request.
        /// INTERNAL: Any non-user error related to technical issue in the
        /// backend. In this case, contact cloud channel support.
        /// 
        /// Return Value:
        /// If successful, the [BillableSku][google.cloud.channel.v1.BillableSku]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * [BillableSku.service_display_name][google.cloud.channel.v1.BillableSku.service_display_name]
        /// * [BillableSku.sku_display_name][google.cloud.channel.v1.BillableSku.sku_display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BillableSku"/> resources.</returns>
        public override gax::PagedEnumerable<ListSkuGroupBillableSkusResponse, BillableSku> ListSkuGroupBillableSkus(ListSkuGroupBillableSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkuGroupBillableSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSkuGroupBillableSkusRequest, ListSkuGroupBillableSkusResponse, BillableSku>(_callListSkuGroupBillableSkus, request, callSettings);
        }

        /// <summary>
        /// Lists the Billable SKUs in a given SKU group.
        /// 
        /// Possible error codes:
        /// PERMISSION_DENIED: If the account making the request and the account
        /// being queried for are different, or the account doesn't exist.
        /// INVALID_ARGUMENT: Missing or invalid required parameters in the
        /// request.
        /// INTERNAL: Any non-user error related to technical issue in the
        /// backend. In this case, contact cloud channel support.
        /// 
        /// Return Value:
        /// If successful, the [BillableSku][google.cloud.channel.v1.BillableSku]
        /// resources. The data for each resource is displayed in the ascending order
        /// of:
        /// 
        /// * [BillableSku.service_display_name][google.cloud.channel.v1.BillableSku.service_display_name]
        /// * [BillableSku.sku_display_name][google.cloud.channel.v1.BillableSku.sku_display_name]
        /// 
        /// If unsuccessful, returns an error.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BillableSku"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSkuGroupBillableSkusResponse, BillableSku> ListSkuGroupBillableSkusAsync(ListSkuGroupBillableSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkuGroupBillableSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSkuGroupBillableSkusRequest, ListSkuGroupBillableSkusResponse, BillableSku>(_callListSkuGroupBillableSkus, request, callSettings);
        }

        /// <summary>
        /// Returns the requested [Offer][google.cloud.channel.v1.Offer] resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The entitlement doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement or offer was not found.
        /// 
        /// Return value:
        /// The [Offer][google.cloud.channel.v1.Offer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Offer LookupOffer(LookupOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupOfferRequest(ref request, ref callSettings);
            return _callLookupOffer.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested [Offer][google.cloud.channel.v1.Offer] resource.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The entitlement doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: Entitlement or offer was not found.
        /// 
        /// Return value:
        /// The [Offer][google.cloud.channel.v1.Offer] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Offer> LookupOfferAsync(LookupOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupOfferRequest(ref request, ref callSettings);
            return _callLookupOffer.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the Products the reseller is authorized to sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedEnumerable<ListProductsResponse, Product> ListProducts(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Lists the Products the reseller is authorized to sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Product"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListProductsResponse, Product> ListProductsAsync(ListProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListProductsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListProductsRequest, ListProductsResponse, Product>(_callListProducts, request, callSettings);
        }

        /// <summary>
        /// Lists the SKUs for a product the reseller is authorized to sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
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
        /// Lists the SKUs for a product the reseller is authorized to sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
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
        /// Lists the Offers the reseller can sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Offer"/> resources.</returns>
        public override gax::PagedEnumerable<ListOffersResponse, Offer> ListOffers(ListOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListOffersRequest, ListOffersResponse, Offer>(_callListOffers, request, callSettings);
        }

        /// <summary>
        /// Lists the Offers the reseller can sell.
        /// 
        /// Possible error codes:
        /// 
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Offer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListOffersResponse, Offer> ListOffersAsync(ListOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListOffersRequest, ListOffersResponse, Offer>(_callListOffers, request, callSettings);
        }

        /// <summary>
        /// Lists the following:
        /// 
        /// * SKUs that you can purchase for a customer
        /// * SKUs that you can upgrade or downgrade for an entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PurchasableSku"/> resources.</returns>
        public override gax::PagedEnumerable<ListPurchasableSkusResponse, PurchasableSku> ListPurchasableSkus(ListPurchasableSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPurchasableSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPurchasableSkusRequest, ListPurchasableSkusResponse, PurchasableSku>(_callListPurchasableSkus, request, callSettings);
        }

        /// <summary>
        /// Lists the following:
        /// 
        /// * SKUs that you can purchase for a customer
        /// * SKUs that you can upgrade or downgrade for an entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PurchasableSku"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPurchasableSkusResponse, PurchasableSku> ListPurchasableSkusAsync(ListPurchasableSkusRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPurchasableSkusRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPurchasableSkusRequest, ListPurchasableSkusResponse, PurchasableSku>(_callListPurchasableSkus, request, callSettings);
        }

        /// <summary>
        /// Lists the following:
        /// 
        /// * Offers that you can purchase for a customer.
        /// * Offers that you can change for an entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PurchasableOffer"/> resources.</returns>
        public override gax::PagedEnumerable<ListPurchasableOffersResponse, PurchasableOffer> ListPurchasableOffers(ListPurchasableOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPurchasableOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPurchasableOffersRequest, ListPurchasableOffersResponse, PurchasableOffer>(_callListPurchasableOffers, request, callSettings);
        }

        /// <summary>
        /// Lists the following:
        /// 
        /// * Offers that you can purchase for a customer.
        /// * Offers that you can change for an entitlement.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED:
        /// * The customer doesn't belong to the reseller
        /// * The reseller is not authorized to transact on this Product. See
        /// https://support.google.com/channelservices/answer/9759265
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PurchasableOffer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPurchasableOffersResponse, PurchasableOffer> ListPurchasableOffersAsync(ListPurchasableOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPurchasableOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPurchasableOffersRequest, ListPurchasableOffersResponse, PurchasableOffer>(_callListPurchasableOffers, request, callSettings);
        }

        /// <summary>
        /// Lists the billing accounts that are eligible to purchase particular SKUs
        /// for a given customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// Based on the provided list of SKUs, returns a list of SKU groups that must
        /// be purchased using the same billing account and the billing accounts
        /// eligible to purchase each SKU group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override QueryEligibleBillingAccountsResponse QueryEligibleBillingAccounts(QueryEligibleBillingAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryEligibleBillingAccountsRequest(ref request, ref callSettings);
            return _callQueryEligibleBillingAccounts.Sync(request, callSettings);
        }

        /// <summary>
        /// Lists the billing accounts that are eligible to purchase particular SKUs
        /// for a given customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// Based on the provided list of SKUs, returns a list of SKU groups that must
        /// be purchased using the same billing account and the billing accounts
        /// eligible to purchase each SKU group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<QueryEligibleBillingAccountsResponse> QueryEligibleBillingAccountsAsync(QueryEligibleBillingAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_QueryEligibleBillingAccountsRequest(ref request, ref callSettings);
            return _callQueryEligibleBillingAccounts.Async(request, callSettings);
        }

        /// <summary>
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub
        /// topic for this Channel Services account. After you create a
        /// subscriber, you get the events through
        /// [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name with the registered service email address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RegisterSubscriberResponse RegisterSubscriber(RegisterSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterSubscriberRequest(ref request, ref callSettings);
            return _callRegisterSubscriber.Sync(request, callSettings);
        }

        /// <summary>
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub
        /// topic for this Channel Services account. After you create a
        /// subscriber, you get the events through
        /// [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name with the registered service email address.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RegisterSubscriberResponse> RegisterSubscriberAsync(RegisterSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RegisterSubscriberRequest(ref request, ref callSettings);
            return _callRegisterSubscriber.Async(request, callSettings);
        }

        /// <summary>
        /// Unregisters a service account with subscriber privileges on the Cloud
        /// Pub/Sub topic created for this Channel Services account. If there are no
        /// service accounts left with subscriber privileges, this deletes the topic.
        /// You can call ListSubscribers to check for these accounts.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name that unregistered the service email address.
        /// Returns a success response if the service email address wasn't registered
        /// with the topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UnregisterSubscriberResponse UnregisterSubscriber(UnregisterSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnregisterSubscriberRequest(ref request, ref callSettings);
            return _callUnregisterSubscriber.Sync(request, callSettings);
        }

        /// <summary>
        /// Unregisters a service account with subscriber privileges on the Cloud
        /// Pub/Sub topic created for this Channel Services account. If there are no
        /// service accounts left with subscriber privileges, this deletes the topic.
        /// You can call ListSubscribers to check for these accounts.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// The topic name that unregistered the service email address.
        /// Returns a success response if the service email address wasn't registered
        /// with the topic.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UnregisterSubscriberResponse> UnregisterSubscriberAsync(UnregisterSubscriberRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnregisterSubscriberRequest(ref request, ref callSettings);
            return _callUnregisterSubscriber.Async(request, callSettings);
        }

        /// <summary>
        /// Lists service accounts with subscriber privileges on the Cloud Pub/Sub
        /// topic created for this Channel Services account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// A list of service email addresses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedEnumerable<ListSubscribersResponse, string> ListSubscribers(ListSubscribersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscribersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSubscribersRequest, ListSubscribersResponse, string>(_callListSubscribers, request, callSettings);
        }

        /// <summary>
        /// Lists service accounts with subscriber privileges on the Cloud Pub/Sub
        /// topic created for this Channel Services account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different, or the impersonated user
        /// is not a super admin.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: The topic resource doesn't exist.
        /// * INTERNAL: Any non-user error related to a technical issue in the
        /// backend. Contact Cloud Channel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// Contact Cloud Channel support.
        /// 
        /// Return value:
        /// A list of service email addresses.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="string"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSubscribersResponse, string> ListSubscribersAsync(ListSubscribersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSubscribersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSubscribersRequest, ListSubscribersResponse, string>(_callListSubscribers, request, callSettings);
        }

        /// <summary>
        /// List entitlement history.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different.
        /// * INVALID_ARGUMENT: Missing or invalid required fields in the request.
        /// * NOT_FOUND: The parent resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// * INTERNAL: Any non-user error related to a technical issue in the backend.
        /// In this case, contact CloudChannel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// In this case, contact Cloud Channel support.
        /// 
        /// Return value:
        /// List of [EntitlementChange][google.cloud.channel.v1.EntitlementChange]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntitlementChange"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntitlementChangesResponse, EntitlementChange> ListEntitlementChanges(ListEntitlementChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitlementChangesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntitlementChangesRequest, ListEntitlementChangesResponse, EntitlementChange>(_callListEntitlementChanges, request, callSettings);
        }

        /// <summary>
        /// List entitlement history.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request and the
        /// provided reseller account are different.
        /// * INVALID_ARGUMENT: Missing or invalid required fields in the request.
        /// * NOT_FOUND: The parent resource doesn't exist. Usually the result of an
        /// invalid name parameter.
        /// * INTERNAL: Any non-user error related to a technical issue in the backend.
        /// In this case, contact CloudChannel support.
        /// * UNKNOWN: Any non-user error related to a technical issue in the backend.
        /// In this case, contact Cloud Channel support.
        /// 
        /// Return value:
        /// List of [EntitlementChange][google.cloud.channel.v1.EntitlementChange]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntitlementChange"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntitlementChangesResponse, EntitlementChange> ListEntitlementChangesAsync(ListEntitlementChangesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntitlementChangesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntitlementChangesRequest, ListEntitlementChangesResponse, EntitlementChange>(_callListEntitlementChanges, request, callSettings);
        }
    }

    public partial class ListCustomersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntitlementsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTransferableSkusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTransferableOffersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChannelPartnerLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomerRepricingConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListChannelPartnerRepricingConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSkuGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSkuGroupBillableSkusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListProductsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSkusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListOffersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPurchasableSkusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPurchasableOffersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSubscribersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntitlementChangesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCustomersResponse : gaxgrpc::IPageResponse<Customer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Customer> GetEnumerator() => Customers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEntitlementsResponse : gaxgrpc::IPageResponse<Entitlement>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Entitlement> GetEnumerator() => Entitlements.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransferableSkusResponse : gaxgrpc::IPageResponse<TransferableSku>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TransferableSku> GetEnumerator() => TransferableSkus.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTransferableOffersResponse : gaxgrpc::IPageResponse<TransferableOffer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TransferableOffer> GetEnumerator() => TransferableOffers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListChannelPartnerLinksResponse : gaxgrpc::IPageResponse<ChannelPartnerLink>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ChannelPartnerLink> GetEnumerator() => ChannelPartnerLinks.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCustomerRepricingConfigsResponse : gaxgrpc::IPageResponse<CustomerRepricingConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CustomerRepricingConfig> GetEnumerator() => CustomerRepricingConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListChannelPartnerRepricingConfigsResponse : gaxgrpc::IPageResponse<ChannelPartnerRepricingConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ChannelPartnerRepricingConfig> GetEnumerator() =>
            ChannelPartnerRepricingConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSkuGroupsResponse : gaxgrpc::IPageResponse<SkuGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SkuGroup> GetEnumerator() => SkuGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSkuGroupBillableSkusResponse : gaxgrpc::IPageResponse<BillableSku>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BillableSku> GetEnumerator() => BillableSkus.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListProductsResponse : gaxgrpc::IPageResponse<Product>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Product> GetEnumerator() => Products.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSkusResponse : gaxgrpc::IPageResponse<Sku>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Sku> GetEnumerator() => Skus.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListOffersResponse : gaxgrpc::IPageResponse<Offer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Offer> GetEnumerator() => Offers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPurchasableSkusResponse : gaxgrpc::IPageResponse<PurchasableSku>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PurchasableSku> GetEnumerator() => PurchasableSkus.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPurchasableOffersResponse : gaxgrpc::IPageResponse<PurchasableOffer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PurchasableOffer> GetEnumerator() => PurchasableOffers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSubscribersResponse : gaxgrpc::IPageResponse<string>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<string> GetEnumerator() => ServiceAccounts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEntitlementChangesResponse : gaxgrpc::IPageResponse<EntitlementChange>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EntitlementChange> GetEnumerator() => EntitlementChanges.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CloudChannelService
    {
        public partial class CloudChannelServiceClient
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
