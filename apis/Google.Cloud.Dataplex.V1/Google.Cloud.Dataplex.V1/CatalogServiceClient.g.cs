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

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Settings for <see cref="CatalogServiceClient"/> instances.</summary>
    public sealed partial class CatalogServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CatalogServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CatalogServiceSettings"/>.</returns>
        public static CatalogServiceSettings GetDefault() => new CatalogServiceSettings();

        /// <summary>Constructs a new <see cref="CatalogServiceSettings"/> object with default settings.</summary>
        public CatalogServiceSettings()
        {
        }

        private CatalogServiceSettings(CatalogServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateEntryTypeSettings = existing.CreateEntryTypeSettings;
            CreateEntryTypeOperationsSettings = existing.CreateEntryTypeOperationsSettings.Clone();
            UpdateEntryTypeSettings = existing.UpdateEntryTypeSettings;
            UpdateEntryTypeOperationsSettings = existing.UpdateEntryTypeOperationsSettings.Clone();
            DeleteEntryTypeSettings = existing.DeleteEntryTypeSettings;
            DeleteEntryTypeOperationsSettings = existing.DeleteEntryTypeOperationsSettings.Clone();
            ListEntryTypesSettings = existing.ListEntryTypesSettings;
            GetEntryTypeSettings = existing.GetEntryTypeSettings;
            CreateAspectTypeSettings = existing.CreateAspectTypeSettings;
            CreateAspectTypeOperationsSettings = existing.CreateAspectTypeOperationsSettings.Clone();
            UpdateAspectTypeSettings = existing.UpdateAspectTypeSettings;
            UpdateAspectTypeOperationsSettings = existing.UpdateAspectTypeOperationsSettings.Clone();
            DeleteAspectTypeSettings = existing.DeleteAspectTypeSettings;
            DeleteAspectTypeOperationsSettings = existing.DeleteAspectTypeOperationsSettings.Clone();
            ListAspectTypesSettings = existing.ListAspectTypesSettings;
            GetAspectTypeSettings = existing.GetAspectTypeSettings;
            CreateEntryGroupSettings = existing.CreateEntryGroupSettings;
            CreateEntryGroupOperationsSettings = existing.CreateEntryGroupOperationsSettings.Clone();
            UpdateEntryGroupSettings = existing.UpdateEntryGroupSettings;
            UpdateEntryGroupOperationsSettings = existing.UpdateEntryGroupOperationsSettings.Clone();
            DeleteEntryGroupSettings = existing.DeleteEntryGroupSettings;
            DeleteEntryGroupOperationsSettings = existing.DeleteEntryGroupOperationsSettings.Clone();
            ListEntryGroupsSettings = existing.ListEntryGroupsSettings;
            GetEntryGroupSettings = existing.GetEntryGroupSettings;
            CreateEntrySettings = existing.CreateEntrySettings;
            UpdateEntrySettings = existing.UpdateEntrySettings;
            DeleteEntrySettings = existing.DeleteEntrySettings;
            ListEntriesSettings = existing.ListEntriesSettings;
            GetEntrySettings = existing.GetEntrySettings;
            LookupEntrySettings = existing.LookupEntrySettings;
            SearchEntriesSettings = existing.SearchEntriesSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(CatalogServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.CreateEntryType</c> and <c>CatalogServiceClient.CreateEntryTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntryTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.CreateEntryType</c> and
        /// <c>CatalogServiceClient.CreateEntryTypeAsync</c>.
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
        public lro::OperationsSettings CreateEntryTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.UpdateEntryType</c> and <c>CatalogServiceClient.UpdateEntryTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntryTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.UpdateEntryType</c> and
        /// <c>CatalogServiceClient.UpdateEntryTypeAsync</c>.
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
        public lro::OperationsSettings UpdateEntryTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.DeleteEntryType</c> and <c>CatalogServiceClient.DeleteEntryTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntryTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.DeleteEntryType</c> and
        /// <c>CatalogServiceClient.DeleteEntryTypeAsync</c>.
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
        public lro::OperationsSettings DeleteEntryTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.ListEntryTypes</c> and <c>CatalogServiceClient.ListEntryTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntryTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.GetEntryType</c> and <c>CatalogServiceClient.GetEntryTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntryTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.CreateAspectType</c> and <c>CatalogServiceClient.CreateAspectTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateAspectTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.CreateAspectType</c> and
        /// <c>CatalogServiceClient.CreateAspectTypeAsync</c>.
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
        public lro::OperationsSettings CreateAspectTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.UpdateAspectType</c> and <c>CatalogServiceClient.UpdateAspectTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateAspectTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.UpdateAspectType</c> and
        /// <c>CatalogServiceClient.UpdateAspectTypeAsync</c>.
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
        public lro::OperationsSettings UpdateAspectTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.DeleteAspectType</c> and <c>CatalogServiceClient.DeleteAspectTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteAspectTypeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.DeleteAspectType</c> and
        /// <c>CatalogServiceClient.DeleteAspectTypeAsync</c>.
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
        public lro::OperationsSettings DeleteAspectTypeOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.ListAspectTypes</c> and <c>CatalogServiceClient.ListAspectTypesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListAspectTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.GetAspectType</c> and <c>CatalogServiceClient.GetAspectTypeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAspectTypeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.CreateEntryGroup</c> and <c>CatalogServiceClient.CreateEntryGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntryGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.CreateEntryGroup</c> and
        /// <c>CatalogServiceClient.CreateEntryGroupAsync</c>.
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
        public lro::OperationsSettings CreateEntryGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.UpdateEntryGroup</c> and <c>CatalogServiceClient.UpdateEntryGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntryGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.UpdateEntryGroup</c> and
        /// <c>CatalogServiceClient.UpdateEntryGroupAsync</c>.
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
        public lro::OperationsSettings UpdateEntryGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.DeleteEntryGroup</c> and <c>CatalogServiceClient.DeleteEntryGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntryGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CatalogServiceClient.DeleteEntryGroup</c> and
        /// <c>CatalogServiceClient.DeleteEntryGroupAsync</c>.
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
        public lro::OperationsSettings DeleteEntryGroupOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.ListEntryGroups</c> and <c>CatalogServiceClient.ListEntryGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntryGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.GetEntryGroup</c> and <c>CatalogServiceClient.GetEntryGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntryGroupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.CreateEntry</c> and <c>CatalogServiceClient.CreateEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEntrySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.UpdateEntry</c> and <c>CatalogServiceClient.UpdateEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 3</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 3, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.DeleteEntry</c> and <c>CatalogServiceClient.DeleteEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEntrySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.ListEntries</c> and <c>CatalogServiceClient.ListEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 3</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 3, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.GetEntry</c> and <c>CatalogServiceClient.GetEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 3</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 3, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.LookupEntry</c> and <c>CatalogServiceClient.LookupEntryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 3</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 20 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LookupEntrySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(20000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 3, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CatalogServiceClient.SearchEntries</c> and <c>CatalogServiceClient.SearchEntriesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 10000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.ResourceExhausted"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchEntriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.ResourceExhausted)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CatalogServiceSettings"/> object.</returns>
        public CatalogServiceSettings Clone() => new CatalogServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CatalogServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class CatalogServiceClientBuilder : gaxgrpc::ClientBuilderBase<CatalogServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CatalogServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CatalogServiceClientBuilder() : base(CatalogServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CatalogServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CatalogServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CatalogServiceClient Build()
        {
            CatalogServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CatalogServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CatalogServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CatalogServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CatalogServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CatalogServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CatalogServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CatalogServiceClient.ChannelPool;
    }

    /// <summary>CatalogService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// The primary resources offered by this service are EntryGroups, EntryTypes,
    /// AspectTypes, Entry and Aspect which collectively allow a data administrator
    /// to organize, manage, secure and catalog data across their organization
    /// located across cloud projects in a variety of storage systems including Cloud
    /// Storage and BigQuery.
    /// </remarks>
    public abstract partial class CatalogServiceClient
    {
        /// <summary>
        /// The default endpoint for the CatalogService service, which is a host of "dataplex.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "dataplex.googleapis.com:443";

        /// <summary>The default CatalogService scopes.</summary>
        /// <remarks>
        /// The default CatalogService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CatalogService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CatalogServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CatalogServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CatalogServiceClient"/>.</returns>
        public static stt::Task<CatalogServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CatalogServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CatalogServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CatalogServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CatalogServiceClient"/>.</returns>
        public static CatalogServiceClient Create() => new CatalogServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CatalogServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CatalogServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CatalogServiceClient"/>.</returns>
        internal static CatalogServiceClient Create(grpccore::CallInvoker callInvoker, CatalogServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CatalogService.CatalogServiceClient grpcClient = new CatalogService.CatalogServiceClient(callInvoker);
            return new CatalogServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CatalogService client</summary>
        public virtual CatalogService.CatalogServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryType, OperationMetadata> CreateEntryType(CreateEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> CreateEntryTypeAsync(CreateEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> CreateEntryTypeAsync(CreateEntryTypeRequest request, st::CancellationToken cancellationToken) =>
            CreateEntryTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEntryType</c>.</summary>
        public virtual lro::OperationsClient CreateEntryTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEntryType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EntryType, OperationMetadata> PollOnceCreateEntryType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntryType, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntryTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEntryType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> PollOnceCreateEntryTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntryType, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntryTypeOperationsClient, callSettings);

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="entryTypeId">
        /// Required. EntryType identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryType, OperationMetadata> CreateEntryType(string parent, EntryType entryType, string entryTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryType(new CreateEntryTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryTypeId, nameof(entryTypeId)),
                EntryType = gax::GaxPreconditions.CheckNotNull(entryType, nameof(entryType)),
            }, callSettings);

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="entryTypeId">
        /// Required. EntryType identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> CreateEntryTypeAsync(string parent, EntryType entryType, string entryTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryTypeAsync(new CreateEntryTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryTypeId, nameof(entryTypeId)),
                EntryType = gax::GaxPreconditions.CheckNotNull(entryType, nameof(entryType)),
            }, callSettings);

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="entryTypeId">
        /// Required. EntryType identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> CreateEntryTypeAsync(string parent, EntryType entryType, string entryTypeId, st::CancellationToken cancellationToken) =>
            CreateEntryTypeAsync(parent, entryType, entryTypeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="entryTypeId">
        /// Required. EntryType identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryType, OperationMetadata> CreateEntryType(gagr::LocationName parent, EntryType entryType, string entryTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryType(new CreateEntryTypeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryTypeId, nameof(entryTypeId)),
                EntryType = gax::GaxPreconditions.CheckNotNull(entryType, nameof(entryType)),
            }, callSettings);

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="entryTypeId">
        /// Required. EntryType identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> CreateEntryTypeAsync(gagr::LocationName parent, EntryType entryType, string entryTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryTypeAsync(new CreateEntryTypeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryTypeId, nameof(entryTypeId)),
                EntryType = gax::GaxPreconditions.CheckNotNull(entryType, nameof(entryType)),
            }, callSettings);

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="entryTypeId">
        /// Required. EntryType identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> CreateEntryTypeAsync(gagr::LocationName parent, EntryType entryType, string entryTypeId, st::CancellationToken cancellationToken) =>
            CreateEntryTypeAsync(parent, entryType, entryTypeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryType, OperationMetadata> UpdateEntryType(UpdateEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> UpdateEntryTypeAsync(UpdateEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> UpdateEntryTypeAsync(UpdateEntryTypeRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntryTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEntryType</c>.</summary>
        public virtual lro::OperationsClient UpdateEntryTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEntryType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EntryType, OperationMetadata> PollOnceUpdateEntryType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntryType, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEntryTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEntryType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> PollOnceUpdateEntryTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntryType, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEntryTypeOperationsClient, callSettings);

        /// <summary>
        /// Updates a EntryType resource.
        /// </summary>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryType, OperationMetadata> UpdateEntryType(EntryType entryType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryType(new UpdateEntryTypeRequest
            {
                EntryType = gax::GaxPreconditions.CheckNotNull(entryType, nameof(entryType)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a EntryType resource.
        /// </summary>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> UpdateEntryTypeAsync(EntryType entryType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryTypeAsync(new UpdateEntryTypeRequest
            {
                EntryType = gax::GaxPreconditions.CheckNotNull(entryType, nameof(entryType)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a EntryType resource.
        /// </summary>
        /// <param name="entryType">
        /// Required. EntryType Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryType, OperationMetadata>> UpdateEntryTypeAsync(EntryType entryType, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntryTypeAsync(entryType, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEntryType(DeleteEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryTypeAsync(DeleteEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryTypeAsync(DeleteEntryTypeRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntryTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEntryType</c>.</summary>
        public virtual lro::OperationsClient DeleteEntryTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEntryType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEntryType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEntryTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEntryType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEntryTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEntryTypeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEntryType(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryType(new DeleteEntryTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryTypeAsync(new DeleteEntryTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryTypeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntryTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEntryType(EntryTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryType(new DeleteEntryTypeRequest
            {
                EntryTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryTypeAsync(EntryTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryTypeAsync(new DeleteEntryTypeRequest
            {
                EntryTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryTypeAsync(EntryTypeName name, st::CancellationToken cancellationToken) =>
            DeleteEntryTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists EntryType resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntryType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryTypesResponse, EntryType> ListEntryTypes(ListEntryTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EntryType resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntryType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryTypesResponse, EntryType> ListEntryTypesAsync(ListEntryTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EntryType resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="EntryType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryTypesResponse, EntryType> ListEntryTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryTypesRequest request = new ListEntryTypesRequest
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
            return ListEntryTypes(request, callSettings);
        }

        /// <summary>
        /// Lists EntryType resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntryType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryTypesResponse, EntryType> ListEntryTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryTypesRequest request = new ListEntryTypesRequest
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
            return ListEntryTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists EntryType resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="EntryType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryTypesResponse, EntryType> ListEntryTypes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryTypesRequest request = new ListEntryTypesRequest
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
            return ListEntryTypes(request, callSettings);
        }

        /// <summary>
        /// Lists EntryType resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the EntryType location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntryType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryTypesResponse, EntryType> ListEntryTypesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryTypesRequest request = new ListEntryTypesRequest
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
            return ListEntryTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryType GetEntryType(GetEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryType> GetEntryTypeAsync(GetEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryType> GetEntryTypeAsync(GetEntryTypeRequest request, st::CancellationToken cancellationToken) =>
            GetEntryTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryType GetEntryType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryType(new GetEntryTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryType> GetEntryTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryTypeAsync(new GetEntryTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryType> GetEntryTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntryTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryType GetEntryType(EntryTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryType(new GetEntryTypeRequest
            {
                EntryTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryType> GetEntryTypeAsync(EntryTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryTypeAsync(new GetEntryTypeRequest
            {
                EntryTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryType:
        /// `projects/{project_number}/locations/{location_id}/entryTypes/{entry_type_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryType> GetEntryTypeAsync(EntryTypeName name, st::CancellationToken cancellationToken) =>
            GetEntryTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AspectType, OperationMetadata> CreateAspectType(CreateAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> CreateAspectTypeAsync(CreateAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> CreateAspectTypeAsync(CreateAspectTypeRequest request, st::CancellationToken cancellationToken) =>
            CreateAspectTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateAspectType</c>.</summary>
        public virtual lro::OperationsClient CreateAspectTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateAspectType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AspectType, OperationMetadata> PollOnceCreateAspectType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AspectType, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAspectTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateAspectType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> PollOnceCreateAspectTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AspectType, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateAspectTypeOperationsClient, callSettings);

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="aspectTypeId">
        /// Required. AspectType identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AspectType, OperationMetadata> CreateAspectType(string parent, AspectType aspectType, string aspectTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAspectType(new CreateAspectTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AspectTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(aspectTypeId, nameof(aspectTypeId)),
                AspectType = gax::GaxPreconditions.CheckNotNull(aspectType, nameof(aspectType)),
            }, callSettings);

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="aspectTypeId">
        /// Required. AspectType identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> CreateAspectTypeAsync(string parent, AspectType aspectType, string aspectTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAspectTypeAsync(new CreateAspectTypeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                AspectTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(aspectTypeId, nameof(aspectTypeId)),
                AspectType = gax::GaxPreconditions.CheckNotNull(aspectType, nameof(aspectType)),
            }, callSettings);

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="aspectTypeId">
        /// Required. AspectType identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> CreateAspectTypeAsync(string parent, AspectType aspectType, string aspectTypeId, st::CancellationToken cancellationToken) =>
            CreateAspectTypeAsync(parent, aspectType, aspectTypeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="aspectTypeId">
        /// Required. AspectType identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AspectType, OperationMetadata> CreateAspectType(gagr::LocationName parent, AspectType aspectType, string aspectTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAspectType(new CreateAspectTypeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AspectTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(aspectTypeId, nameof(aspectTypeId)),
                AspectType = gax::GaxPreconditions.CheckNotNull(aspectType, nameof(aspectType)),
            }, callSettings);

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="aspectTypeId">
        /// Required. AspectType identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> CreateAspectTypeAsync(gagr::LocationName parent, AspectType aspectType, string aspectTypeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateAspectTypeAsync(new CreateAspectTypeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                AspectTypeId = gax::GaxPreconditions.CheckNotNullOrEmpty(aspectTypeId, nameof(aspectTypeId)),
                AspectType = gax::GaxPreconditions.CheckNotNull(aspectType, nameof(aspectType)),
            }, callSettings);

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="aspectTypeId">
        /// Required. AspectType identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> CreateAspectTypeAsync(gagr::LocationName parent, AspectType aspectType, string aspectTypeId, st::CancellationToken cancellationToken) =>
            CreateAspectTypeAsync(parent, aspectType, aspectTypeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AspectType, OperationMetadata> UpdateAspectType(UpdateAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> UpdateAspectTypeAsync(UpdateAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> UpdateAspectTypeAsync(UpdateAspectTypeRequest request, st::CancellationToken cancellationToken) =>
            UpdateAspectTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateAspectType</c>.</summary>
        public virtual lro::OperationsClient UpdateAspectTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateAspectType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<AspectType, OperationMetadata> PollOnceUpdateAspectType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AspectType, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAspectTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateAspectType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> PollOnceUpdateAspectTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<AspectType, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateAspectTypeOperationsClient, callSettings);

        /// <summary>
        /// Updates a AspectType resource.
        /// </summary>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<AspectType, OperationMetadata> UpdateAspectType(AspectType aspectType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAspectType(new UpdateAspectTypeRequest
            {
                AspectType = gax::GaxPreconditions.CheckNotNull(aspectType, nameof(aspectType)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a AspectType resource.
        /// </summary>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> UpdateAspectTypeAsync(AspectType aspectType, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateAspectTypeAsync(new UpdateAspectTypeRequest
            {
                AspectType = gax::GaxPreconditions.CheckNotNull(aspectType, nameof(aspectType)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a AspectType resource.
        /// </summary>
        /// <param name="aspectType">
        /// Required. AspectType Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<AspectType, OperationMetadata>> UpdateAspectTypeAsync(AspectType aspectType, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateAspectTypeAsync(aspectType, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAspectType(DeleteAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAspectTypeAsync(DeleteAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAspectTypeAsync(DeleteAspectTypeRequest request, st::CancellationToken cancellationToken) =>
            DeleteAspectTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteAspectType</c>.</summary>
        public virtual lro::OperationsClient DeleteAspectTypeOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteAspectType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteAspectType(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAspectTypeOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteAspectType</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteAspectTypeAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteAspectTypeOperationsClient, callSettings);

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAspectType(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAspectType(new DeleteAspectTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAspectTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAspectTypeAsync(new DeleteAspectTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAspectTypeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteAspectTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteAspectType(AspectTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAspectType(new DeleteAspectTypeRequest
            {
                AspectTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAspectTypeAsync(AspectTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteAspectTypeAsync(new DeleteAspectTypeRequest
            {
                AspectTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAspectTypeAsync(AspectTypeName name, st::CancellationToken cancellationToken) =>
            DeleteAspectTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists AspectType resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AspectType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAspectTypesResponse, AspectType> ListAspectTypes(ListAspectTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AspectType resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AspectType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAspectTypesResponse, AspectType> ListAspectTypesAsync(ListAspectTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists AspectType resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="AspectType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAspectTypesResponse, AspectType> ListAspectTypes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAspectTypesRequest request = new ListAspectTypesRequest
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
            return ListAspectTypes(request, callSettings);
        }

        /// <summary>
        /// Lists AspectType resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AspectType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAspectTypesResponse, AspectType> ListAspectTypesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAspectTypesRequest request = new ListAspectTypesRequest
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
            return ListAspectTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists AspectType resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="AspectType"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListAspectTypesResponse, AspectType> ListAspectTypes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAspectTypesRequest request = new ListAspectTypesRequest
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
            return ListAspectTypes(request, callSettings);
        }

        /// <summary>
        /// Lists AspectType resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the AspectType location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="AspectType"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListAspectTypesResponse, AspectType> ListAspectTypesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListAspectTypesRequest request = new ListAspectTypesRequest
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
            return ListAspectTypesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AspectType GetAspectType(GetAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AspectType> GetAspectTypeAsync(GetAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AspectType> GetAspectTypeAsync(GetAspectTypeRequest request, st::CancellationToken cancellationToken) =>
            GetAspectTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AspectType GetAspectType(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAspectType(new GetAspectTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AspectType> GetAspectTypeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetAspectTypeAsync(new GetAspectTypeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AspectType> GetAspectTypeAsync(string name, st::CancellationToken cancellationToken) =>
            GetAspectTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AspectType GetAspectType(AspectTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAspectType(new GetAspectTypeRequest
            {
                AspectTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AspectType> GetAspectTypeAsync(AspectTypeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetAspectTypeAsync(new GetAspectTypeRequest
            {
                AspectTypeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the AspectType:
        /// `projects/{project_number}/locations/{location_id}/aspectTypes/{aspect_type_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AspectType> GetAspectTypeAsync(AspectTypeName name, st::CancellationToken cancellationToken) =>
            GetAspectTypeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryGroup, OperationMetadata> CreateEntryGroup(CreateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> CreateEntryGroupAsync(CreateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> CreateEntryGroupAsync(CreateEntryGroupRequest request, st::CancellationToken cancellationToken) =>
            CreateEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateEntryGroup</c>.</summary>
        public virtual lro::OperationsClient CreateEntryGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateEntryGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EntryGroup, OperationMetadata> PollOnceCreateEntryGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntryGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntryGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateEntryGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> PollOnceCreateEntryGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntryGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateEntryGroupOperationsClient, callSettings);

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="entryGroupId">
        /// Required. EntryGroup identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryGroup, OperationMetadata> CreateEntryGroup(string parent, EntryGroup entryGroup, string entryGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryGroup(new CreateEntryGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)),
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="entryGroupId">
        /// Required. EntryGroup identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> CreateEntryGroupAsync(string parent, EntryGroup entryGroup, string entryGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryGroupAsync(new CreateEntryGroupRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)),
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="entryGroupId">
        /// Required. EntryGroup identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> CreateEntryGroupAsync(string parent, EntryGroup entryGroup, string entryGroupId, st::CancellationToken cancellationToken) =>
            CreateEntryGroupAsync(parent, entryGroup, entryGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="entryGroupId">
        /// Required. EntryGroup identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryGroup, OperationMetadata> CreateEntryGroup(gagr::LocationName parent, EntryGroup entryGroup, string entryGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryGroup(new CreateEntryGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)),
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="entryGroupId">
        /// Required. EntryGroup identifier.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> CreateEntryGroupAsync(gagr::LocationName parent, EntryGroup entryGroup, string entryGroupId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryGroupAsync(new CreateEntryGroupRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryGroupId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryGroupId, nameof(entryGroupId)),
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
            }, callSettings);

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup, of the form:
        /// projects/{project_number}/locations/{location_id}
        /// where `location_id` refers to a GCP region.
        /// </param>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="entryGroupId">
        /// Required. EntryGroup identifier.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> CreateEntryGroupAsync(gagr::LocationName parent, EntryGroup entryGroup, string entryGroupId, st::CancellationToken cancellationToken) =>
            CreateEntryGroupAsync(parent, entryGroup, entryGroupId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryGroup, OperationMetadata> UpdateEntryGroup(UpdateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> UpdateEntryGroupAsync(UpdateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> UpdateEntryGroupAsync(UpdateEntryGroupRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateEntryGroup</c>.</summary>
        public virtual lro::OperationsClient UpdateEntryGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateEntryGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<EntryGroup, OperationMetadata> PollOnceUpdateEntryGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntryGroup, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEntryGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateEntryGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> PollOnceUpdateEntryGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<EntryGroup, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateEntryGroupOperationsClient, callSettings);

        /// <summary>
        /// Updates a EntryGroup resource.
        /// </summary>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<EntryGroup, OperationMetadata> UpdateEntryGroup(EntryGroup entryGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryGroup(new UpdateEntryGroupRequest
            {
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a EntryGroup resource.
        /// </summary>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> UpdateEntryGroupAsync(EntryGroup entryGroup, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryGroupAsync(new UpdateEntryGroupRequest
            {
                EntryGroup = gax::GaxPreconditions.CheckNotNull(entryGroup, nameof(entryGroup)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a EntryGroup resource.
        /// </summary>
        /// <param name="entryGroup">
        /// Required. EntryGroup Resource
        /// </param>
        /// <param name="updateMask">
        /// Required. Mask of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<EntryGroup, OperationMetadata>> UpdateEntryGroupAsync(EntryGroup entryGroup, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntryGroupAsync(entryGroup, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEntryGroup(DeleteEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryGroupAsync(DeleteEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryGroupAsync(DeleteEntryGroupRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteEntryGroup</c>.</summary>
        public virtual lro::OperationsClient DeleteEntryGroupOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteEntryGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteEntryGroup(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEntryGroupOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteEntryGroup</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteEntryGroupAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteEntryGroupOperationsClient, callSettings);

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEntryGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryGroup(new DeleteEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryGroupAsync(new DeleteEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryGroupAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntryGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteEntryGroup(EntryGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryGroup(new DeleteEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryGroupAsync(EntryGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryGroupAsync(new DeleteEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryGroupAsync(EntryGroupName name, st::CancellationToken cancellationToken) =>
            DeleteEntryGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists EntryGroup resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroups(ListEntryGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EntryGroup resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroupsAsync(ListEntryGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists EntryGroup resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroups(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
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
            return ListEntryGroups(request, callSettings);
        }

        /// <summary>
        /// Lists EntryGroup resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroupsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
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
            return ListEntryGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists EntryGroup resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroups(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
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
            return ListEntryGroups(request, callSettings);
        }

        /// <summary>
        /// Lists EntryGroup resources in a project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the entryGroup location, of the form:
        /// `projects/{project_number}/locations/{location_id}`
        /// where `location_id` refers to a GCP region.
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
        /// <returns>A pageable asynchronous sequence of <see cref="EntryGroup"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroupsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntryGroupsRequest request = new ListEntryGroupsRequest
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
            return ListEntryGroupsAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup GetEntryGroup(GetEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(GetEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(GetEntryGroupRequest request, st::CancellationToken cancellationToken) =>
            GetEntryGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup GetEntryGroup(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroup(new GetEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroupAsync(new GetEntryGroupRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntryGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EntryGroup GetEntryGroup(EntryGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroup(new GetEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(EntryGroupName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryGroupAsync(new GetEntryGroupRequest
            {
                EntryGroupName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the EntryGroup:
        /// `projects/{project_number}/locations/{location_id}/entryGroups/{entry_group_id}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EntryGroup> GetEntryGroupAsync(EntryGroupName name, st::CancellationToken cancellationToken) =>
            GetEntryGroupAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry CreateEntry(CreateEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(CreateEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(CreateEntryRequest request, st::CancellationToken cancellationToken) =>
            CreateEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
        /// </param>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="entryId">
        /// Required. Entry identifier. It has to be unique within an Entry Group.
        /// 
        /// Entries corresponding to Google Cloud resources use Entry ID format based
        /// on Full Resource Names
        /// (https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// The format is a Full Resource Name of the resource without the
        /// prefix double slashes in the API Service Name part of Full Resource Name.
        /// This allows retrieval of entries using their associated resource name.
        /// 
        /// For example if the Full Resource Name of a resource is
        /// `//library.googleapis.com/shelves/shelf1/books/book2`,
        /// then the suggested entry_id is
        /// `library.googleapis.com/shelves/shelf1/books/book2`.
        /// 
        /// It is also suggested to follow the same convention for entries
        /// corresponding to resources from other providers or systems than Google
        /// Cloud.
        /// 
        /// The maximum size of the field is 4000 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry CreateEntry(string parent, Entry entry, string entryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntry(new CreateEntryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)),
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
        /// </param>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="entryId">
        /// Required. Entry identifier. It has to be unique within an Entry Group.
        /// 
        /// Entries corresponding to Google Cloud resources use Entry ID format based
        /// on Full Resource Names
        /// (https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// The format is a Full Resource Name of the resource without the
        /// prefix double slashes in the API Service Name part of Full Resource Name.
        /// This allows retrieval of entries using their associated resource name.
        /// 
        /// For example if the Full Resource Name of a resource is
        /// `//library.googleapis.com/shelves/shelf1/books/book2`,
        /// then the suggested entry_id is
        /// `library.googleapis.com/shelves/shelf1/books/book2`.
        /// 
        /// It is also suggested to follow the same convention for entries
        /// corresponding to resources from other providers or systems than Google
        /// Cloud.
        /// 
        /// The maximum size of the field is 4000 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(string parent, Entry entry, string entryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryAsync(new CreateEntryRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)),
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
        /// </param>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="entryId">
        /// Required. Entry identifier. It has to be unique within an Entry Group.
        /// 
        /// Entries corresponding to Google Cloud resources use Entry ID format based
        /// on Full Resource Names
        /// (https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// The format is a Full Resource Name of the resource without the
        /// prefix double slashes in the API Service Name part of Full Resource Name.
        /// This allows retrieval of entries using their associated resource name.
        /// 
        /// For example if the Full Resource Name of a resource is
        /// `//library.googleapis.com/shelves/shelf1/books/book2`,
        /// then the suggested entry_id is
        /// `library.googleapis.com/shelves/shelf1/books/book2`.
        /// 
        /// It is also suggested to follow the same convention for entries
        /// corresponding to resources from other providers or systems than Google
        /// Cloud.
        /// 
        /// The maximum size of the field is 4000 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(string parent, Entry entry, string entryId, st::CancellationToken cancellationToken) =>
            CreateEntryAsync(parent, entry, entryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
        /// </param>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="entryId">
        /// Required. Entry identifier. It has to be unique within an Entry Group.
        /// 
        /// Entries corresponding to Google Cloud resources use Entry ID format based
        /// on Full Resource Names
        /// (https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// The format is a Full Resource Name of the resource without the
        /// prefix double slashes in the API Service Name part of Full Resource Name.
        /// This allows retrieval of entries using their associated resource name.
        /// 
        /// For example if the Full Resource Name of a resource is
        /// `//library.googleapis.com/shelves/shelf1/books/book2`,
        /// then the suggested entry_id is
        /// `library.googleapis.com/shelves/shelf1/books/book2`.
        /// 
        /// It is also suggested to follow the same convention for entries
        /// corresponding to resources from other providers or systems than Google
        /// Cloud.
        /// 
        /// The maximum size of the field is 4000 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry CreateEntry(EntryGroupName parent, Entry entry, string entryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntry(new CreateEntryRequest
            {
                ParentAsEntryGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)),
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
        /// </param>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="entryId">
        /// Required. Entry identifier. It has to be unique within an Entry Group.
        /// 
        /// Entries corresponding to Google Cloud resources use Entry ID format based
        /// on Full Resource Names
        /// (https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// The format is a Full Resource Name of the resource without the
        /// prefix double slashes in the API Service Name part of Full Resource Name.
        /// This allows retrieval of entries using their associated resource name.
        /// 
        /// For example if the Full Resource Name of a resource is
        /// `//library.googleapis.com/shelves/shelf1/books/book2`,
        /// then the suggested entry_id is
        /// `library.googleapis.com/shelves/shelf1/books/book2`.
        /// 
        /// It is also suggested to follow the same convention for entries
        /// corresponding to resources from other providers or systems than Google
        /// Cloud.
        /// 
        /// The maximum size of the field is 4000 characters.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(EntryGroupName parent, Entry entry, string entryId, gaxgrpc::CallSettings callSettings = null) =>
            CreateEntryAsync(new CreateEntryRequest
            {
                ParentAsEntryGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EntryId = gax::GaxPreconditions.CheckNotNullOrEmpty(entryId, nameof(entryId)),
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
            }, callSettings);

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
        /// </param>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="entryId">
        /// Required. Entry identifier. It has to be unique within an Entry Group.
        /// 
        /// Entries corresponding to Google Cloud resources use Entry ID format based
        /// on Full Resource Names
        /// (https://cloud.google.com/apis/design/resource_names#full_resource_name).
        /// The format is a Full Resource Name of the resource without the
        /// prefix double slashes in the API Service Name part of Full Resource Name.
        /// This allows retrieval of entries using their associated resource name.
        /// 
        /// For example if the Full Resource Name of a resource is
        /// `//library.googleapis.com/shelves/shelf1/books/book2`,
        /// then the suggested entry_id is
        /// `library.googleapis.com/shelves/shelf1/books/book2`.
        /// 
        /// It is also suggested to follow the same convention for entries
        /// corresponding to resources from other providers or systems than Google
        /// Cloud.
        /// 
        /// The maximum size of the field is 4000 characters.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> CreateEntryAsync(EntryGroupName parent, Entry entry, string entryId, st::CancellationToken cancellationToken) =>
            CreateEntryAsync(parent, entry, entryId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry UpdateEntry(UpdateEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(UpdateEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(UpdateEntryRequest request, st::CancellationToken cancellationToken) =>
            UpdateEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates an Entry.
        /// </summary>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update. To update Aspects, the update_mask must
        /// contain the value "aspects".
        /// 
        /// If the update_mask is empty, all modifiable fields present in the request
        /// will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry UpdateEntry(Entry entry, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntry(new UpdateEntryRequest
            {
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an Entry.
        /// </summary>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update. To update Aspects, the update_mask must
        /// contain the value "aspects".
        /// 
        /// If the update_mask is empty, all modifiable fields present in the request
        /// will be updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(Entry entry, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEntryAsync(new UpdateEntryRequest
            {
                Entry = gax::GaxPreconditions.CheckNotNull(entry, nameof(entry)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Updates an Entry.
        /// </summary>
        /// <param name="entry">
        /// Required. Entry resource.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Mask of fields to update. To update Aspects, the update_mask must
        /// contain the value "aspects".
        /// 
        /// If the update_mask is empty, all modifiable fields present in the request
        /// will be updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> UpdateEntryAsync(Entry entry, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEntryAsync(entry, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry DeleteEntry(DeleteEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> DeleteEntryAsync(DeleteEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> DeleteEntryAsync(DeleteEntryRequest request, st::CancellationToken cancellationToken) =>
            DeleteEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry DeleteEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntry(new DeleteEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> DeleteEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryAsync(new DeleteEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> DeleteEntryAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry DeleteEntry(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntry(new DeleteEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> DeleteEntryAsync(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEntryAsync(new DeleteEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> DeleteEntryAsync(EntryName name, st::CancellationToken cancellationToken) =>
            DeleteEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists entries within an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntriesResponse, Entry> ListEntries(ListEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists entries within an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntriesResponse, Entry> ListEntriesAsync(ListEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists entries within an entry group.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
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
        /// <returns>A pageable sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntriesResponse, Entry> ListEntries(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntriesRequest request = new ListEntriesRequest
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
            return ListEntries(request, callSettings);
        }

        /// <summary>
        /// Lists entries within an entry group.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntriesResponse, Entry> ListEntriesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntriesRequest request = new ListEntriesRequest
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
            return ListEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists entries within an entry group.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
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
        /// <returns>A pageable sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEntriesResponse, Entry> ListEntries(EntryGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntriesRequest request = new ListEntriesRequest
            {
                ParentAsEntryGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntries(request, callSettings);
        }

        /// <summary>
        /// Lists entries within an entry group.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the parent Entry Group:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Entry"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListEntriesResponse, Entry> ListEntriesAsync(EntryGroupName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEntriesRequest request = new ListEntriesRequest
            {
                ParentAsEntryGroupName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEntriesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry GetEntry(GetEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(GetEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(GetEntryRequest request, st::CancellationToken cancellationToken) =>
            GetEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry GetEntry(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntry(new GetEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryAsync(new GetEntryRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(string name, st::CancellationToken cancellationToken) =>
            GetEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry GetEntry(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntry(new GetEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(EntryName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEntryAsync(new GetEntryRequest
            {
                EntryName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Entry:
        /// `projects/{project}/locations/{location}/entryGroups/{entry_group}/entries/{entry}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> GetEntryAsync(EntryName name, st::CancellationToken cancellationToken) =>
            GetEntryAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Looks up a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Entry LookupEntry(LookupEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> LookupEntryAsync(LookupEntryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Looks up a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Entry> LookupEntryAsync(LookupEntryRequest request, st::CancellationToken cancellationToken) =>
            LookupEntryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for entries matching given query and scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchEntriesResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchEntriesResponse, SearchEntriesResult> SearchEntries(SearchEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for entries matching given query and scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchEntriesResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchEntriesResponse, SearchEntriesResult> SearchEntriesAsync(SearchEntriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for entries matching given query and scope.
        /// </summary>
        /// <param name="name">
        /// Required. The project to which the request should be attributed in the
        /// following form: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="query">
        /// Required. The query against which entries in scope should be matched.
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
        /// <returns>A pageable sequence of <see cref="SearchEntriesResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchEntriesResponse, SearchEntriesResult> SearchEntries(string name, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchEntriesRequest request = new SearchEntriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchEntries(request, callSettings);
        }

        /// <summary>
        /// Searches for entries matching given query and scope.
        /// </summary>
        /// <param name="name">
        /// Required. The project to which the request should be attributed in the
        /// following form: `projects/{project}/locations/{location}`.
        /// </param>
        /// <param name="query">
        /// Required. The query against which entries in scope should be matched.
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
        /// <returns>A pageable asynchronous sequence of <see cref="SearchEntriesResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchEntriesResponse, SearchEntriesResult> SearchEntriesAsync(string name, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchEntriesRequest request = new SearchEntriesRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchEntriesAsync(request, callSettings);
        }
    }

    /// <summary>CatalogService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// The primary resources offered by this service are EntryGroups, EntryTypes,
    /// AspectTypes, Entry and Aspect which collectively allow a data administrator
    /// to organize, manage, secure and catalog data across their organization
    /// located across cloud projects in a variety of storage systems including Cloud
    /// Storage and BigQuery.
    /// </remarks>
    public sealed partial class CatalogServiceClientImpl : CatalogServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateEntryTypeRequest, lro::Operation> _callCreateEntryType;

        private readonly gaxgrpc::ApiCall<UpdateEntryTypeRequest, lro::Operation> _callUpdateEntryType;

        private readonly gaxgrpc::ApiCall<DeleteEntryTypeRequest, lro::Operation> _callDeleteEntryType;

        private readonly gaxgrpc::ApiCall<ListEntryTypesRequest, ListEntryTypesResponse> _callListEntryTypes;

        private readonly gaxgrpc::ApiCall<GetEntryTypeRequest, EntryType> _callGetEntryType;

        private readonly gaxgrpc::ApiCall<CreateAspectTypeRequest, lro::Operation> _callCreateAspectType;

        private readonly gaxgrpc::ApiCall<UpdateAspectTypeRequest, lro::Operation> _callUpdateAspectType;

        private readonly gaxgrpc::ApiCall<DeleteAspectTypeRequest, lro::Operation> _callDeleteAspectType;

        private readonly gaxgrpc::ApiCall<ListAspectTypesRequest, ListAspectTypesResponse> _callListAspectTypes;

        private readonly gaxgrpc::ApiCall<GetAspectTypeRequest, AspectType> _callGetAspectType;

        private readonly gaxgrpc::ApiCall<CreateEntryGroupRequest, lro::Operation> _callCreateEntryGroup;

        private readonly gaxgrpc::ApiCall<UpdateEntryGroupRequest, lro::Operation> _callUpdateEntryGroup;

        private readonly gaxgrpc::ApiCall<DeleteEntryGroupRequest, lro::Operation> _callDeleteEntryGroup;

        private readonly gaxgrpc::ApiCall<ListEntryGroupsRequest, ListEntryGroupsResponse> _callListEntryGroups;

        private readonly gaxgrpc::ApiCall<GetEntryGroupRequest, EntryGroup> _callGetEntryGroup;

        private readonly gaxgrpc::ApiCall<CreateEntryRequest, Entry> _callCreateEntry;

        private readonly gaxgrpc::ApiCall<UpdateEntryRequest, Entry> _callUpdateEntry;

        private readonly gaxgrpc::ApiCall<DeleteEntryRequest, Entry> _callDeleteEntry;

        private readonly gaxgrpc::ApiCall<ListEntriesRequest, ListEntriesResponse> _callListEntries;

        private readonly gaxgrpc::ApiCall<GetEntryRequest, Entry> _callGetEntry;

        private readonly gaxgrpc::ApiCall<LookupEntryRequest, Entry> _callLookupEntry;

        private readonly gaxgrpc::ApiCall<SearchEntriesRequest, SearchEntriesResponse> _callSearchEntries;

        /// <summary>
        /// Constructs a client wrapper for the CatalogService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CatalogServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CatalogServiceClientImpl(CatalogService.CatalogServiceClient grpcClient, CatalogServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CatalogServiceSettings effectiveSettings = settings ?? CatalogServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateEntryTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEntryTypeOperationsSettings, logger);
            UpdateEntryTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEntryTypeOperationsSettings, logger);
            DeleteEntryTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEntryTypeOperationsSettings, logger);
            CreateAspectTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateAspectTypeOperationsSettings, logger);
            UpdateAspectTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateAspectTypeOperationsSettings, logger);
            DeleteAspectTypeOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteAspectTypeOperationsSettings, logger);
            CreateEntryGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateEntryGroupOperationsSettings, logger);
            UpdateEntryGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateEntryGroupOperationsSettings, logger);
            DeleteEntryGroupOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteEntryGroupOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callCreateEntryType = clientHelper.BuildApiCall<CreateEntryTypeRequest, lro::Operation>("CreateEntryType", grpcClient.CreateEntryTypeAsync, grpcClient.CreateEntryType, effectiveSettings.CreateEntryTypeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntryType);
            Modify_CreateEntryTypeApiCall(ref _callCreateEntryType);
            _callUpdateEntryType = clientHelper.BuildApiCall<UpdateEntryTypeRequest, lro::Operation>("UpdateEntryType", grpcClient.UpdateEntryTypeAsync, grpcClient.UpdateEntryType, effectiveSettings.UpdateEntryTypeSettings).WithGoogleRequestParam("entry_type.name", request => request.EntryType?.Name);
            Modify_ApiCall(ref _callUpdateEntryType);
            Modify_UpdateEntryTypeApiCall(ref _callUpdateEntryType);
            _callDeleteEntryType = clientHelper.BuildApiCall<DeleteEntryTypeRequest, lro::Operation>("DeleteEntryType", grpcClient.DeleteEntryTypeAsync, grpcClient.DeleteEntryType, effectiveSettings.DeleteEntryTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntryType);
            Modify_DeleteEntryTypeApiCall(ref _callDeleteEntryType);
            _callListEntryTypes = clientHelper.BuildApiCall<ListEntryTypesRequest, ListEntryTypesResponse>("ListEntryTypes", grpcClient.ListEntryTypesAsync, grpcClient.ListEntryTypes, effectiveSettings.ListEntryTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntryTypes);
            Modify_ListEntryTypesApiCall(ref _callListEntryTypes);
            _callGetEntryType = clientHelper.BuildApiCall<GetEntryTypeRequest, EntryType>("GetEntryType", grpcClient.GetEntryTypeAsync, grpcClient.GetEntryType, effectiveSettings.GetEntryTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntryType);
            Modify_GetEntryTypeApiCall(ref _callGetEntryType);
            _callCreateAspectType = clientHelper.BuildApiCall<CreateAspectTypeRequest, lro::Operation>("CreateAspectType", grpcClient.CreateAspectTypeAsync, grpcClient.CreateAspectType, effectiveSettings.CreateAspectTypeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateAspectType);
            Modify_CreateAspectTypeApiCall(ref _callCreateAspectType);
            _callUpdateAspectType = clientHelper.BuildApiCall<UpdateAspectTypeRequest, lro::Operation>("UpdateAspectType", grpcClient.UpdateAspectTypeAsync, grpcClient.UpdateAspectType, effectiveSettings.UpdateAspectTypeSettings).WithGoogleRequestParam("aspect_type.name", request => request.AspectType?.Name);
            Modify_ApiCall(ref _callUpdateAspectType);
            Modify_UpdateAspectTypeApiCall(ref _callUpdateAspectType);
            _callDeleteAspectType = clientHelper.BuildApiCall<DeleteAspectTypeRequest, lro::Operation>("DeleteAspectType", grpcClient.DeleteAspectTypeAsync, grpcClient.DeleteAspectType, effectiveSettings.DeleteAspectTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteAspectType);
            Modify_DeleteAspectTypeApiCall(ref _callDeleteAspectType);
            _callListAspectTypes = clientHelper.BuildApiCall<ListAspectTypesRequest, ListAspectTypesResponse>("ListAspectTypes", grpcClient.ListAspectTypesAsync, grpcClient.ListAspectTypes, effectiveSettings.ListAspectTypesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListAspectTypes);
            Modify_ListAspectTypesApiCall(ref _callListAspectTypes);
            _callGetAspectType = clientHelper.BuildApiCall<GetAspectTypeRequest, AspectType>("GetAspectType", grpcClient.GetAspectTypeAsync, grpcClient.GetAspectType, effectiveSettings.GetAspectTypeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetAspectType);
            Modify_GetAspectTypeApiCall(ref _callGetAspectType);
            _callCreateEntryGroup = clientHelper.BuildApiCall<CreateEntryGroupRequest, lro::Operation>("CreateEntryGroup", grpcClient.CreateEntryGroupAsync, grpcClient.CreateEntryGroup, effectiveSettings.CreateEntryGroupSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntryGroup);
            Modify_CreateEntryGroupApiCall(ref _callCreateEntryGroup);
            _callUpdateEntryGroup = clientHelper.BuildApiCall<UpdateEntryGroupRequest, lro::Operation>("UpdateEntryGroup", grpcClient.UpdateEntryGroupAsync, grpcClient.UpdateEntryGroup, effectiveSettings.UpdateEntryGroupSettings).WithGoogleRequestParam("entry_group.name", request => request.EntryGroup?.Name);
            Modify_ApiCall(ref _callUpdateEntryGroup);
            Modify_UpdateEntryGroupApiCall(ref _callUpdateEntryGroup);
            _callDeleteEntryGroup = clientHelper.BuildApiCall<DeleteEntryGroupRequest, lro::Operation>("DeleteEntryGroup", grpcClient.DeleteEntryGroupAsync, grpcClient.DeleteEntryGroup, effectiveSettings.DeleteEntryGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntryGroup);
            Modify_DeleteEntryGroupApiCall(ref _callDeleteEntryGroup);
            _callListEntryGroups = clientHelper.BuildApiCall<ListEntryGroupsRequest, ListEntryGroupsResponse>("ListEntryGroups", grpcClient.ListEntryGroupsAsync, grpcClient.ListEntryGroups, effectiveSettings.ListEntryGroupsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntryGroups);
            Modify_ListEntryGroupsApiCall(ref _callListEntryGroups);
            _callGetEntryGroup = clientHelper.BuildApiCall<GetEntryGroupRequest, EntryGroup>("GetEntryGroup", grpcClient.GetEntryGroupAsync, grpcClient.GetEntryGroup, effectiveSettings.GetEntryGroupSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntryGroup);
            Modify_GetEntryGroupApiCall(ref _callGetEntryGroup);
            _callCreateEntry = clientHelper.BuildApiCall<CreateEntryRequest, Entry>("CreateEntry", grpcClient.CreateEntryAsync, grpcClient.CreateEntry, effectiveSettings.CreateEntrySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEntry);
            Modify_CreateEntryApiCall(ref _callCreateEntry);
            _callUpdateEntry = clientHelper.BuildApiCall<UpdateEntryRequest, Entry>("UpdateEntry", grpcClient.UpdateEntryAsync, grpcClient.UpdateEntry, effectiveSettings.UpdateEntrySettings).WithGoogleRequestParam("entry.name", request => request.Entry?.Name);
            Modify_ApiCall(ref _callUpdateEntry);
            Modify_UpdateEntryApiCall(ref _callUpdateEntry);
            _callDeleteEntry = clientHelper.BuildApiCall<DeleteEntryRequest, Entry>("DeleteEntry", grpcClient.DeleteEntryAsync, grpcClient.DeleteEntry, effectiveSettings.DeleteEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEntry);
            Modify_DeleteEntryApiCall(ref _callDeleteEntry);
            _callListEntries = clientHelper.BuildApiCall<ListEntriesRequest, ListEntriesResponse>("ListEntries", grpcClient.ListEntriesAsync, grpcClient.ListEntries, effectiveSettings.ListEntriesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEntries);
            Modify_ListEntriesApiCall(ref _callListEntries);
            _callGetEntry = clientHelper.BuildApiCall<GetEntryRequest, Entry>("GetEntry", grpcClient.GetEntryAsync, grpcClient.GetEntry, effectiveSettings.GetEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEntry);
            Modify_GetEntryApiCall(ref _callGetEntry);
            _callLookupEntry = clientHelper.BuildApiCall<LookupEntryRequest, Entry>("LookupEntry", grpcClient.LookupEntryAsync, grpcClient.LookupEntry, effectiveSettings.LookupEntrySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callLookupEntry);
            Modify_LookupEntryApiCall(ref _callLookupEntry);
            _callSearchEntries = clientHelper.BuildApiCall<SearchEntriesRequest, SearchEntriesResponse>("SearchEntries", grpcClient.SearchEntriesAsync, grpcClient.SearchEntries, effectiveSettings.SearchEntriesSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSearchEntries);
            Modify_SearchEntriesApiCall(ref _callSearchEntries);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateEntryTypeApiCall(ref gaxgrpc::ApiCall<CreateEntryTypeRequest, lro::Operation> call);

        partial void Modify_UpdateEntryTypeApiCall(ref gaxgrpc::ApiCall<UpdateEntryTypeRequest, lro::Operation> call);

        partial void Modify_DeleteEntryTypeApiCall(ref gaxgrpc::ApiCall<DeleteEntryTypeRequest, lro::Operation> call);

        partial void Modify_ListEntryTypesApiCall(ref gaxgrpc::ApiCall<ListEntryTypesRequest, ListEntryTypesResponse> call);

        partial void Modify_GetEntryTypeApiCall(ref gaxgrpc::ApiCall<GetEntryTypeRequest, EntryType> call);

        partial void Modify_CreateAspectTypeApiCall(ref gaxgrpc::ApiCall<CreateAspectTypeRequest, lro::Operation> call);

        partial void Modify_UpdateAspectTypeApiCall(ref gaxgrpc::ApiCall<UpdateAspectTypeRequest, lro::Operation> call);

        partial void Modify_DeleteAspectTypeApiCall(ref gaxgrpc::ApiCall<DeleteAspectTypeRequest, lro::Operation> call);

        partial void Modify_ListAspectTypesApiCall(ref gaxgrpc::ApiCall<ListAspectTypesRequest, ListAspectTypesResponse> call);

        partial void Modify_GetAspectTypeApiCall(ref gaxgrpc::ApiCall<GetAspectTypeRequest, AspectType> call);

        partial void Modify_CreateEntryGroupApiCall(ref gaxgrpc::ApiCall<CreateEntryGroupRequest, lro::Operation> call);

        partial void Modify_UpdateEntryGroupApiCall(ref gaxgrpc::ApiCall<UpdateEntryGroupRequest, lro::Operation> call);

        partial void Modify_DeleteEntryGroupApiCall(ref gaxgrpc::ApiCall<DeleteEntryGroupRequest, lro::Operation> call);

        partial void Modify_ListEntryGroupsApiCall(ref gaxgrpc::ApiCall<ListEntryGroupsRequest, ListEntryGroupsResponse> call);

        partial void Modify_GetEntryGroupApiCall(ref gaxgrpc::ApiCall<GetEntryGroupRequest, EntryGroup> call);

        partial void Modify_CreateEntryApiCall(ref gaxgrpc::ApiCall<CreateEntryRequest, Entry> call);

        partial void Modify_UpdateEntryApiCall(ref gaxgrpc::ApiCall<UpdateEntryRequest, Entry> call);

        partial void Modify_DeleteEntryApiCall(ref gaxgrpc::ApiCall<DeleteEntryRequest, Entry> call);

        partial void Modify_ListEntriesApiCall(ref gaxgrpc::ApiCall<ListEntriesRequest, ListEntriesResponse> call);

        partial void Modify_GetEntryApiCall(ref gaxgrpc::ApiCall<GetEntryRequest, Entry> call);

        partial void Modify_LookupEntryApiCall(ref gaxgrpc::ApiCall<LookupEntryRequest, Entry> call);

        partial void Modify_SearchEntriesApiCall(ref gaxgrpc::ApiCall<SearchEntriesRequest, SearchEntriesResponse> call);

        partial void OnConstruction(CatalogService.CatalogServiceClient grpcClient, CatalogServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CatalogService client</summary>
        public override CatalogService.CatalogServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_CreateEntryTypeRequest(ref CreateEntryTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntryTypeRequest(ref UpdateEntryTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntryTypeRequest(ref DeleteEntryTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntryTypesRequest(ref ListEntryTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntryTypeRequest(ref GetEntryTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAspectTypeRequest(ref CreateAspectTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateAspectTypeRequest(ref UpdateAspectTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteAspectTypeRequest(ref DeleteAspectTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAspectTypesRequest(ref ListAspectTypesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetAspectTypeRequest(ref GetAspectTypeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntryGroupRequest(ref CreateEntryGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntryGroupRequest(ref UpdateEntryGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntryGroupRequest(ref DeleteEntryGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntryGroupsRequest(ref ListEntryGroupsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntryGroupRequest(ref GetEntryGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEntryRequest(ref CreateEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEntryRequest(ref UpdateEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEntryRequest(ref DeleteEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEntriesRequest(ref ListEntriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEntryRequest(ref GetEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LookupEntryRequest(ref LookupEntryRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchEntriesRequest(ref SearchEntriesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>The long-running operations client for <c>CreateEntryType</c>.</summary>
        public override lro::OperationsClient CreateEntryTypeOperationsClient { get; }

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EntryType, OperationMetadata> CreateEntryType(CreateEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryTypeRequest(ref request, ref callSettings);
            return new lro::Operation<EntryType, OperationMetadata>(_callCreateEntryType.Sync(request, callSettings), CreateEntryTypeOperationsClient);
        }

        /// <summary>
        /// Creates an EntryType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EntryType, OperationMetadata>> CreateEntryTypeAsync(CreateEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryTypeRequest(ref request, ref callSettings);
            return new lro::Operation<EntryType, OperationMetadata>(await _callCreateEntryType.Async(request, callSettings).ConfigureAwait(false), CreateEntryTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEntryType</c>.</summary>
        public override lro::OperationsClient UpdateEntryTypeOperationsClient { get; }

        /// <summary>
        /// Updates a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EntryType, OperationMetadata> UpdateEntryType(UpdateEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryTypeRequest(ref request, ref callSettings);
            return new lro::Operation<EntryType, OperationMetadata>(_callUpdateEntryType.Sync(request, callSettings), UpdateEntryTypeOperationsClient);
        }

        /// <summary>
        /// Updates a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EntryType, OperationMetadata>> UpdateEntryTypeAsync(UpdateEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryTypeRequest(ref request, ref callSettings);
            return new lro::Operation<EntryType, OperationMetadata>(await _callUpdateEntryType.Async(request, callSettings).ConfigureAwait(false), UpdateEntryTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEntryType</c>.</summary>
        public override lro::OperationsClient DeleteEntryTypeOperationsClient { get; }

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEntryType(DeleteEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryTypeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEntryType.Sync(request, callSettings), DeleteEntryTypeOperationsClient);
        }

        /// <summary>
        /// Deletes a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryTypeAsync(DeleteEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryTypeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEntryType.Async(request, callSettings).ConfigureAwait(false), DeleteEntryTypeOperationsClient);
        }

        /// <summary>
        /// Lists EntryType resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntryType"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntryTypesResponse, EntryType> ListEntryTypes(ListEntryTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntryTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntryTypesRequest, ListEntryTypesResponse, EntryType>(_callListEntryTypes, request, callSettings);
        }

        /// <summary>
        /// Lists EntryType resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntryType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntryTypesResponse, EntryType> ListEntryTypesAsync(ListEntryTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntryTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntryTypesRequest, ListEntryTypesResponse, EntryType>(_callListEntryTypes, request, callSettings);
        }

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntryType GetEntryType(GetEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryTypeRequest(ref request, ref callSettings);
            return _callGetEntryType.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a EntryType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntryType> GetEntryTypeAsync(GetEntryTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryTypeRequest(ref request, ref callSettings);
            return _callGetEntryType.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateAspectType</c>.</summary>
        public override lro::OperationsClient CreateAspectTypeOperationsClient { get; }

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AspectType, OperationMetadata> CreateAspectType(CreateAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAspectTypeRequest(ref request, ref callSettings);
            return new lro::Operation<AspectType, OperationMetadata>(_callCreateAspectType.Sync(request, callSettings), CreateAspectTypeOperationsClient);
        }

        /// <summary>
        /// Creates an AspectType
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AspectType, OperationMetadata>> CreateAspectTypeAsync(CreateAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAspectTypeRequest(ref request, ref callSettings);
            return new lro::Operation<AspectType, OperationMetadata>(await _callCreateAspectType.Async(request, callSettings).ConfigureAwait(false), CreateAspectTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateAspectType</c>.</summary>
        public override lro::OperationsClient UpdateAspectTypeOperationsClient { get; }

        /// <summary>
        /// Updates a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<AspectType, OperationMetadata> UpdateAspectType(UpdateAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAspectTypeRequest(ref request, ref callSettings);
            return new lro::Operation<AspectType, OperationMetadata>(_callUpdateAspectType.Sync(request, callSettings), UpdateAspectTypeOperationsClient);
        }

        /// <summary>
        /// Updates a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<AspectType, OperationMetadata>> UpdateAspectTypeAsync(UpdateAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateAspectTypeRequest(ref request, ref callSettings);
            return new lro::Operation<AspectType, OperationMetadata>(await _callUpdateAspectType.Async(request, callSettings).ConfigureAwait(false), UpdateAspectTypeOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteAspectType</c>.</summary>
        public override lro::OperationsClient DeleteAspectTypeOperationsClient { get; }

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteAspectType(DeleteAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAspectTypeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteAspectType.Sync(request, callSettings), DeleteAspectTypeOperationsClient);
        }

        /// <summary>
        /// Deletes a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteAspectTypeAsync(DeleteAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteAspectTypeRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteAspectType.Async(request, callSettings).ConfigureAwait(false), DeleteAspectTypeOperationsClient);
        }

        /// <summary>
        /// Lists AspectType resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="AspectType"/> resources.</returns>
        public override gax::PagedEnumerable<ListAspectTypesResponse, AspectType> ListAspectTypes(ListAspectTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAspectTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListAspectTypesRequest, ListAspectTypesResponse, AspectType>(_callListAspectTypes, request, callSettings);
        }

        /// <summary>
        /// Lists AspectType resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="AspectType"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListAspectTypesResponse, AspectType> ListAspectTypesAsync(ListAspectTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAspectTypesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListAspectTypesRequest, ListAspectTypesResponse, AspectType>(_callListAspectTypes, request, callSettings);
        }

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AspectType GetAspectType(GetAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAspectTypeRequest(ref request, ref callSettings);
            return _callGetAspectType.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a AspectType resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AspectType> GetAspectTypeAsync(GetAspectTypeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAspectTypeRequest(ref request, ref callSettings);
            return _callGetAspectType.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateEntryGroup</c>.</summary>
        public override lro::OperationsClient CreateEntryGroupOperationsClient { get; }

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EntryGroup, OperationMetadata> CreateEntryGroup(CreateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryGroupRequest(ref request, ref callSettings);
            return new lro::Operation<EntryGroup, OperationMetadata>(_callCreateEntryGroup.Sync(request, callSettings), CreateEntryGroupOperationsClient);
        }

        /// <summary>
        /// Creates an EntryGroup
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EntryGroup, OperationMetadata>> CreateEntryGroupAsync(CreateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryGroupRequest(ref request, ref callSettings);
            return new lro::Operation<EntryGroup, OperationMetadata>(await _callCreateEntryGroup.Async(request, callSettings).ConfigureAwait(false), CreateEntryGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateEntryGroup</c>.</summary>
        public override lro::OperationsClient UpdateEntryGroupOperationsClient { get; }

        /// <summary>
        /// Updates a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<EntryGroup, OperationMetadata> UpdateEntryGroup(UpdateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryGroupRequest(ref request, ref callSettings);
            return new lro::Operation<EntryGroup, OperationMetadata>(_callUpdateEntryGroup.Sync(request, callSettings), UpdateEntryGroupOperationsClient);
        }

        /// <summary>
        /// Updates a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<EntryGroup, OperationMetadata>> UpdateEntryGroupAsync(UpdateEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryGroupRequest(ref request, ref callSettings);
            return new lro::Operation<EntryGroup, OperationMetadata>(await _callUpdateEntryGroup.Async(request, callSettings).ConfigureAwait(false), UpdateEntryGroupOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteEntryGroup</c>.</summary>
        public override lro::OperationsClient DeleteEntryGroupOperationsClient { get; }

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteEntryGroup(DeleteEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteEntryGroup.Sync(request, callSettings), DeleteEntryGroupOperationsClient);
        }

        /// <summary>
        /// Deletes a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteEntryGroupAsync(DeleteEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryGroupRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteEntryGroup.Async(request, callSettings).ConfigureAwait(false), DeleteEntryGroupOperationsClient);
        }

        /// <summary>
        /// Lists EntryGroup resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EntryGroup"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroups(ListEntryGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntryGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntryGroupsRequest, ListEntryGroupsResponse, EntryGroup>(_callListEntryGroups, request, callSettings);
        }

        /// <summary>
        /// Lists EntryGroup resources in a project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="EntryGroup"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntryGroupsResponse, EntryGroup> ListEntryGroupsAsync(ListEntryGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntryGroupsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntryGroupsRequest, ListEntryGroupsResponse, EntryGroup>(_callListEntryGroups, request, callSettings);
        }

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EntryGroup GetEntryGroup(GetEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryGroupRequest(ref request, ref callSettings);
            return _callGetEntryGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a EntryGroup resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EntryGroup> GetEntryGroupAsync(GetEntryGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryGroupRequest(ref request, ref callSettings);
            return _callGetEntryGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry CreateEntry(CreateEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryRequest(ref request, ref callSettings);
            return _callCreateEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> CreateEntryAsync(CreateEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEntryRequest(ref request, ref callSettings);
            return _callCreateEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Updates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry UpdateEntry(UpdateEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryRequest(ref request, ref callSettings);
            return _callUpdateEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> UpdateEntryAsync(UpdateEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEntryRequest(ref request, ref callSettings);
            return _callUpdateEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry DeleteEntry(DeleteEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryRequest(ref request, ref callSettings);
            return _callDeleteEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes an Entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> DeleteEntryAsync(DeleteEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEntryRequest(ref request, ref callSettings);
            return _callDeleteEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Lists entries within an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Entry"/> resources.</returns>
        public override gax::PagedEnumerable<ListEntriesResponse, Entry> ListEntries(ListEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEntriesRequest, ListEntriesResponse, Entry>(_callListEntries, request, callSettings);
        }

        /// <summary>
        /// Lists entries within an entry group.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Entry"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListEntriesResponse, Entry> ListEntriesAsync(ListEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEntriesRequest, ListEntriesResponse, Entry>(_callListEntries, request, callSettings);
        }

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry GetEntry(GetEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryRequest(ref request, ref callSettings);
            return _callGetEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> GetEntryAsync(GetEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEntryRequest(ref request, ref callSettings);
            return _callGetEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Looks up a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Entry LookupEntry(LookupEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEntryRequest(ref request, ref callSettings);
            return _callLookupEntry.Sync(request, callSettings);
        }

        /// <summary>
        /// Looks up a single entry.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Entry> LookupEntryAsync(LookupEntryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LookupEntryRequest(ref request, ref callSettings);
            return _callLookupEntry.Async(request, callSettings);
        }

        /// <summary>
        /// Searches for entries matching given query and scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SearchEntriesResult"/> resources.</returns>
        public override gax::PagedEnumerable<SearchEntriesResponse, SearchEntriesResult> SearchEntries(SearchEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchEntriesRequest, SearchEntriesResponse, SearchEntriesResult>(_callSearchEntries, request, callSettings);
        }

        /// <summary>
        /// Searches for entries matching given query and scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SearchEntriesResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchEntriesResponse, SearchEntriesResult> SearchEntriesAsync(SearchEntriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchEntriesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchEntriesRequest, SearchEntriesResponse, SearchEntriesResult>(_callSearchEntries, request, callSettings);
        }
    }

    public partial class ListEntryTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListAspectTypesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntryGroupsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchEntriesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEntryTypesResponse : gaxgrpc::IPageResponse<EntryType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EntryType> GetEnumerator() => EntryTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListAspectTypesResponse : gaxgrpc::IPageResponse<AspectType>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<AspectType> GetEnumerator() => AspectTypes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEntryGroupsResponse : gaxgrpc::IPageResponse<EntryGroup>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EntryGroup> GetEnumerator() => EntryGroups.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEntriesResponse : gaxgrpc::IPageResponse<Entry>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Entry> GetEnumerator() => Entries.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class SearchEntriesResponse : gaxgrpc::IPageResponse<SearchEntriesResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SearchEntriesResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CatalogService
    {
        public partial class CatalogServiceClient
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

    public static partial class CatalogService
    {
        public partial class CatalogServiceClient
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
