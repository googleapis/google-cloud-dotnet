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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gcl = Google.Cloud.Location;
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

namespace Google.Cloud.CommerceProducer.V1Beta
{
    /// <summary>Settings for <see cref="CommerceTransactionClient"/> instances.</summary>
    public sealed partial class CommerceTransactionSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CommerceTransactionSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CommerceTransactionSettings"/>.</returns>
        public static CommerceTransactionSettings GetDefault() => new CommerceTransactionSettings();

        /// <summary>Constructs a new <see cref="CommerceTransactionSettings"/> object with default settings.</summary>
        public CommerceTransactionSettings()
        {
        }

        private CommerceTransactionSettings(CommerceTransactionSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListServicesSettings = existing.ListServicesSettings;
            GetServiceSettings = existing.GetServiceSettings;
            ListPrivateOffersSettings = existing.ListPrivateOffersSettings;
            GetPrivateOfferSettings = existing.GetPrivateOfferSettings;
            ResolveAmendmentTargetSettings = existing.ResolveAmendmentTargetSettings;
            CreatePrivateOfferSettings = existing.CreatePrivateOfferSettings;
            UpdatePrivateOfferSettings = existing.UpdatePrivateOfferSettings;
            PublishPrivateOfferSettings = existing.PublishPrivateOfferSettings;
            CancelPrivateOfferSettings = existing.CancelPrivateOfferSettings;
            DeletePrivateOfferSettings = existing.DeletePrivateOfferSettings;
            ListPrivateOfferDocumentsSettings = existing.ListPrivateOfferDocumentsSettings;
            GetPrivateOfferDocumentSettings = existing.GetPrivateOfferDocumentSettings;
            CreatePrivateOfferDocumentSettings = existing.CreatePrivateOfferDocumentSettings;
            UpdatePrivateOfferDocumentSettings = existing.UpdatePrivateOfferDocumentSettings;
            DeletePrivateOfferDocumentSettings = existing.DeletePrivateOfferDocumentSettings;
            ListStandardOffersSettings = existing.ListStandardOffersSettings;
            GetStandardOfferSettings = existing.GetStandardOfferSettings;
            GetSkuSettings = existing.GetSkuSettings;
            ListSkusSettings = existing.ListSkusSettings;
            GetSkuGroupSettings = existing.GetSkuGroupSettings;
            ListSkuGroupsSettings = existing.ListSkuGroupsSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CommerceTransactionSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.ListServices</c> and <c>CommerceTransactionClient.ListServicesAsync</c>.
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
        public gaxgrpc::CallSettings ListServicesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.GetService</c> and <c>CommerceTransactionClient.GetServiceAsync</c>.
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
        public gaxgrpc::CallSettings GetServiceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.ListPrivateOffers</c> and <c>CommerceTransactionClient.ListPrivateOffersAsync</c>
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
        public gaxgrpc::CallSettings ListPrivateOffersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.GetPrivateOffer</c> and <c>CommerceTransactionClient.GetPrivateOfferAsync</c>.
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
        public gaxgrpc::CallSettings GetPrivateOfferSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.ResolveAmendmentTarget</c> and
        /// <c>CommerceTransactionClient.ResolveAmendmentTargetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResolveAmendmentTargetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.CreatePrivateOffer</c> and <c>CommerceTransactionClient.CreatePrivateOfferAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePrivateOfferSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.UpdatePrivateOffer</c> and <c>CommerceTransactionClient.UpdatePrivateOfferAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePrivateOfferSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.PublishPrivateOffer</c> and
        /// <c>CommerceTransactionClient.PublishPrivateOfferAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings PublishPrivateOfferSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.CancelPrivateOffer</c> and <c>CommerceTransactionClient.CancelPrivateOfferAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CancelPrivateOfferSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.DeletePrivateOffer</c> and <c>CommerceTransactionClient.DeletePrivateOfferAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePrivateOfferSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.ListPrivateOfferDocuments</c> and
        /// <c>CommerceTransactionClient.ListPrivateOfferDocumentsAsync</c>.
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
        public gaxgrpc::CallSettings ListPrivateOfferDocumentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.GetPrivateOfferDocument</c> and
        /// <c>CommerceTransactionClient.GetPrivateOfferDocumentAsync</c>.
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
        public gaxgrpc::CallSettings GetPrivateOfferDocumentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.CreatePrivateOfferDocument</c> and
        /// <c>CommerceTransactionClient.CreatePrivateOfferDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreatePrivateOfferDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.UpdatePrivateOfferDocument</c> and
        /// <c>CommerceTransactionClient.UpdatePrivateOfferDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdatePrivateOfferDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.DeletePrivateOfferDocument</c> and
        /// <c>CommerceTransactionClient.DeletePrivateOfferDocumentAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeletePrivateOfferDocumentSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.ListStandardOffers</c> and <c>CommerceTransactionClient.ListStandardOffersAsync</c>
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
        public gaxgrpc::CallSettings ListStandardOffersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.GetStandardOffer</c> and <c>CommerceTransactionClient.GetStandardOfferAsync</c>
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
        public gaxgrpc::CallSettings GetStandardOfferSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.GetSku</c> and <c>CommerceTransactionClient.GetSkuAsync</c>.
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
        /// <c>CommerceTransactionClient.ListSkus</c> and <c>CommerceTransactionClient.ListSkusAsync</c>.
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
        /// <c>CommerceTransactionClient.GetSkuGroup</c> and <c>CommerceTransactionClient.GetSkuGroupAsync</c>.
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
        public gaxgrpc::CallSettings GetSkuGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CommerceTransactionClient.ListSkuGroups</c> and <c>CommerceTransactionClient.ListSkuGroupsAsync</c>.
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
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CommerceTransactionSettings"/> object.</returns>
        public CommerceTransactionSettings Clone() => new CommerceTransactionSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CommerceTransactionClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CommerceTransactionClientBuilder : gaxgrpc::ClientBuilderBase<CommerceTransactionClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CommerceTransactionSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CommerceTransactionClientBuilder() : base(CommerceTransactionClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CommerceTransactionClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CommerceTransactionClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CommerceTransactionClient Build()
        {
            CommerceTransactionClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CommerceTransactionClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CommerceTransactionClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CommerceTransactionClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CommerceTransactionClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CommerceTransactionClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CommerceTransactionClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CommerceTransactionClient.ChannelPool;
    }

    /// <summary>CommerceTransaction client wrapper, for convenient use.</summary>
    /// <remarks>
    /// APIs related to managing resources that model commercial transactions.
    /// </remarks>
    public abstract partial class CommerceTransactionClient
    {
        /// <summary>
        /// The default endpoint for the CommerceTransaction service, which is a host of
        /// "commerceproducer.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "commerceproducer.googleapis.com:443";

        /// <summary>The default CommerceTransaction scopes.</summary>
        /// <remarks>
        /// The default CommerceTransaction scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CommerceTransaction.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CommerceTransactionClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CommerceTransactionClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CommerceTransactionClient"/>.</returns>
        public static stt::Task<CommerceTransactionClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CommerceTransactionClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CommerceTransactionClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CommerceTransactionClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CommerceTransactionClient"/>.</returns>
        public static CommerceTransactionClient Create() => new CommerceTransactionClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CommerceTransactionClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CommerceTransactionSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CommerceTransactionClient"/>.</returns>
        internal static CommerceTransactionClient Create(grpccore::CallInvoker callInvoker, CommerceTransactionSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CommerceTransaction.CommerceTransactionClient grpcClient = new CommerceTransaction.CommerceTransactionClient(callInvoker);
            return new CommerceTransactionClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CommerceTransaction client</summary>
        public virtual CommerceTransaction.CommerceTransactionClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListServicesRequest
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListServicesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListServicesRequest
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
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListServicesResponse, Service> ListServices(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServices(request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListServicesRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListServicesRequest request = new ListServicesRequest
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
            return ListServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(GetServiceRequest request, st::CancellationToken cancellationToken) =>
            GetServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Service GetService(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetService(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetServiceAsync(new GetServiceRequest
            {
                ServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Service> GetServiceAsync(ServiceName name, st::CancellationToken cancellationToken) =>
            GetServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists PrivateOffers for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateOffersResponse, PrivateOffer> ListPrivateOffers(ListPrivateOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PrivateOffers for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateOffersResponse, PrivateOffer> ListPrivateOffersAsync(ListPrivateOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PrivateOffers for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPrivateOffersRequest
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
        /// <returns>A pageable sequence of <see cref="PrivateOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateOffersResponse, PrivateOffer> ListPrivateOffers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateOffersRequest request = new ListPrivateOffersRequest
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
            return ListPrivateOffers(request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOffers for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPrivateOffersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateOffersResponse, PrivateOffer> ListPrivateOffersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateOffersRequest request = new ListPrivateOffersRequest
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
            return ListPrivateOffersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOffers for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPrivateOffersRequest
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
        /// <returns>A pageable sequence of <see cref="PrivateOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateOffersResponse, PrivateOffer> ListPrivateOffers(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateOffersRequest request = new ListPrivateOffersRequest
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
            return ListPrivateOffers(request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOffers for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPrivateOffersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateOffersResponse, PrivateOffer> ListPrivateOffersAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateOffersRequest request = new ListPrivateOffersRequest
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
            return ListPrivateOffersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer GetPrivateOffer(GetPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> GetPrivateOfferAsync(GetPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> GetPrivateOfferAsync(GetPrivateOfferRequest request, st::CancellationToken cancellationToken) =>
            GetPrivateOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer GetPrivateOffer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateOffer(new GetPrivateOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> GetPrivateOfferAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateOfferAsync(new GetPrivateOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> GetPrivateOfferAsync(string name, st::CancellationToken cancellationToken) =>
            GetPrivateOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer GetPrivateOffer(PrivateOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateOffer(new GetPrivateOfferRequest
            {
                PrivateOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> GetPrivateOfferAsync(PrivateOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateOfferAsync(new GetPrivateOfferRequest
            {
                PrivateOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> GetPrivateOfferAsync(PrivateOfferName name, st::CancellationToken cancellationToken) =>
            GetPrivateOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveAmendmentTargetResponse ResolveAmendmentTarget(ResolveAmendmentTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveAmendmentTargetResponse> ResolveAmendmentTargetAsync(ResolveAmendmentTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveAmendmentTargetResponse> ResolveAmendmentTargetAsync(ResolveAmendmentTargetRequest request, st::CancellationToken cancellationToken) =>
            ResolveAmendmentTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveAmendmentTargetRequest
        /// </param>
        /// <param name="targetBillingAccount">
        /// Required. The customer's billing account targeted by the offer. This is the
        /// billing account for which the new private offer will be created on. Format:
        /// billingAccounts/{billing_account}.
        /// </param>
        /// <param name="baseStandardOffer">
        /// Required. The base standard offer that the private offer will be based on.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveAmendmentTargetResponse ResolveAmendmentTarget(string parent, string targetBillingAccount, string baseStandardOffer, gaxgrpc::CallSettings callSettings = null) =>
            ResolveAmendmentTarget(new ResolveAmendmentTargetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetBillingAccount = gax::GaxPreconditions.CheckNotNullOrEmpty(targetBillingAccount, nameof(targetBillingAccount)),
                BaseStandardOffer = gax::GaxPreconditions.CheckNotNullOrEmpty(baseStandardOffer, nameof(baseStandardOffer)),
            }, callSettings);

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveAmendmentTargetRequest
        /// </param>
        /// <param name="targetBillingAccount">
        /// Required. The customer's billing account targeted by the offer. This is the
        /// billing account for which the new private offer will be created on. Format:
        /// billingAccounts/{billing_account}.
        /// </param>
        /// <param name="baseStandardOffer">
        /// Required. The base standard offer that the private offer will be based on.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveAmendmentTargetResponse> ResolveAmendmentTargetAsync(string parent, string targetBillingAccount, string baseStandardOffer, gaxgrpc::CallSettings callSettings = null) =>
            ResolveAmendmentTargetAsync(new ResolveAmendmentTargetRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TargetBillingAccount = gax::GaxPreconditions.CheckNotNullOrEmpty(targetBillingAccount, nameof(targetBillingAccount)),
                BaseStandardOffer = gax::GaxPreconditions.CheckNotNullOrEmpty(baseStandardOffer, nameof(baseStandardOffer)),
            }, callSettings);

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveAmendmentTargetRequest
        /// </param>
        /// <param name="targetBillingAccount">
        /// Required. The customer's billing account targeted by the offer. This is the
        /// billing account for which the new private offer will be created on. Format:
        /// billingAccounts/{billing_account}.
        /// </param>
        /// <param name="baseStandardOffer">
        /// Required. The base standard offer that the private offer will be based on.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveAmendmentTargetResponse> ResolveAmendmentTargetAsync(string parent, string targetBillingAccount, string baseStandardOffer, st::CancellationToken cancellationToken) =>
            ResolveAmendmentTargetAsync(parent, targetBillingAccount, baseStandardOffer, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveAmendmentTargetRequest
        /// </param>
        /// <param name="targetBillingAccount">
        /// Required. The customer's billing account targeted by the offer. This is the
        /// billing account for which the new private offer will be created on. Format:
        /// billingAccounts/{billing_account}.
        /// </param>
        /// <param name="baseStandardOffer">
        /// Required. The base standard offer that the private offer will be based on.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResolveAmendmentTargetResponse ResolveAmendmentTarget(gagr::LocationName parent, gagr::BillingAccountName targetBillingAccount, StandardOfferName baseStandardOffer, gaxgrpc::CallSettings callSettings = null) =>
            ResolveAmendmentTarget(new ResolveAmendmentTargetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetBillingAccountAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(targetBillingAccount, nameof(targetBillingAccount)),
                BaseStandardOfferAsStandardOfferName = gax::GaxPreconditions.CheckNotNull(baseStandardOffer, nameof(baseStandardOffer)),
            }, callSettings);

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveAmendmentTargetRequest
        /// </param>
        /// <param name="targetBillingAccount">
        /// Required. The customer's billing account targeted by the offer. This is the
        /// billing account for which the new private offer will be created on. Format:
        /// billingAccounts/{billing_account}.
        /// </param>
        /// <param name="baseStandardOffer">
        /// Required. The base standard offer that the private offer will be based on.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveAmendmentTargetResponse> ResolveAmendmentTargetAsync(gagr::LocationName parent, gagr::BillingAccountName targetBillingAccount, StandardOfferName baseStandardOffer, gaxgrpc::CallSettings callSettings = null) =>
            ResolveAmendmentTargetAsync(new ResolveAmendmentTargetRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TargetBillingAccountAsBillingAccountName = gax::GaxPreconditions.CheckNotNull(targetBillingAccount, nameof(targetBillingAccount)),
                BaseStandardOfferAsStandardOfferName = gax::GaxPreconditions.CheckNotNull(baseStandardOffer, nameof(baseStandardOffer)),
            }, callSettings);

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ResolveAmendmentTargetRequest
        /// </param>
        /// <param name="targetBillingAccount">
        /// Required. The customer's billing account targeted by the offer. This is the
        /// billing account for which the new private offer will be created on. Format:
        /// billingAccounts/{billing_account}.
        /// </param>
        /// <param name="baseStandardOffer">
        /// Required. The base standard offer that the private offer will be based on.
        /// Format:
        /// projects/{project}/locations/{location}/services/{service}/standardOffers/{standard_offer}.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResolveAmendmentTargetResponse> ResolveAmendmentTargetAsync(gagr::LocationName parent, gagr::BillingAccountName targetBillingAccount, StandardOfferName baseStandardOffer, st::CancellationToken cancellationToken) =>
            ResolveAmendmentTargetAsync(parent, targetBillingAccount, baseStandardOffer, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new PrivateOffer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer CreatePrivateOffer(CreatePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new PrivateOffer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> CreatePrivateOfferAsync(CreatePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new PrivateOffer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> CreatePrivateOfferAsync(CreatePrivateOfferRequest request, st::CancellationToken cancellationToken) =>
            CreatePrivateOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer UpdatePrivateOffer(UpdatePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> UpdatePrivateOfferAsync(UpdatePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> UpdatePrivateOfferAsync(UpdatePrivateOfferRequest request, st::CancellationToken cancellationToken) =>
            UpdatePrivateOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the target PrivateOffer.
        /// </summary>
        /// <param name="privateOffer">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// If unspecified, all fields present in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer UpdatePrivateOffer(PrivateOffer privateOffer, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateOffer(new UpdatePrivateOfferRequest
            {
                UpdateMask = updateMask,
                PrivateOffer = gax::GaxPreconditions.CheckNotNull(privateOffer, nameof(privateOffer)),
            }, callSettings);

        /// <summary>
        /// Updates the target PrivateOffer.
        /// </summary>
        /// <param name="privateOffer">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// If unspecified, all fields present in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> UpdatePrivateOfferAsync(PrivateOffer privateOffer, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateOfferAsync(new UpdatePrivateOfferRequest
            {
                UpdateMask = updateMask,
                PrivateOffer = gax::GaxPreconditions.CheckNotNull(privateOffer, nameof(privateOffer)),
            }, callSettings);

        /// <summary>
        /// Updates the target PrivateOffer.
        /// </summary>
        /// <param name="privateOffer">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// If unspecified, all fields present in the request will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> UpdatePrivateOfferAsync(PrivateOffer privateOffer, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePrivateOfferAsync(privateOffer, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer PublishPrivateOffer(PublishPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> PublishPrivateOfferAsync(PublishPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> PublishPrivateOfferAsync(PublishPrivateOfferRequest request, st::CancellationToken cancellationToken) =>
            PublishPrivateOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer PublishPrivateOffer(string name, gaxgrpc::CallSettings callSettings = null) =>
            PublishPrivateOffer(new PublishPrivateOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> PublishPrivateOfferAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            PublishPrivateOfferAsync(new PublishPrivateOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> PublishPrivateOfferAsync(string name, st::CancellationToken cancellationToken) =>
            PublishPrivateOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer PublishPrivateOffer(PrivateOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            PublishPrivateOffer(new PublishPrivateOfferRequest
            {
                PrivateOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> PublishPrivateOfferAsync(PrivateOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            PublishPrivateOfferAsync(new PublishPrivateOfferRequest
            {
                PrivateOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> PublishPrivateOfferAsync(PrivateOfferName name, st::CancellationToken cancellationToken) =>
            PublishPrivateOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer CancelPrivateOffer(CancelPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> CancelPrivateOfferAsync(CancelPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> CancelPrivateOfferAsync(CancelPrivateOfferRequest request, st::CancellationToken cancellationToken) =>
            CancelPrivateOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer CancelPrivateOffer(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelPrivateOffer(new CancelPrivateOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> CancelPrivateOfferAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            CancelPrivateOfferAsync(new CancelPrivateOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> CancelPrivateOfferAsync(string name, st::CancellationToken cancellationToken) =>
            CancelPrivateOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOffer CancelPrivateOffer(PrivateOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelPrivateOffer(new CancelPrivateOfferRequest
            {
                PrivateOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> CancelPrivateOfferAsync(PrivateOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            CancelPrivateOfferAsync(new CancelPrivateOfferRequest
            {
                PrivateOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOffer> CancelPrivateOfferAsync(PrivateOfferName name, st::CancellationToken cancellationToken) =>
            CancelPrivateOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePrivateOffer(DeletePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferAsync(DeletePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferAsync(DeletePrivateOfferRequest request, st::CancellationToken cancellationToken) =>
            DeletePrivateOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePrivateOffer(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateOffer(new DeletePrivateOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateOfferAsync(new DeletePrivateOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePrivateOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePrivateOffer(PrivateOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateOffer(new DeletePrivateOfferRequest
            {
                PrivateOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferAsync(PrivateOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateOfferAsync(new DeletePrivateOfferRequest
            {
                PrivateOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferAsync(PrivateOfferName name, st::CancellationToken cancellationToken) =>
            DeletePrivateOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists PrivateOfferDocuments for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateOfferDocument"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> ListPrivateOfferDocuments(ListPrivateOfferDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PrivateOfferDocuments for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateOfferDocument"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> ListPrivateOfferDocumentsAsync(ListPrivateOfferDocumentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists PrivateOfferDocuments for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPrivateOfferDocumentsRequest.
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
        /// <returns>A pageable sequence of <see cref="PrivateOfferDocument"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> ListPrivateOfferDocuments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateOfferDocumentsRequest request = new ListPrivateOfferDocumentsRequest
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
            return ListPrivateOfferDocuments(request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOfferDocuments for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPrivateOfferDocumentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateOfferDocument"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> ListPrivateOfferDocumentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateOfferDocumentsRequest request = new ListPrivateOfferDocumentsRequest
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
            return ListPrivateOfferDocumentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOfferDocuments for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPrivateOfferDocumentsRequest.
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
        /// <returns>A pageable sequence of <see cref="PrivateOfferDocument"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> ListPrivateOfferDocuments(PrivateOfferName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateOfferDocumentsRequest request = new ListPrivateOfferDocumentsRequest
            {
                ParentAsPrivateOfferName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPrivateOfferDocuments(request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOfferDocuments for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListPrivateOfferDocumentsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateOfferDocument"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> ListPrivateOfferDocumentsAsync(PrivateOfferName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPrivateOfferDocumentsRequest request = new ListPrivateOfferDocumentsRequest
            {
                ParentAsPrivateOfferName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListPrivateOfferDocumentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOfferDocument GetPrivateOfferDocument(GetPrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> GetPrivateOfferDocumentAsync(GetPrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> GetPrivateOfferDocumentAsync(GetPrivateOfferDocumentRequest request, st::CancellationToken cancellationToken) =>
            GetPrivateOfferDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOfferDocument GetPrivateOfferDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateOfferDocument(new GetPrivateOfferDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> GetPrivateOfferDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateOfferDocumentAsync(new GetPrivateOfferDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> GetPrivateOfferDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            GetPrivateOfferDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOfferDocument GetPrivateOfferDocument(PrivateOfferDocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateOfferDocument(new GetPrivateOfferDocumentRequest
            {
                PrivateOfferDocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> GetPrivateOfferDocumentAsync(PrivateOfferDocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPrivateOfferDocumentAsync(new GetPrivateOfferDocumentRequest
            {
                PrivateOfferDocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> GetPrivateOfferDocumentAsync(PrivateOfferDocumentName name, st::CancellationToken cancellationToken) =>
            GetPrivateOfferDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new PrivateOfferDocument in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOfferDocument CreatePrivateOfferDocument(CreatePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new PrivateOfferDocument in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> CreatePrivateOfferDocumentAsync(CreatePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new PrivateOfferDocument in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> CreatePrivateOfferDocumentAsync(CreatePrivateOfferDocumentRequest request, st::CancellationToken cancellationToken) =>
            CreatePrivateOfferDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOfferDocument UpdatePrivateOfferDocument(UpdatePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> UpdatePrivateOfferDocumentAsync(UpdatePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> UpdatePrivateOfferDocumentAsync(UpdatePrivateOfferDocumentRequest request, st::CancellationToken cancellationToken) =>
            UpdatePrivateOfferDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the target PrivateOfferDocument.
        /// </summary>
        /// <param name="privateOfferDocument">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// If unspecified, all fields present in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual PrivateOfferDocument UpdatePrivateOfferDocument(PrivateOfferDocument privateOfferDocument, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateOfferDocument(new UpdatePrivateOfferDocumentRequest
            {
                PrivateOfferDocument = gax::GaxPreconditions.CheckNotNull(privateOfferDocument, nameof(privateOfferDocument)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the target PrivateOfferDocument.
        /// </summary>
        /// <param name="privateOfferDocument">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// If unspecified, all fields present in the request will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> UpdatePrivateOfferDocumentAsync(PrivateOfferDocument privateOfferDocument, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdatePrivateOfferDocumentAsync(new UpdatePrivateOfferDocumentRequest
            {
                PrivateOfferDocument = gax::GaxPreconditions.CheckNotNull(privateOfferDocument, nameof(privateOfferDocument)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates the target PrivateOfferDocument.
        /// </summary>
        /// <param name="privateOfferDocument">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask.
        /// The special value "*" means full replacement.
        /// If unspecified, all fields present in the request will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<PrivateOfferDocument> UpdatePrivateOfferDocumentAsync(PrivateOfferDocument privateOfferDocument, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdatePrivateOfferDocumentAsync(privateOfferDocument, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePrivateOfferDocument(DeletePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferDocumentAsync(DeletePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferDocumentAsync(DeletePrivateOfferDocumentRequest request, st::CancellationToken cancellationToken) =>
            DeletePrivateOfferDocumentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePrivateOfferDocument(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateOfferDocument(new DeletePrivateOfferDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferDocumentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateOfferDocumentAsync(new DeletePrivateOfferDocumentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferDocumentAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePrivateOfferDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeletePrivateOfferDocument(PrivateOfferDocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateOfferDocument(new DeletePrivateOfferDocumentRequest
            {
                PrivateOfferDocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferDocumentAsync(PrivateOfferDocumentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePrivateOfferDocumentAsync(new DeletePrivateOfferDocumentRequest
            {
                PrivateOfferDocumentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeletePrivateOfferDocumentAsync(PrivateOfferDocumentName name, st::CancellationToken cancellationToken) =>
            DeletePrivateOfferDocumentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists StandardOffers for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StandardOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStandardOffersResponse, StandardOffer> ListStandardOffers(ListStandardOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists StandardOffers for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StandardOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStandardOffersResponse, StandardOffer> ListStandardOffersAsync(ListStandardOffersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists StandardOffers for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListStandardOffersRequest
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
        /// <returns>A pageable sequence of <see cref="StandardOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStandardOffersResponse, StandardOffer> ListStandardOffers(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStandardOffersRequest request = new ListStandardOffersRequest
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
            return ListStandardOffers(request, callSettings);
        }

        /// <summary>
        /// Lists StandardOffers for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListStandardOffersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="StandardOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStandardOffersResponse, StandardOffer> ListStandardOffersAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStandardOffersRequest request = new ListStandardOffersRequest
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
            return ListStandardOffersAsync(request, callSettings);
        }

        /// <summary>
        /// Lists StandardOffers for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListStandardOffersRequest
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
        /// <returns>A pageable sequence of <see cref="StandardOffer"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListStandardOffersResponse, StandardOffer> ListStandardOffers(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStandardOffersRequest request = new ListStandardOffersRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStandardOffers(request, callSettings);
        }

        /// <summary>
        /// Lists StandardOffers for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListStandardOffersRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="StandardOffer"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListStandardOffersResponse, StandardOffer> ListStandardOffersAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListStandardOffersRequest request = new ListStandardOffersRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListStandardOffersAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StandardOffer GetStandardOffer(GetStandardOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StandardOffer> GetStandardOfferAsync(GetStandardOfferRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StandardOffer> GetStandardOfferAsync(GetStandardOfferRequest request, st::CancellationToken cancellationToken) =>
            GetStandardOfferAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StandardOffer GetStandardOffer(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStandardOffer(new GetStandardOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StandardOffer> GetStandardOfferAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetStandardOfferAsync(new GetStandardOfferRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StandardOffer> GetStandardOfferAsync(string name, st::CancellationToken cancellationToken) =>
            GetStandardOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual StandardOffer GetStandardOffer(StandardOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStandardOffer(new GetStandardOfferRequest
            {
                StandardOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StandardOffer> GetStandardOfferAsync(StandardOfferName name, gaxgrpc::CallSettings callSettings = null) =>
            GetStandardOfferAsync(new GetStandardOfferRequest
            {
                StandardOfferName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<StandardOffer> GetStandardOfferAsync(StandardOfferName name, st::CancellationToken cancellationToken) =>
            GetStandardOfferAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Sku GetSku(GetSkuRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(GetSkuRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(GetSkuRequest request, st::CancellationToken cancellationToken) =>
            GetSkuAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Sku GetSku(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSku(new GetSkuRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkuAsync(new GetSkuRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(string name, st::CancellationToken cancellationToken) =>
            GetSkuAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Sku GetSku(SkuName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSku(new GetSkuRequest
            {
                SkuName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(SkuName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkuAsync(new GetSkuRequest
            {
                SkuName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Sku.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Sku> GetSkuAsync(SkuName name, st::CancellationToken cancellationToken) =>
            GetSkuAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Skus for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Skus for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Sku"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(ListSkusRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Skus for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkusRequest
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
        /// Lists Skus for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkusRequest
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
        /// Lists Skus for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkusRequest
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
        public virtual gax::PagedEnumerable<ListSkusResponse, Sku> ListSkus(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Lists Skus for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkusRequest
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
        public virtual gax::PagedAsyncEnumerable<ListSkusResponse, Sku> ListSkusAsync(ServiceName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkusRequest request = new ListSkusRequest
            {
                ParentAsServiceName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
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
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkuGroup GetSkuGroup(GetSkuGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkuGroup> GetSkuGroupAsync(GetSkuGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkuGroup> GetSkuGroupAsync(GetSkuGroupRequest request, st::CancellationToken cancellationToken) =>
            GetSkuGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkuGroup GetSkuGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkuGroup(new GetSkuGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkuGroup> GetSkuGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkuGroupAsync(new GetSkuGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkuGroup> GetSkuGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetSkuGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SkuGroup GetSkuGroup(SkuGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkuGroup(new GetSkuGroupRequest
            {
                SkuGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkuGroup> GetSkuGroupAsync(SkuGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSkuGroupAsync(new GetSkuGroupRequest
            {
                SkuGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SkuGroup> GetSkuGroupAsync(SkuGroupName name, st::CancellationToken cancellationToken) =>
            GetSkuGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists SkuGroups for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SkuGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroups(ListSkuGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SkuGroups for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SkuGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroupsAsync(ListSkuGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists SkuGroups for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkuGroupsRequest
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
        /// Lists SkuGroups for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkuGroupsRequest
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
        /// Lists SkuGroups for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkuGroupsRequest
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
        public virtual gax::PagedEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkuGroupsRequest request = new ListSkuGroupsRequest
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
            return ListSkuGroups(request, callSettings);
        }

        /// <summary>
        /// Lists SkuGroups for the given parent.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListSkuGroupsRequest
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
        public virtual gax::PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSkuGroupsRequest request = new ListSkuGroupsRequest
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
            return ListSkuGroupsAsync(request, callSettings);
        }
    }

    /// <summary>CommerceTransaction client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// APIs related to managing resources that model commercial transactions.
    /// </remarks>
    public sealed partial class CommerceTransactionClientImpl : CommerceTransactionClient
    {
        private readonly gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> _callListServices;

        private readonly gaxgrpc::ApiCall<GetServiceRequest, Service> _callGetService;

        private readonly gaxgrpc::ApiCall<ListPrivateOffersRequest, ListPrivateOffersResponse> _callListPrivateOffers;

        private readonly gaxgrpc::ApiCall<GetPrivateOfferRequest, PrivateOffer> _callGetPrivateOffer;

        private readonly gaxgrpc::ApiCall<ResolveAmendmentTargetRequest, ResolveAmendmentTargetResponse> _callResolveAmendmentTarget;

        private readonly gaxgrpc::ApiCall<CreatePrivateOfferRequest, PrivateOffer> _callCreatePrivateOffer;

        private readonly gaxgrpc::ApiCall<UpdatePrivateOfferRequest, PrivateOffer> _callUpdatePrivateOffer;

        private readonly gaxgrpc::ApiCall<PublishPrivateOfferRequest, PrivateOffer> _callPublishPrivateOffer;

        private readonly gaxgrpc::ApiCall<CancelPrivateOfferRequest, PrivateOffer> _callCancelPrivateOffer;

        private readonly gaxgrpc::ApiCall<DeletePrivateOfferRequest, wkt::Empty> _callDeletePrivateOffer;

        private readonly gaxgrpc::ApiCall<ListPrivateOfferDocumentsRequest, ListPrivateOfferDocumentsResponse> _callListPrivateOfferDocuments;

        private readonly gaxgrpc::ApiCall<GetPrivateOfferDocumentRequest, PrivateOfferDocument> _callGetPrivateOfferDocument;

        private readonly gaxgrpc::ApiCall<CreatePrivateOfferDocumentRequest, PrivateOfferDocument> _callCreatePrivateOfferDocument;

        private readonly gaxgrpc::ApiCall<UpdatePrivateOfferDocumentRequest, PrivateOfferDocument> _callUpdatePrivateOfferDocument;

        private readonly gaxgrpc::ApiCall<DeletePrivateOfferDocumentRequest, wkt::Empty> _callDeletePrivateOfferDocument;

        private readonly gaxgrpc::ApiCall<ListStandardOffersRequest, ListStandardOffersResponse> _callListStandardOffers;

        private readonly gaxgrpc::ApiCall<GetStandardOfferRequest, StandardOffer> _callGetStandardOffer;

        private readonly gaxgrpc::ApiCall<GetSkuRequest, Sku> _callGetSku;

        private readonly gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> _callListSkus;

        private readonly gaxgrpc::ApiCall<GetSkuGroupRequest, SkuGroup> _callGetSkuGroup;

        private readonly gaxgrpc::ApiCall<ListSkuGroupsRequest, ListSkuGroupsResponse> _callListSkuGroups;

        /// <summary>
        /// Constructs a client wrapper for the CommerceTransaction service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CommerceTransactionSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CommerceTransactionClientImpl(CommerceTransaction.CommerceTransactionClient grpcClient, CommerceTransactionSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CommerceTransactionSettings effectiveSettings = settings ?? CommerceTransactionSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListServices = clientHelper.BuildApiCall<ListServicesRequest, ListServicesResponse>("ListServices", grpcClient.ListServicesAsync, grpcClient.ListServices, effectiveSettings.ListServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListServices);
            Modify_ListServicesApiCall(ref _callListServices);
            _callGetService = clientHelper.BuildApiCall<GetServiceRequest, Service>("GetService", grpcClient.GetServiceAsync, grpcClient.GetService, effectiveSettings.GetServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetService);
            Modify_GetServiceApiCall(ref _callGetService);
            _callListPrivateOffers = clientHelper.BuildApiCall<ListPrivateOffersRequest, ListPrivateOffersResponse>("ListPrivateOffers", grpcClient.ListPrivateOffersAsync, grpcClient.ListPrivateOffers, effectiveSettings.ListPrivateOffersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrivateOffers);
            Modify_ListPrivateOffersApiCall(ref _callListPrivateOffers);
            _callGetPrivateOffer = clientHelper.BuildApiCall<GetPrivateOfferRequest, PrivateOffer>("GetPrivateOffer", grpcClient.GetPrivateOfferAsync, grpcClient.GetPrivateOffer, effectiveSettings.GetPrivateOfferSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPrivateOffer);
            Modify_GetPrivateOfferApiCall(ref _callGetPrivateOffer);
            _callResolveAmendmentTarget = clientHelper.BuildApiCall<ResolveAmendmentTargetRequest, ResolveAmendmentTargetResponse>("ResolveAmendmentTarget", grpcClient.ResolveAmendmentTargetAsync, grpcClient.ResolveAmendmentTarget, effectiveSettings.ResolveAmendmentTargetSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callResolveAmendmentTarget);
            Modify_ResolveAmendmentTargetApiCall(ref _callResolveAmendmentTarget);
            _callCreatePrivateOffer = clientHelper.BuildApiCall<CreatePrivateOfferRequest, PrivateOffer>("CreatePrivateOffer", grpcClient.CreatePrivateOfferAsync, grpcClient.CreatePrivateOffer, effectiveSettings.CreatePrivateOfferSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePrivateOffer);
            Modify_CreatePrivateOfferApiCall(ref _callCreatePrivateOffer);
            _callUpdatePrivateOffer = clientHelper.BuildApiCall<UpdatePrivateOfferRequest, PrivateOffer>("UpdatePrivateOffer", grpcClient.UpdatePrivateOfferAsync, grpcClient.UpdatePrivateOffer, effectiveSettings.UpdatePrivateOfferSettings).WithGoogleRequestParam("private_offer.name", request => request.PrivateOffer?.Name);
            Modify_ApiCall(ref _callUpdatePrivateOffer);
            Modify_UpdatePrivateOfferApiCall(ref _callUpdatePrivateOffer);
            _callPublishPrivateOffer = clientHelper.BuildApiCall<PublishPrivateOfferRequest, PrivateOffer>("PublishPrivateOffer", grpcClient.PublishPrivateOfferAsync, grpcClient.PublishPrivateOffer, effectiveSettings.PublishPrivateOfferSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callPublishPrivateOffer);
            Modify_PublishPrivateOfferApiCall(ref _callPublishPrivateOffer);
            _callCancelPrivateOffer = clientHelper.BuildApiCall<CancelPrivateOfferRequest, PrivateOffer>("CancelPrivateOffer", grpcClient.CancelPrivateOfferAsync, grpcClient.CancelPrivateOffer, effectiveSettings.CancelPrivateOfferSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callCancelPrivateOffer);
            Modify_CancelPrivateOfferApiCall(ref _callCancelPrivateOffer);
            _callDeletePrivateOffer = clientHelper.BuildApiCall<DeletePrivateOfferRequest, wkt::Empty>("DeletePrivateOffer", grpcClient.DeletePrivateOfferAsync, grpcClient.DeletePrivateOffer, effectiveSettings.DeletePrivateOfferSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePrivateOffer);
            Modify_DeletePrivateOfferApiCall(ref _callDeletePrivateOffer);
            _callListPrivateOfferDocuments = clientHelper.BuildApiCall<ListPrivateOfferDocumentsRequest, ListPrivateOfferDocumentsResponse>("ListPrivateOfferDocuments", grpcClient.ListPrivateOfferDocumentsAsync, grpcClient.ListPrivateOfferDocuments, effectiveSettings.ListPrivateOfferDocumentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPrivateOfferDocuments);
            Modify_ListPrivateOfferDocumentsApiCall(ref _callListPrivateOfferDocuments);
            _callGetPrivateOfferDocument = clientHelper.BuildApiCall<GetPrivateOfferDocumentRequest, PrivateOfferDocument>("GetPrivateOfferDocument", grpcClient.GetPrivateOfferDocumentAsync, grpcClient.GetPrivateOfferDocument, effectiveSettings.GetPrivateOfferDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPrivateOfferDocument);
            Modify_GetPrivateOfferDocumentApiCall(ref _callGetPrivateOfferDocument);
            _callCreatePrivateOfferDocument = clientHelper.BuildApiCall<CreatePrivateOfferDocumentRequest, PrivateOfferDocument>("CreatePrivateOfferDocument", grpcClient.CreatePrivateOfferDocumentAsync, grpcClient.CreatePrivateOfferDocument, effectiveSettings.CreatePrivateOfferDocumentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePrivateOfferDocument);
            Modify_CreatePrivateOfferDocumentApiCall(ref _callCreatePrivateOfferDocument);
            _callUpdatePrivateOfferDocument = clientHelper.BuildApiCall<UpdatePrivateOfferDocumentRequest, PrivateOfferDocument>("UpdatePrivateOfferDocument", grpcClient.UpdatePrivateOfferDocumentAsync, grpcClient.UpdatePrivateOfferDocument, effectiveSettings.UpdatePrivateOfferDocumentSettings).WithGoogleRequestParam("private_offer_document.name", request => request.PrivateOfferDocument?.Name);
            Modify_ApiCall(ref _callUpdatePrivateOfferDocument);
            Modify_UpdatePrivateOfferDocumentApiCall(ref _callUpdatePrivateOfferDocument);
            _callDeletePrivateOfferDocument = clientHelper.BuildApiCall<DeletePrivateOfferDocumentRequest, wkt::Empty>("DeletePrivateOfferDocument", grpcClient.DeletePrivateOfferDocumentAsync, grpcClient.DeletePrivateOfferDocument, effectiveSettings.DeletePrivateOfferDocumentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePrivateOfferDocument);
            Modify_DeletePrivateOfferDocumentApiCall(ref _callDeletePrivateOfferDocument);
            _callListStandardOffers = clientHelper.BuildApiCall<ListStandardOffersRequest, ListStandardOffersResponse>("ListStandardOffers", grpcClient.ListStandardOffersAsync, grpcClient.ListStandardOffers, effectiveSettings.ListStandardOffersSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListStandardOffers);
            Modify_ListStandardOffersApiCall(ref _callListStandardOffers);
            _callGetStandardOffer = clientHelper.BuildApiCall<GetStandardOfferRequest, StandardOffer>("GetStandardOffer", grpcClient.GetStandardOfferAsync, grpcClient.GetStandardOffer, effectiveSettings.GetStandardOfferSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetStandardOffer);
            Modify_GetStandardOfferApiCall(ref _callGetStandardOffer);
            _callGetSku = clientHelper.BuildApiCall<GetSkuRequest, Sku>("GetSku", grpcClient.GetSkuAsync, grpcClient.GetSku, effectiveSettings.GetSkuSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSku);
            Modify_GetSkuApiCall(ref _callGetSku);
            _callListSkus = clientHelper.BuildApiCall<ListSkusRequest, ListSkusResponse>("ListSkus", grpcClient.ListSkusAsync, grpcClient.ListSkus, effectiveSettings.ListSkusSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkus);
            Modify_ListSkusApiCall(ref _callListSkus);
            _callGetSkuGroup = clientHelper.BuildApiCall<GetSkuGroupRequest, SkuGroup>("GetSkuGroup", grpcClient.GetSkuGroupAsync, grpcClient.GetSkuGroup, effectiveSettings.GetSkuGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSkuGroup);
            Modify_GetSkuGroupApiCall(ref _callGetSkuGroup);
            _callListSkuGroups = clientHelper.BuildApiCall<ListSkuGroupsRequest, ListSkuGroupsResponse>("ListSkuGroups", grpcClient.ListSkuGroupsAsync, grpcClient.ListSkuGroups, effectiveSettings.ListSkuGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSkuGroups);
            Modify_ListSkuGroupsApiCall(ref _callListSkuGroups);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListServicesApiCall(ref gaxgrpc::ApiCall<ListServicesRequest, ListServicesResponse> call);

        partial void Modify_GetServiceApiCall(ref gaxgrpc::ApiCall<GetServiceRequest, Service> call);

        partial void Modify_ListPrivateOffersApiCall(ref gaxgrpc::ApiCall<ListPrivateOffersRequest, ListPrivateOffersResponse> call);

        partial void Modify_GetPrivateOfferApiCall(ref gaxgrpc::ApiCall<GetPrivateOfferRequest, PrivateOffer> call);

        partial void Modify_ResolveAmendmentTargetApiCall(ref gaxgrpc::ApiCall<ResolveAmendmentTargetRequest, ResolveAmendmentTargetResponse> call);

        partial void Modify_CreatePrivateOfferApiCall(ref gaxgrpc::ApiCall<CreatePrivateOfferRequest, PrivateOffer> call);

        partial void Modify_UpdatePrivateOfferApiCall(ref gaxgrpc::ApiCall<UpdatePrivateOfferRequest, PrivateOffer> call);

        partial void Modify_PublishPrivateOfferApiCall(ref gaxgrpc::ApiCall<PublishPrivateOfferRequest, PrivateOffer> call);

        partial void Modify_CancelPrivateOfferApiCall(ref gaxgrpc::ApiCall<CancelPrivateOfferRequest, PrivateOffer> call);

        partial void Modify_DeletePrivateOfferApiCall(ref gaxgrpc::ApiCall<DeletePrivateOfferRequest, wkt::Empty> call);

        partial void Modify_ListPrivateOfferDocumentsApiCall(ref gaxgrpc::ApiCall<ListPrivateOfferDocumentsRequest, ListPrivateOfferDocumentsResponse> call);

        partial void Modify_GetPrivateOfferDocumentApiCall(ref gaxgrpc::ApiCall<GetPrivateOfferDocumentRequest, PrivateOfferDocument> call);

        partial void Modify_CreatePrivateOfferDocumentApiCall(ref gaxgrpc::ApiCall<CreatePrivateOfferDocumentRequest, PrivateOfferDocument> call);

        partial void Modify_UpdatePrivateOfferDocumentApiCall(ref gaxgrpc::ApiCall<UpdatePrivateOfferDocumentRequest, PrivateOfferDocument> call);

        partial void Modify_DeletePrivateOfferDocumentApiCall(ref gaxgrpc::ApiCall<DeletePrivateOfferDocumentRequest, wkt::Empty> call);

        partial void Modify_ListStandardOffersApiCall(ref gaxgrpc::ApiCall<ListStandardOffersRequest, ListStandardOffersResponse> call);

        partial void Modify_GetStandardOfferApiCall(ref gaxgrpc::ApiCall<GetStandardOfferRequest, StandardOffer> call);

        partial void Modify_GetSkuApiCall(ref gaxgrpc::ApiCall<GetSkuRequest, Sku> call);

        partial void Modify_ListSkusApiCall(ref gaxgrpc::ApiCall<ListSkusRequest, ListSkusResponse> call);

        partial void Modify_GetSkuGroupApiCall(ref gaxgrpc::ApiCall<GetSkuGroupRequest, SkuGroup> call);

        partial void Modify_ListSkuGroupsApiCall(ref gaxgrpc::ApiCall<ListSkuGroupsRequest, ListSkuGroupsResponse> call);

        partial void OnConstruction(CommerceTransaction.CommerceTransactionClient grpcClient, CommerceTransactionSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CommerceTransaction client</summary>
        public override CommerceTransaction.CommerceTransactionClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListServicesRequest(ref ListServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetServiceRequest(ref GetServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPrivateOffersRequest(ref ListPrivateOffersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPrivateOfferRequest(ref GetPrivateOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResolveAmendmentTargetRequest(ref ResolveAmendmentTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePrivateOfferRequest(ref CreatePrivateOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePrivateOfferRequest(ref UpdatePrivateOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PublishPrivateOfferRequest(ref PublishPrivateOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CancelPrivateOfferRequest(ref CancelPrivateOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePrivateOfferRequest(ref DeletePrivateOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPrivateOfferDocumentsRequest(ref ListPrivateOfferDocumentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPrivateOfferDocumentRequest(ref GetPrivateOfferDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePrivateOfferDocumentRequest(ref CreatePrivateOfferDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdatePrivateOfferDocumentRequest(ref UpdatePrivateOfferDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePrivateOfferDocumentRequest(ref DeletePrivateOfferDocumentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListStandardOffersRequest(ref ListStandardOffersRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetStandardOfferRequest(ref GetStandardOfferRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSkuRequest(ref GetSkuRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkusRequest(ref ListSkusRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSkuGroupRequest(ref GetSkuGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSkuGroupsRequest(ref ListSkuGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedEnumerable<ListServicesResponse, Service> ListServices(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Lists Services in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Service"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListServicesResponse, Service> ListServicesAsync(ListServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListServicesRequest, ListServicesResponse, Service>(_callListServices, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Service GetService(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Service> GetServiceAsync(GetServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetServiceRequest(ref request, ref callSettings);
            return _callGetService.Async(request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOffers for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateOffer"/> resources.</returns>
        public override gax::PagedEnumerable<ListPrivateOffersResponse, PrivateOffer> ListPrivateOffers(ListPrivateOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPrivateOffersRequest, ListPrivateOffersResponse, PrivateOffer>(_callListPrivateOffers, request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOffers for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateOffer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPrivateOffersResponse, PrivateOffer> ListPrivateOffersAsync(ListPrivateOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPrivateOffersRequest, ListPrivateOffersResponse, PrivateOffer>(_callListPrivateOffers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateOffer GetPrivateOffer(GetPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateOfferRequest(ref request, ref callSettings);
            return _callGetPrivateOffer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateOffer> GetPrivateOfferAsync(GetPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateOfferRequest(ref request, ref callSettings);
            return _callGetPrivateOffer.Async(request, callSettings);
        }

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResolveAmendmentTargetResponse ResolveAmendmentTarget(ResolveAmendmentTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveAmendmentTargetRequest(ref request, ref callSettings);
            return _callResolveAmendmentTarget.Sync(request, callSettings);
        }

        /// <summary>
        /// Resolves the existing offer that must be amended when creating a new
        /// PrivateOffer. Use this method to determine the correct amendment target
        /// before creating or publishing an offer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResolveAmendmentTargetResponse> ResolveAmendmentTargetAsync(ResolveAmendmentTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResolveAmendmentTargetRequest(ref request, ref callSettings);
            return _callResolveAmendmentTarget.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new PrivateOffer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateOffer CreatePrivateOffer(CreatePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateOfferRequest(ref request, ref callSettings);
            return _callCreatePrivateOffer.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new PrivateOffer in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateOffer> CreatePrivateOfferAsync(CreatePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateOfferRequest(ref request, ref callSettings);
            return _callCreatePrivateOffer.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateOffer UpdatePrivateOffer(UpdatePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateOfferRequest(ref request, ref callSettings);
            return _callUpdatePrivateOffer.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateOffer> UpdatePrivateOfferAsync(UpdatePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateOfferRequest(ref request, ref callSettings);
            return _callUpdatePrivateOffer.Async(request, callSettings);
        }

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateOffer PublishPrivateOffer(PublishPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishPrivateOfferRequest(ref request, ref callSettings);
            return _callPublishPrivateOffer.Sync(request, callSettings);
        }

        /// <summary>
        /// Publishes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateOffer> PublishPrivateOfferAsync(PublishPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PublishPrivateOfferRequest(ref request, ref callSettings);
            return _callPublishPrivateOffer.Async(request, callSettings);
        }

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateOffer CancelPrivateOffer(CancelPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelPrivateOfferRequest(ref request, ref callSettings);
            return _callCancelPrivateOffer.Sync(request, callSettings);
        }

        /// <summary>
        /// Cancels the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateOffer> CancelPrivateOfferAsync(CancelPrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CancelPrivateOfferRequest(ref request, ref callSettings);
            return _callCancelPrivateOffer.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePrivateOffer(DeletePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateOfferRequest(ref request, ref callSettings);
            _callDeletePrivateOffer.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the target PrivateOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePrivateOfferAsync(DeletePrivateOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateOfferRequest(ref request, ref callSettings);
            return _callDeletePrivateOffer.Async(request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOfferDocuments for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="PrivateOfferDocument"/> resources.</returns>
        public override gax::PagedEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> ListPrivateOfferDocuments(ListPrivateOfferDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateOfferDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPrivateOfferDocumentsRequest, ListPrivateOfferDocumentsResponse, PrivateOfferDocument>(_callListPrivateOfferDocuments, request, callSettings);
        }

        /// <summary>
        /// Lists PrivateOfferDocuments for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="PrivateOfferDocument"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPrivateOfferDocumentsResponse, PrivateOfferDocument> ListPrivateOfferDocumentsAsync(ListPrivateOfferDocumentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPrivateOfferDocumentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPrivateOfferDocumentsRequest, ListPrivateOfferDocumentsResponse, PrivateOfferDocument>(_callListPrivateOfferDocuments, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateOfferDocument GetPrivateOfferDocument(GetPrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateOfferDocumentRequest(ref request, ref callSettings);
            return _callGetPrivateOfferDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateOfferDocument> GetPrivateOfferDocumentAsync(GetPrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPrivateOfferDocumentRequest(ref request, ref callSettings);
            return _callGetPrivateOfferDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new PrivateOfferDocument in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateOfferDocument CreatePrivateOfferDocument(CreatePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateOfferDocumentRequest(ref request, ref callSettings);
            return _callCreatePrivateOfferDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new PrivateOfferDocument in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateOfferDocument> CreatePrivateOfferDocumentAsync(CreatePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePrivateOfferDocumentRequest(ref request, ref callSettings);
            return _callCreatePrivateOfferDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override PrivateOfferDocument UpdatePrivateOfferDocument(UpdatePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateOfferDocumentRequest(ref request, ref callSettings);
            return _callUpdatePrivateOfferDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<PrivateOfferDocument> UpdatePrivateOfferDocumentAsync(UpdatePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdatePrivateOfferDocumentRequest(ref request, ref callSettings);
            return _callUpdatePrivateOfferDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeletePrivateOfferDocument(DeletePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateOfferDocumentRequest(ref request, ref callSettings);
            _callDeletePrivateOfferDocument.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the target PrivateOfferDocument.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeletePrivateOfferDocumentAsync(DeletePrivateOfferDocumentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePrivateOfferDocumentRequest(ref request, ref callSettings);
            return _callDeletePrivateOfferDocument.Async(request, callSettings);
        }

        /// <summary>
        /// Lists StandardOffers for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="StandardOffer"/> resources.</returns>
        public override gax::PagedEnumerable<ListStandardOffersResponse, StandardOffer> ListStandardOffers(ListStandardOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStandardOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListStandardOffersRequest, ListStandardOffersResponse, StandardOffer>(_callListStandardOffers, request, callSettings);
        }

        /// <summary>
        /// Lists StandardOffers for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="StandardOffer"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListStandardOffersResponse, StandardOffer> ListStandardOffersAsync(ListStandardOffersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListStandardOffersRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListStandardOffersRequest, ListStandardOffersResponse, StandardOffer>(_callListStandardOffers, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override StandardOffer GetStandardOffer(GetStandardOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStandardOfferRequest(ref request, ref callSettings);
            return _callGetStandardOffer.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single StandardOffer.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<StandardOffer> GetStandardOfferAsync(GetStandardOfferRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetStandardOfferRequest(ref request, ref callSettings);
            return _callGetStandardOffer.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Sku.
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
        /// Gets details of a single Sku.
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
        /// Lists Skus for the given parent.
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
        /// Lists Skus for the given parent.
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
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SkuGroup GetSkuGroup(GetSkuGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkuGroupRequest(ref request, ref callSettings);
            return _callGetSkuGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single SkuGroup.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SkuGroup> GetSkuGroupAsync(GetSkuGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSkuGroupRequest(ref request, ref callSettings);
            return _callGetSkuGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Lists SkuGroups for the given parent.
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
        /// Lists SkuGroups for the given parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SkuGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSkuGroupsResponse, SkuGroup> ListSkuGroupsAsync(ListSkuGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSkuGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSkuGroupsRequest, ListSkuGroupsResponse, SkuGroup>(_callListSkuGroups, request, callSettings);
        }
    }

    public partial class ListServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPrivateOffersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPrivateOfferDocumentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListStandardOffersRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSkusRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSkuGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListServicesResponse : gaxgrpc::IPageResponse<Service>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Service> GetEnumerator() => Services.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPrivateOffersResponse : gaxgrpc::IPageResponse<PrivateOffer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PrivateOffer> GetEnumerator() => PrivateOffers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPrivateOfferDocumentsResponse : gaxgrpc::IPageResponse<PrivateOfferDocument>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<PrivateOfferDocument> GetEnumerator() => PrivateOfferDocuments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListStandardOffersResponse : gaxgrpc::IPageResponse<StandardOffer>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<StandardOffer> GetEnumerator() => StandardOffers.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSkusResponse : gaxgrpc::IPageResponse<Sku>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Sku> GetEnumerator() => Skus.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSkuGroupsResponse : gaxgrpc::IPageResponse<SkuGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SkuGroup> GetEnumerator() => SkuGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CommerceTransaction
    {
        public partial class CommerceTransactionClient
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
