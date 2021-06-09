// Copyright 2021 Google LLC
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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

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
            LookupOfferSettings = existing.LookupOfferSettings;
            ListProductsSettings = existing.ListProductsSettings;
            ListSkusSettings = existing.ListSkusSettings;
            ListOffersSettings = existing.ListOffersSettings;
            ListPurchasableSkusSettings = existing.ListPurchasableSkusSettings;
            ListPurchasableOffersSettings = existing.ListPurchasableOffersSettings;
            RegisterSubscriberSettings = existing.RegisterSubscriberSettings;
            UnregisterSubscriberSettings = existing.UnregisterSubscriberSettings;
            ListSubscribersSettings = existing.ListSubscribersSettings;
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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteCustomerSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateChannelPartnerLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListPurchasableOffersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

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
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSubscribersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

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
            return CloudChannelServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CloudChannelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CloudChannelServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CloudChannelServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CloudChannelServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CloudChannelServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
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
    /// - [Customer][google.cloud.channel.v1.Customer]s: An entity—usually an enterprise—managed by a reseller or
    /// distributor.
    /// 
    /// - [Entitlement][google.cloud.channel.v1.Entitlement]s: An entity that provides a customer with the means to use
    /// a service. Entitlements are created or updated as a result of a successful
    /// fulfillment.
    /// 
    /// - [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s: An entity that identifies links between
    /// distributors and their indirect resellers in a channel.
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

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

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
        /// <returns>The created <see cref="CloudChannelServiceClient"/>.</returns>
        internal static CloudChannelServiceClient Create(grpccore::CallInvoker callInvoker, CloudChannelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CloudChannelService.CloudChannelServiceClient grpcClient = new CloudChannelService.CloudChannelServiceClient(callInvoker);
            return new CloudChannelServiceClientImpl(grpcClient, settings);
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
        /// List of [Customer][google.cloud.channel.v1.Customer]s, or an empty list if there are no customers.
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
        /// List of [Customer][google.cloud.channel.v1.Customer]s, or an empty list if there are no customers.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Customer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCustomersResponse, Customer> ListCustomersAsync(ListCustomersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// A list of [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources for the domain (may be
        /// empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources match the domain.
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
        /// A list of [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources for the domain (may be
        /// empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources match the domain.
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
        /// A list of [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources for the domain (may be
        /// empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources match the domain.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckCloudIdentityAccountsExistResponse> CheckCloudIdentityAccountsExistAsync(CheckCloudIdentityAccountsExistRequest request, st::CancellationToken cancellationToken) =>
            CheckCloudIdentityAccountsExistAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under the reseller or distributor
        /// account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
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
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under the reseller or distributor
        /// account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
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
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under the reseller or distributor
        /// account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
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
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource for the reseller or
        /// distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource for the reseller or
        /// distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource for the reseller or
        /// distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the customer to delete.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteCustomerAsync(CustomerName name, st::CancellationToken cancellationToken) =>
            DeleteCustomerAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a Cloud Identity for the given customer using the customer's
        /// information, or the information provided here.
        /// 
        /// Possible error codes:
        /// 
        /// *  PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// *  PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// *  PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// Lists [Entitlement][google.cloud.channel.v1.Entitlement]s belonging to a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's [Entitlement][google.cloud.channel.v1.Entitlement]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlements(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Entitlement][google.cloud.channel.v1.Entitlement]s belonging to a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's [Entitlement][google.cloud.channel.v1.Entitlement]s.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entitlement"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntitlementsResponse, Entitlement> ListEntitlementsAsync(ListEntitlementsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [TransferableSku][google.cloud.channel.v1.TransferableSku]s of a customer based on the Cloud Identity ID or
        /// Customer Name in the request.
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
        /// A list of the customer's [TransferableSku][google.cloud.channel.v1.TransferableSku].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferableSku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferableSkusResponse, TransferableSku> ListTransferableSkus(ListTransferableSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [TransferableSku][google.cloud.channel.v1.TransferableSku]s of a customer based on the Cloud Identity ID or
        /// Customer Name in the request.
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
        /// A list of the customer's [TransferableSku][google.cloud.channel.v1.TransferableSku].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferableSku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferableSkusResponse, TransferableSku> ListTransferableSkusAsync(ListTransferableSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [TransferableOffer][google.cloud.channel.v1.TransferableOffer]s of a customer based on Cloud Identity ID or
        /// Customer Name in the request.
        /// 
        /// Use this method when a reseller gets the entitlement information of an
        /// unowned customer. The reseller should provide the customer's
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
        /// List of [TransferableOffer][google.cloud.channel.v1.TransferableOffer] for the given customer and SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TransferableOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTransferableOffersResponse, TransferableOffer> ListTransferableOffers(ListTransferableOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [TransferableOffer][google.cloud.channel.v1.TransferableOffer]s of a customer based on Cloud Identity ID or
        /// Customer Name in the request.
        /// 
        /// Use this method when a reseller gets the entitlement information of an
        /// unowned customer. The reseller should provide the customer's
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
        /// List of [TransferableOffer][google.cloud.channel.v1.TransferableOffer] for the given customer and SKU.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TransferableOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTransferableOffersResponse, TransferableOffer> ListTransferableOffersAsync(ListTransferableOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
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
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
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
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// List [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s belonging to a distributor.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// The list of the distributor account's [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ChannelPartnerLink"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListChannelPartnerLinksResponse, ChannelPartnerLink> ListChannelPartnerLinks(ListChannelPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s belonging to a distributor.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// The list of the distributor account's [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resources.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ChannelPartnerLink"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListChannelPartnerLinksResponse, ChannelPartnerLink> ListChannelPartnerLinksAsync(ListChannelPartnerLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ChannelPartnerLink GetChannelPartnerLink(GetChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerLink> GetChannelPartnerLinkAsync(GetChannelPartnerLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The updated [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The updated [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The updated [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ChannelPartnerLink> UpdateChannelPartnerLinkAsync(UpdateChannelPartnerLinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateChannelPartnerLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller
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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PurchasableOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPurchasableOffersResponse, PurchasableOffer> ListPurchasableOffersAsync(ListPurchasableOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub
        /// topic for this Channel Services account. After you create a
        /// subscriber, you get the events through [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
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
        /// subscriber, you get the events through [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
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
        /// subscriber, you get the events through [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
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
    /// - [Customer][google.cloud.channel.v1.Customer]s: An entity—usually an enterprise—managed by a reseller or
    /// distributor.
    /// 
    /// - [Entitlement][google.cloud.channel.v1.Entitlement]s: An entity that provides a customer with the means to use
    /// a service. Entitlements are created or updated as a result of a successful
    /// fulfillment.
    /// 
    /// - [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s: An entity that identifies links between
    /// distributors and their indirect resellers in a channel.
    /// </remarks>
    public sealed partial class CloudChannelServiceClientImpl : CloudChannelServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListCustomersRequest, ListCustomersResponse> _callListCustomers;

        private readonly gaxgrpc::ApiCall<GetCustomerRequest, Customer> _callGetCustomer;

        private readonly gaxgrpc::ApiCall<CheckCloudIdentityAccountsExistRequest, CheckCloudIdentityAccountsExistResponse> _callCheckCloudIdentityAccountsExist;

        private readonly gaxgrpc::ApiCall<CreateCustomerRequest, Customer> _callCreateCustomer;

        private readonly gaxgrpc::ApiCall<UpdateCustomerRequest, Customer> _callUpdateCustomer;

        private readonly gaxgrpc::ApiCall<DeleteCustomerRequest, wkt::Empty> _callDeleteCustomer;

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

        private readonly gaxgrpc::ApiCall<LookupOfferRequest, Offer> _callLookupOffer;

        private readonly gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> _callListProducts;

        private readonly gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> _callListSkus;

        private readonly gaxgrpc::ApiCall<ListOffersRequest, ListOffersResponse> _callListOffers;

        private readonly gaxgrpc::ApiCall<ListPurchasableSkusRequest, ListPurchasableSkusResponse> _callListPurchasableSkus;

        private readonly gaxgrpc::ApiCall<ListPurchasableOffersRequest, ListPurchasableOffersResponse> _callListPurchasableOffers;

        private readonly gaxgrpc::ApiCall<RegisterSubscriberRequest, RegisterSubscriberResponse> _callRegisterSubscriber;

        private readonly gaxgrpc::ApiCall<UnregisterSubscriberRequest, UnregisterSubscriberResponse> _callUnregisterSubscriber;

        private readonly gaxgrpc::ApiCall<ListSubscribersRequest, ListSubscribersResponse> _callListSubscribers;

        /// <summary>
        /// Constructs a client wrapper for the CloudChannelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CloudChannelServiceSettings"/> used within this client.</param>
        public CloudChannelServiceClientImpl(CloudChannelService.CloudChannelServiceClient grpcClient, CloudChannelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CloudChannelServiceSettings effectiveSettings = settings ?? CloudChannelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            ProvisionCloudIdentityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ProvisionCloudIdentityOperationsSettings);
            CreateEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEntitlementOperationsSettings);
            ChangeParametersOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ChangeParametersOperationsSettings);
            ChangeRenewalSettingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ChangeRenewalSettingsOperationsSettings);
            ChangeOfferOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ChangeOfferOperationsSettings);
            StartPaidServiceOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.StartPaidServiceOperationsSettings);
            SuspendEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SuspendEntitlementOperationsSettings);
            CancelEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CancelEntitlementOperationsSettings);
            ActivateEntitlementOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ActivateEntitlementOperationsSettings);
            TransferEntitlementsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TransferEntitlementsOperationsSettings);
            TransferEntitlementsToGoogleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.TransferEntitlementsToGoogleOperationsSettings);
            _callListCustomers = clientHelper.BuildApiCall<ListCustomersRequest, ListCustomersResponse>(grpcClient.ListCustomersAsync, grpcClient.ListCustomers, effectiveSettings.ListCustomersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCustomers);
            Modify_ListCustomersApiCall(ref _callListCustomers);
            _callGetCustomer = clientHelper.BuildApiCall<GetCustomerRequest, Customer>(grpcClient.GetCustomerAsync, grpcClient.GetCustomer, effectiveSettings.GetCustomerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCustomer);
            Modify_GetCustomerApiCall(ref _callGetCustomer);
            _callCheckCloudIdentityAccountsExist = clientHelper.BuildApiCall<CheckCloudIdentityAccountsExistRequest, CheckCloudIdentityAccountsExistResponse>(grpcClient.CheckCloudIdentityAccountsExistAsync, grpcClient.CheckCloudIdentityAccountsExist, effectiveSettings.CheckCloudIdentityAccountsExistSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCheckCloudIdentityAccountsExist);
            Modify_CheckCloudIdentityAccountsExistApiCall(ref _callCheckCloudIdentityAccountsExist);
            _callCreateCustomer = clientHelper.BuildApiCall<CreateCustomerRequest, Customer>(grpcClient.CreateCustomerAsync, grpcClient.CreateCustomer, effectiveSettings.CreateCustomerSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCustomer);
            Modify_CreateCustomerApiCall(ref _callCreateCustomer);
            _callUpdateCustomer = clientHelper.BuildApiCall<UpdateCustomerRequest, Customer>(grpcClient.UpdateCustomerAsync, grpcClient.UpdateCustomer, effectiveSettings.UpdateCustomerSettings).WithGoogleRequestParam("customer.name", request => request.Customer?.Name);
            Modify_ApiCall(ref _callUpdateCustomer);
            Modify_UpdateCustomerApiCall(ref _callUpdateCustomer);
            _callDeleteCustomer = clientHelper.BuildApiCall<DeleteCustomerRequest, wkt::Empty>(grpcClient.DeleteCustomerAsync, grpcClient.DeleteCustomer, effectiveSettings.DeleteCustomerSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCustomer);
            Modify_DeleteCustomerApiCall(ref _callDeleteCustomer);
            _callProvisionCloudIdentity = clientHelper.BuildApiCall<ProvisionCloudIdentityRequest, lro::Operation>(grpcClient.ProvisionCloudIdentityAsync, grpcClient.ProvisionCloudIdentity, effectiveSettings.ProvisionCloudIdentitySettings).WithGoogleRequestParam("customer", request => request.Customer);
            Modify_ApiCall(ref _callProvisionCloudIdentity);
            Modify_ProvisionCloudIdentityApiCall(ref _callProvisionCloudIdentity);
            _callListEntitlements = clientHelper.BuildApiCall<ListEntitlementsRequest, ListEntitlementsResponse>(grpcClient.ListEntitlementsAsync, grpcClient.ListEntitlements, effectiveSettings.ListEntitlementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntitlements);
            Modify_ListEntitlementsApiCall(ref _callListEntitlements);
            _callListTransferableSkus = clientHelper.BuildApiCall<ListTransferableSkusRequest, ListTransferableSkusResponse>(grpcClient.ListTransferableSkusAsync, grpcClient.ListTransferableSkus, effectiveSettings.ListTransferableSkusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransferableSkus);
            Modify_ListTransferableSkusApiCall(ref _callListTransferableSkus);
            _callListTransferableOffers = clientHelper.BuildApiCall<ListTransferableOffersRequest, ListTransferableOffersResponse>(grpcClient.ListTransferableOffersAsync, grpcClient.ListTransferableOffers, effectiveSettings.ListTransferableOffersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTransferableOffers);
            Modify_ListTransferableOffersApiCall(ref _callListTransferableOffers);
            _callGetEntitlement = clientHelper.BuildApiCall<GetEntitlementRequest, Entitlement>(grpcClient.GetEntitlementAsync, grpcClient.GetEntitlement, effectiveSettings.GetEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntitlement);
            Modify_GetEntitlementApiCall(ref _callGetEntitlement);
            _callCreateEntitlement = clientHelper.BuildApiCall<CreateEntitlementRequest, lro::Operation>(grpcClient.CreateEntitlementAsync, grpcClient.CreateEntitlement, effectiveSettings.CreateEntitlementSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntitlement);
            Modify_CreateEntitlementApiCall(ref _callCreateEntitlement);
            _callChangeParameters = clientHelper.BuildApiCall<ChangeParametersRequest, lro::Operation>(grpcClient.ChangeParametersAsync, grpcClient.ChangeParameters, effectiveSettings.ChangeParametersSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callChangeParameters);
            Modify_ChangeParametersApiCall(ref _callChangeParameters);
            _callChangeRenewalSettings = clientHelper.BuildApiCall<ChangeRenewalSettingsRequest, lro::Operation>(grpcClient.ChangeRenewalSettingsAsync, grpcClient.ChangeRenewalSettings, effectiveSettings.ChangeRenewalSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callChangeRenewalSettings);
            Modify_ChangeRenewalSettingsApiCall(ref _callChangeRenewalSettings);
            _callChangeOffer = clientHelper.BuildApiCall<ChangeOfferRequest, lro::Operation>(grpcClient.ChangeOfferAsync, grpcClient.ChangeOffer, effectiveSettings.ChangeOfferSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callChangeOffer);
            Modify_ChangeOfferApiCall(ref _callChangeOffer);
            _callStartPaidService = clientHelper.BuildApiCall<StartPaidServiceRequest, lro::Operation>(grpcClient.StartPaidServiceAsync, grpcClient.StartPaidService, effectiveSettings.StartPaidServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callStartPaidService);
            Modify_StartPaidServiceApiCall(ref _callStartPaidService);
            _callSuspendEntitlement = clientHelper.BuildApiCall<SuspendEntitlementRequest, lro::Operation>(grpcClient.SuspendEntitlementAsync, grpcClient.SuspendEntitlement, effectiveSettings.SuspendEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSuspendEntitlement);
            Modify_SuspendEntitlementApiCall(ref _callSuspendEntitlement);
            _callCancelEntitlement = clientHelper.BuildApiCall<CancelEntitlementRequest, lro::Operation>(grpcClient.CancelEntitlementAsync, grpcClient.CancelEntitlement, effectiveSettings.CancelEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelEntitlement);
            Modify_CancelEntitlementApiCall(ref _callCancelEntitlement);
            _callActivateEntitlement = clientHelper.BuildApiCall<ActivateEntitlementRequest, lro::Operation>(grpcClient.ActivateEntitlementAsync, grpcClient.ActivateEntitlement, effectiveSettings.ActivateEntitlementSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callActivateEntitlement);
            Modify_ActivateEntitlementApiCall(ref _callActivateEntitlement);
            _callTransferEntitlements = clientHelper.BuildApiCall<TransferEntitlementsRequest, lro::Operation>(grpcClient.TransferEntitlementsAsync, grpcClient.TransferEntitlements, effectiveSettings.TransferEntitlementsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTransferEntitlements);
            Modify_TransferEntitlementsApiCall(ref _callTransferEntitlements);
            _callTransferEntitlementsToGoogle = clientHelper.BuildApiCall<TransferEntitlementsToGoogleRequest, lro::Operation>(grpcClient.TransferEntitlementsToGoogleAsync, grpcClient.TransferEntitlementsToGoogle, effectiveSettings.TransferEntitlementsToGoogleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callTransferEntitlementsToGoogle);
            Modify_TransferEntitlementsToGoogleApiCall(ref _callTransferEntitlementsToGoogle);
            _callListChannelPartnerLinks = clientHelper.BuildApiCall<ListChannelPartnerLinksRequest, ListChannelPartnerLinksResponse>(grpcClient.ListChannelPartnerLinksAsync, grpcClient.ListChannelPartnerLinks, effectiveSettings.ListChannelPartnerLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListChannelPartnerLinks);
            Modify_ListChannelPartnerLinksApiCall(ref _callListChannelPartnerLinks);
            _callGetChannelPartnerLink = clientHelper.BuildApiCall<GetChannelPartnerLinkRequest, ChannelPartnerLink>(grpcClient.GetChannelPartnerLinkAsync, grpcClient.GetChannelPartnerLink, effectiveSettings.GetChannelPartnerLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetChannelPartnerLink);
            Modify_GetChannelPartnerLinkApiCall(ref _callGetChannelPartnerLink);
            _callCreateChannelPartnerLink = clientHelper.BuildApiCall<CreateChannelPartnerLinkRequest, ChannelPartnerLink>(grpcClient.CreateChannelPartnerLinkAsync, grpcClient.CreateChannelPartnerLink, effectiveSettings.CreateChannelPartnerLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateChannelPartnerLink);
            Modify_CreateChannelPartnerLinkApiCall(ref _callCreateChannelPartnerLink);
            _callUpdateChannelPartnerLink = clientHelper.BuildApiCall<UpdateChannelPartnerLinkRequest, ChannelPartnerLink>(grpcClient.UpdateChannelPartnerLinkAsync, grpcClient.UpdateChannelPartnerLink, effectiveSettings.UpdateChannelPartnerLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUpdateChannelPartnerLink);
            Modify_UpdateChannelPartnerLinkApiCall(ref _callUpdateChannelPartnerLink);
            _callLookupOffer = clientHelper.BuildApiCall<LookupOfferRequest, Offer>(grpcClient.LookupOfferAsync, grpcClient.LookupOffer, effectiveSettings.LookupOfferSettings).WithGoogleRequestParam("entitlement", request => request.Entitlement);
            Modify_ApiCall(ref _callLookupOffer);
            Modify_LookupOfferApiCall(ref _callLookupOffer);
            _callListProducts = clientHelper.BuildApiCall<ListProductsRequest, ListProductsResponse>(grpcClient.ListProductsAsync, grpcClient.ListProducts, effectiveSettings.ListProductsSettings);
            Modify_ApiCall(ref _callListProducts);
            Modify_ListProductsApiCall(ref _callListProducts);
            _callListSkus = clientHelper.BuildApiCall<ListSkusRequest, ListSkusResponse>(grpcClient.ListSkusAsync, grpcClient.ListSkus, effectiveSettings.ListSkusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkus);
            Modify_ListSkusApiCall(ref _callListSkus);
            _callListOffers = clientHelper.BuildApiCall<ListOffersRequest, ListOffersResponse>(grpcClient.ListOffersAsync, grpcClient.ListOffers, effectiveSettings.ListOffersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListOffers);
            Modify_ListOffersApiCall(ref _callListOffers);
            _callListPurchasableSkus = clientHelper.BuildApiCall<ListPurchasableSkusRequest, ListPurchasableSkusResponse>(grpcClient.ListPurchasableSkusAsync, grpcClient.ListPurchasableSkus, effectiveSettings.ListPurchasableSkusSettings).WithGoogleRequestParam("customer", request => request.Customer);
            Modify_ApiCall(ref _callListPurchasableSkus);
            Modify_ListPurchasableSkusApiCall(ref _callListPurchasableSkus);
            _callListPurchasableOffers = clientHelper.BuildApiCall<ListPurchasableOffersRequest, ListPurchasableOffersResponse>(grpcClient.ListPurchasableOffersAsync, grpcClient.ListPurchasableOffers, effectiveSettings.ListPurchasableOffersSettings).WithGoogleRequestParam("customer", request => request.Customer);
            Modify_ApiCall(ref _callListPurchasableOffers);
            Modify_ListPurchasableOffersApiCall(ref _callListPurchasableOffers);
            _callRegisterSubscriber = clientHelper.BuildApiCall<RegisterSubscriberRequest, RegisterSubscriberResponse>(grpcClient.RegisterSubscriberAsync, grpcClient.RegisterSubscriber, effectiveSettings.RegisterSubscriberSettings).WithGoogleRequestParam("account", request => request.Account);
            Modify_ApiCall(ref _callRegisterSubscriber);
            Modify_RegisterSubscriberApiCall(ref _callRegisterSubscriber);
            _callUnregisterSubscriber = clientHelper.BuildApiCall<UnregisterSubscriberRequest, UnregisterSubscriberResponse>(grpcClient.UnregisterSubscriberAsync, grpcClient.UnregisterSubscriber, effectiveSettings.UnregisterSubscriberSettings).WithGoogleRequestParam("account", request => request.Account);
            Modify_ApiCall(ref _callUnregisterSubscriber);
            Modify_UnregisterSubscriberApiCall(ref _callUnregisterSubscriber);
            _callListSubscribers = clientHelper.BuildApiCall<ListSubscribersRequest, ListSubscribersResponse>(grpcClient.ListSubscribersAsync, grpcClient.ListSubscribers, effectiveSettings.ListSubscribersSettings).WithGoogleRequestParam("account", request => request.Account);
            Modify_ApiCall(ref _callListSubscribers);
            Modify_ListSubscribersApiCall(ref _callListSubscribers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListCustomersApiCall(ref gaxgrpc::ApiCall<ListCustomersRequest, ListCustomersResponse> call);

        partial void Modify_GetCustomerApiCall(ref gaxgrpc::ApiCall<GetCustomerRequest, Customer> call);

        partial void Modify_CheckCloudIdentityAccountsExistApiCall(ref gaxgrpc::ApiCall<CheckCloudIdentityAccountsExistRequest, CheckCloudIdentityAccountsExistResponse> call);

        partial void Modify_CreateCustomerApiCall(ref gaxgrpc::ApiCall<CreateCustomerRequest, Customer> call);

        partial void Modify_UpdateCustomerApiCall(ref gaxgrpc::ApiCall<UpdateCustomerRequest, Customer> call);

        partial void Modify_DeleteCustomerApiCall(ref gaxgrpc::ApiCall<DeleteCustomerRequest, wkt::Empty> call);

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

        partial void Modify_LookupOfferApiCall(ref gaxgrpc::ApiCall<LookupOfferRequest, Offer> call);

        partial void Modify_ListProductsApiCall(ref gaxgrpc::ApiCall<ListProductsRequest, ListProductsResponse> call);

        partial void Modify_ListSkusApiCall(ref gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> call);

        partial void Modify_ListOffersApiCall(ref gaxgrpc::ApiCall<ListOffersRequest, ListOffersResponse> call);

        partial void Modify_ListPurchasableSkusApiCall(ref gaxgrpc::ApiCall<ListPurchasableSkusRequest, ListPurchasableSkusResponse> call);

        partial void Modify_ListPurchasableOffersApiCall(ref gaxgrpc::ApiCall<ListPurchasableOffersRequest, ListPurchasableOffersResponse> call);

        partial void Modify_RegisterSubscriberApiCall(ref gaxgrpc::ApiCall<RegisterSubscriberRequest, RegisterSubscriberResponse> call);

        partial void Modify_UnregisterSubscriberApiCall(ref gaxgrpc::ApiCall<UnregisterSubscriberRequest, UnregisterSubscriberResponse> call);

        partial void Modify_ListSubscribersApiCall(ref gaxgrpc::ApiCall<ListSubscribersRequest, ListSubscribersResponse> call);

        partial void OnConstruction(CloudChannelService.CloudChannelServiceClient grpcClient, CloudChannelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CloudChannelService client</summary>
        public override CloudChannelService.CloudChannelServiceClient GrpcClient { get; }

        partial void Modify_ListCustomersRequest(ref ListCustomersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCustomerRequest(ref GetCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CheckCloudIdentityAccountsExistRequest(ref CheckCloudIdentityAccountsExistRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCustomerRequest(ref CreateCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCustomerRequest(ref UpdateCustomerRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCustomerRequest(ref DeleteCustomerRequest request, ref gaxgrpc::CallSettings settings);

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

        partial void Modify_LookupOfferRequest(ref LookupOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListProductsRequest(ref ListProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkusRequest(ref ListSkusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListOffersRequest(ref ListOffersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPurchasableSkusRequest(ref ListPurchasableSkusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPurchasableOffersRequest(ref ListPurchasableOffersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RegisterSubscriberRequest(ref RegisterSubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnregisterSubscriberRequest(ref UnregisterSubscriberRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSubscribersRequest(ref ListSubscribersRequest request, ref gaxgrpc::CallSettings settings);

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
        /// List of [Customer][google.cloud.channel.v1.Customer]s, or an empty list if there are no customers.
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
        /// List of [Customer][google.cloud.channel.v1.Customer]s, or an empty list if there are no customers.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// Returns the requested [Customer][google.cloud.channel.v1.Customer] resource.
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
        /// A list of [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources for the domain (may be
        /// empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources match the domain.
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
        /// A list of [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources for the domain (may be
        /// empty)
        /// 
        /// Note: in the v1alpha1 version of the API, a NOT_FOUND error returns if
        /// no [CloudIdentityCustomerAccount][google.cloud.channel.v1.CloudIdentityCustomerAccount] resources match the domain.
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
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under the reseller or distributor
        /// account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
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
        /// Creates a new [Customer][google.cloud.channel.v1.Customer] resource under the reseller or distributor
        /// account.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
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
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource for the reseller or
        /// distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// Updates an existing [Customer][google.cloud.channel.v1.Customer] resource for the reseller or
        /// distributor.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
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
        /// * NOT_FOUND: No [Customer][google.cloud.channel.v1.Customer] resource found for the name in the request.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteCustomerAsync(DeleteCustomerRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCustomerRequest(ref request, ref callSettings);
            return _callDeleteCustomer.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ProvisionCloudIdentity</c>.</summary>
        public override lro::OperationsClient ProvisionCloudIdentityOperationsClient { get; }

        /// <summary>
        /// Creates a Cloud Identity for the given customer using the customer's
        /// information, or the information provided here.
        /// 
        /// Possible error codes:
        /// 
        /// *  PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// *  PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// Lists [Entitlement][google.cloud.channel.v1.Entitlement]s belonging to a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's [Entitlement][google.cloud.channel.v1.Entitlement]s.
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
        /// Lists [Entitlement][google.cloud.channel.v1.Entitlement]s belonging to a customer.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// A list of the customer's [Entitlement][google.cloud.channel.v1.Entitlement]s.
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
        /// List [TransferableSku][google.cloud.channel.v1.TransferableSku]s of a customer based on the Cloud Identity ID or
        /// Customer Name in the request.
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
        /// A list of the customer's [TransferableSku][google.cloud.channel.v1.TransferableSku].
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
        /// List [TransferableSku][google.cloud.channel.v1.TransferableSku]s of a customer based on the Cloud Identity ID or
        /// Customer Name in the request.
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
        /// A list of the customer's [TransferableSku][google.cloud.channel.v1.TransferableSku].
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
        /// List [TransferableOffer][google.cloud.channel.v1.TransferableOffer]s of a customer based on Cloud Identity ID or
        /// Customer Name in the request.
        /// 
        /// Use this method when a reseller gets the entitlement information of an
        /// unowned customer. The reseller should provide the customer's
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
        /// List of [TransferableOffer][google.cloud.channel.v1.TransferableOffer] for the given customer and SKU.
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
        /// List [TransferableOffer][google.cloud.channel.v1.TransferableOffer]s of a customer based on Cloud Identity ID or
        /// Customer Name in the request.
        /// 
        /// Use this method when a reseller gets the entitlement information of an
        /// unowned customer. The reseller should provide the customer's
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
        /// List of [TransferableOffer][google.cloud.channel.v1.TransferableOffer] for the given customer and SKU.
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
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
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
        /// Returns the requested [Entitlement][google.cloud.channel.v1.Entitlement] resource.
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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller.
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
        /// List [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s belonging to a distributor.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// The list of the distributor account's [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resources.
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
        /// List [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink]s belonging to a distributor.
        /// You must be a distributor to call this method.
        /// 
        /// Possible error codes:
        /// 
        /// * PERMISSION_DENIED: The reseller account making the request is different
        /// from the reseller account in the API request.
        /// * INVALID_ARGUMENT: Required request parameters are missing or invalid.
        /// 
        /// Return value:
        /// The list of the distributor account's [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resources.
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
        /// Returns the requested [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// Returns the requested [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The new [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The updated [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// The updated [ChannelPartnerLink][google.cloud.channel.v1.ChannelPartnerLink] resource.
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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller
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
        /// * PERMISSION_DENIED: The customer doesn't belong to the reseller
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
        /// Registers a service account with subscriber privileges on the Cloud Pub/Sub
        /// topic for this Channel Services account. After you create a
        /// subscriber, you get the events through [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
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
        /// subscriber, you get the events through [SubscriberEvent][google.cloud.channel.v1.SubscriberEvent]
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
