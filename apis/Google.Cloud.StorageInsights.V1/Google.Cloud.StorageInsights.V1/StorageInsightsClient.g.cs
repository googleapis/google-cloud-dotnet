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

namespace Google.Cloud.StorageInsights.V1
{
    /// <summary>Settings for <see cref="StorageInsightsClient"/> instances.</summary>
    public sealed partial class StorageInsightsSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="StorageInsightsSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="StorageInsightsSettings"/>.</returns>
        public static StorageInsightsSettings GetDefault() => new StorageInsightsSettings();

        /// <summary>Constructs a new <see cref="StorageInsightsSettings"/> object with default settings.</summary>
        public StorageInsightsSettings()
        {
        }

        private StorageInsightsSettings(StorageInsightsSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListReportConfigsSettings = existing.ListReportConfigsSettings;
            GetReportConfigSettings = existing.GetReportConfigSettings;
            CreateReportConfigSettings = existing.CreateReportConfigSettings;
            UpdateReportConfigSettings = existing.UpdateReportConfigSettings;
            DeleteReportConfigSettings = existing.DeleteReportConfigSettings;
            ListReportDetailsSettings = existing.ListReportDetailsSettings;
            GetReportDetailSettings = existing.GetReportDetailSettings;
            ListDatasetConfigsSettings = existing.ListDatasetConfigsSettings;
            GetDatasetConfigSettings = existing.GetDatasetConfigSettings;
            CreateDatasetConfigSettings = existing.CreateDatasetConfigSettings;
            CreateDatasetConfigOperationsSettings = existing.CreateDatasetConfigOperationsSettings.Clone();
            UpdateDatasetConfigSettings = existing.UpdateDatasetConfigSettings;
            UpdateDatasetConfigOperationsSettings = existing.UpdateDatasetConfigOperationsSettings.Clone();
            DeleteDatasetConfigSettings = existing.DeleteDatasetConfigSettings;
            DeleteDatasetConfigOperationsSettings = existing.DeleteDatasetConfigOperationsSettings.Clone();
            LinkDatasetSettings = existing.LinkDatasetSettings;
            LinkDatasetOperationsSettings = existing.LinkDatasetOperationsSettings.Clone();
            UnlinkDatasetSettings = existing.UnlinkDatasetSettings;
            UnlinkDatasetOperationsSettings = existing.UnlinkDatasetOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(StorageInsightsSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.ListReportConfigs</c> and <c>StorageInsightsClient.ListReportConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReportConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.GetReportConfig</c> and <c>StorageInsightsClient.GetReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReportConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.CreateReportConfig</c> and <c>StorageInsightsClient.CreateReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.UpdateReportConfig</c> and <c>StorageInsightsClient.UpdateReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.DeleteReportConfig</c> and <c>StorageInsightsClient.DeleteReportConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReportConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.ListReportDetails</c> and <c>StorageInsightsClient.ListReportDetailsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReportDetailsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.GetReportDetail</c> and <c>StorageInsightsClient.GetReportDetailAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReportDetailSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.ListDatasetConfigs</c> and <c>StorageInsightsClient.ListDatasetConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDatasetConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.GetDatasetConfig</c> and <c>StorageInsightsClient.GetDatasetConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDatasetConfigSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.CreateDatasetConfig</c> and <c>StorageInsightsClient.CreateDatasetConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateDatasetConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageInsightsClient.CreateDatasetConfig</c> and
        /// <c>StorageInsightsClient.CreateDatasetConfigAsync</c>.
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
        public lro::OperationsSettings CreateDatasetConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.UpdateDatasetConfig</c> and <c>StorageInsightsClient.UpdateDatasetConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateDatasetConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageInsightsClient.UpdateDatasetConfig</c> and
        /// <c>StorageInsightsClient.UpdateDatasetConfigAsync</c>.
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
        public lro::OperationsSettings UpdateDatasetConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.DeleteDatasetConfig</c> and <c>StorageInsightsClient.DeleteDatasetConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteDatasetConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageInsightsClient.DeleteDatasetConfig</c> and
        /// <c>StorageInsightsClient.DeleteDatasetConfigAsync</c>.
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
        public lro::OperationsSettings DeleteDatasetConfigOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.LinkDataset</c> and <c>StorageInsightsClient.LinkDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings LinkDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageInsightsClient.LinkDataset</c> and
        /// <c>StorageInsightsClient.LinkDatasetAsync</c>.
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
        public lro::OperationsSettings LinkDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>StorageInsightsClient.UnlinkDataset</c> and <c>StorageInsightsClient.UnlinkDatasetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 1000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>.</description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UnlinkDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>StorageInsightsClient.UnlinkDataset</c> and
        /// <c>StorageInsightsClient.UnlinkDatasetAsync</c>.
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
        public lro::OperationsSettings UnlinkDatasetOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="StorageInsightsSettings"/> object.</returns>
        public StorageInsightsSettings Clone() => new StorageInsightsSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="StorageInsightsClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class StorageInsightsClientBuilder : gaxgrpc::ClientBuilderBase<StorageInsightsClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public StorageInsightsSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public StorageInsightsClientBuilder() : base(StorageInsightsClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref StorageInsightsClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<StorageInsightsClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override StorageInsightsClient Build()
        {
            StorageInsightsClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<StorageInsightsClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<StorageInsightsClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private StorageInsightsClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return StorageInsightsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<StorageInsightsClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return StorageInsightsClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => StorageInsightsClient.ChannelPool;
    }

    /// <summary>StorageInsights client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class StorageInsightsClient
    {
        /// <summary>
        /// The default endpoint for the StorageInsights service, which is a host of "storageinsights.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "storageinsights.googleapis.com:443";

        /// <summary>The default StorageInsights scopes.</summary>
        /// <remarks>
        /// The default StorageInsights scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(StorageInsights.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="StorageInsightsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StorageInsightsClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="StorageInsightsClient"/>.</returns>
        public static stt::Task<StorageInsightsClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new StorageInsightsClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="StorageInsightsClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="StorageInsightsClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="StorageInsightsClient"/>.</returns>
        public static StorageInsightsClient Create() => new StorageInsightsClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="StorageInsightsClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="StorageInsightsSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="StorageInsightsClient"/>.</returns>
        internal static StorageInsightsClient Create(grpccore::CallInvoker callInvoker, StorageInsightsSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            StorageInsights.StorageInsightsClient grpcClient = new StorageInsights.StorageInsightsClient(callInvoker);
            return new StorageInsightsClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC StorageInsights client</summary>
        public virtual StorageInsights.StorageInsightsClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportConfigsRequest
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
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportConfigsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportConfigsRequest
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
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportConfigsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportConfigsRequest request = new ListReportConfigsRequest
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
            return ListReportConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfig(new GetReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfigAsync(new GetReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig GetReportConfig(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfig(new GetReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportConfigAsync(new GetReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> GetReportConfigAsync(ReportConfigName name, st::CancellationToken cancellationToken) =>
            GetReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig CreateReportConfig(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(CreateReportConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig CreateReportConfig(string parent, ReportConfig reportConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfig(new CreateReportConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(string parent, ReportConfig reportConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfigAsync(new CreateReportConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(string parent, ReportConfig reportConfig, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(parent, reportConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig CreateReportConfig(gagr::LocationName parent, ReportConfig reportConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfig(new CreateReportConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(gagr::LocationName parent, ReportConfig reportConfig, gaxgrpc::CallSettings callSettings = null) =>
            CreateReportConfigAsync(new CreateReportConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="reportConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> CreateReportConfigAsync(gagr::LocationName parent, ReportConfig reportConfig, st::CancellationToken cancellationToken) =>
            CreateReportConfigAsync(parent, reportConfig, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig UpdateReportConfig(UpdateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> UpdateReportConfigAsync(UpdateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> UpdateReportConfigAsync(UpdateReportConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="reportConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ReportConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportConfig UpdateReportConfig(ReportConfig reportConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReportConfig(new UpdateReportConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="reportConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ReportConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> UpdateReportConfigAsync(ReportConfig reportConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReportConfigAsync(new UpdateReportConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ReportConfig = gax::GaxPreconditions.CheckNotNull(reportConfig, nameof(reportConfig)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="reportConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ReportConfig resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportConfig> UpdateReportConfigAsync(ReportConfig reportConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReportConfigAsync(reportConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReportConfig(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(DeleteReportConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReportConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfig(new DeleteReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfigAsync(new DeleteReportConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteReportConfig(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfig(new DeleteReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(ReportConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReportConfigAsync(new DeleteReportConfigRequest
            {
                ReportConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteReportConfigAsync(ReportConfigName name, st::CancellationToken cancellationToken) =>
            DeleteReportConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetails(ListReportDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetailsAsync(ListReportDetailsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportDetailsRequest
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
        /// <returns>A pageable sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetails(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportDetailsRequest request = new ListReportDetailsRequest
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
            return ListReportDetails(request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportDetailsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetailsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportDetailsRequest request = new ListReportDetailsRequest
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
            return ListReportDetailsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportDetailsRequest
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
        /// <returns>A pageable sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetails(ReportConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportDetailsRequest request = new ListReportDetailsRequest
            {
                ParentAsReportConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReportDetails(request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReportDetailsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReportDetail"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetailsAsync(ReportConfigName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReportDetailsRequest request = new ListReportDetailsRequest
            {
                ParentAsReportConfigName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReportDetailsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportDetail GetReportDetail(GetReportDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(GetReportDetailRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(GetReportDetailRequest request, st::CancellationToken cancellationToken) =>
            GetReportDetailAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportDetail GetReportDetail(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportDetail(new GetReportDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportDetailAsync(new GetReportDetailRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(string name, st::CancellationToken cancellationToken) =>
            GetReportDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReportDetail GetReportDetail(ReportDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportDetail(new GetReportDetailRequest
            {
                ReportDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(ReportDetailName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReportDetailAsync(new GetReportDetailRequest
            {
                ReportDetailName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReportDetail> GetReportDetailAsync(ReportDetailName name, st::CancellationToken cancellationToken) =>
            GetReportDetailAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists the dataset configurations in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatasetConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetConfigsResponse, DatasetConfig> ListDatasetConfigs(ListDatasetConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the dataset configurations in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatasetConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetConfigsResponse, DatasetConfig> ListDatasetConfigsAsync(ListDatasetConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists the dataset configurations in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDatasetConfigsRequest
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
        /// <returns>A pageable sequence of <see cref="DatasetConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetConfigsResponse, DatasetConfig> ListDatasetConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetConfigsRequest request = new ListDatasetConfigsRequest
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
            return ListDatasetConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the dataset configurations in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDatasetConfigsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="DatasetConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetConfigsResponse, DatasetConfig> ListDatasetConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetConfigsRequest request = new ListDatasetConfigsRequest
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
            return ListDatasetConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists the dataset configurations in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDatasetConfigsRequest
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
        /// <returns>A pageable sequence of <see cref="DatasetConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetConfigsResponse, DatasetConfig> ListDatasetConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetConfigsRequest request = new ListDatasetConfigsRequest
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
            return ListDatasetConfigs(request, callSettings);
        }

        /// <summary>
        /// Lists the dataset configurations in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListDatasetConfigsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="DatasetConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetConfigsResponse, DatasetConfig> ListDatasetConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetConfigsRequest request = new ListDatasetConfigsRequest
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
            return ListDatasetConfigsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatasetConfig GetDatasetConfig(GetDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetConfig> GetDatasetConfigAsync(GetDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetConfig> GetDatasetConfigAsync(GetDatasetConfigRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatasetConfig GetDatasetConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetConfig(new GetDatasetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetConfig> GetDatasetConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetConfigAsync(new GetDatasetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetConfig> GetDatasetConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual DatasetConfig GetDatasetConfig(DatasetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetConfig(new GetDatasetConfigRequest
            {
                DatasetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetConfig> GetDatasetConfigAsync(DatasetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetConfigAsync(new GetDatasetConfigRequest
            {
                DatasetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<DatasetConfig> GetDatasetConfigAsync(DatasetConfigName name, st::CancellationToken cancellationToken) =>
            GetDatasetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatasetConfig, OperationMetadata> CreateDatasetConfig(CreateDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> CreateDatasetConfigAsync(CreateDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> CreateDatasetConfigAsync(CreateDatasetConfigRequest request, st::CancellationToken cancellationToken) =>
            CreateDatasetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDatasetConfig</c>.</summary>
        public virtual lro::OperationsClient CreateDatasetConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDatasetConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DatasetConfig, OperationMetadata> PollOnceCreateDatasetConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DatasetConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatasetConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDatasetConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> PollOnceCreateDatasetConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DatasetConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDatasetConfigOperationsClient, callSettings);

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="datasetConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="datasetConfigId">
        /// Required. ID of the requesting object.
        /// If auto-generating ID is enabled on the server-side, remove this field and
        /// `dataset_config_id` from the method_signature of Create RPC
        /// Note: The value should not contain any hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatasetConfig, OperationMetadata> CreateDatasetConfig(string parent, DatasetConfig datasetConfig, string datasetConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetConfig(new CreateDatasetConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DatasetConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetConfigId, nameof(datasetConfigId)),
                DatasetConfig = gax::GaxPreconditions.CheckNotNull(datasetConfig, nameof(datasetConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="datasetConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="datasetConfigId">
        /// Required. ID of the requesting object.
        /// If auto-generating ID is enabled on the server-side, remove this field and
        /// `dataset_config_id` from the method_signature of Create RPC
        /// Note: The value should not contain any hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> CreateDatasetConfigAsync(string parent, DatasetConfig datasetConfig, string datasetConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetConfigAsync(new CreateDatasetConfigRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DatasetConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetConfigId, nameof(datasetConfigId)),
                DatasetConfig = gax::GaxPreconditions.CheckNotNull(datasetConfig, nameof(datasetConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="datasetConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="datasetConfigId">
        /// Required. ID of the requesting object.
        /// If auto-generating ID is enabled on the server-side, remove this field and
        /// `dataset_config_id` from the method_signature of Create RPC
        /// Note: The value should not contain any hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> CreateDatasetConfigAsync(string parent, DatasetConfig datasetConfig, string datasetConfigId, st::CancellationToken cancellationToken) =>
            CreateDatasetConfigAsync(parent, datasetConfig, datasetConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="datasetConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="datasetConfigId">
        /// Required. ID of the requesting object.
        /// If auto-generating ID is enabled on the server-side, remove this field and
        /// `dataset_config_id` from the method_signature of Create RPC
        /// Note: The value should not contain any hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatasetConfig, OperationMetadata> CreateDatasetConfig(gagr::LocationName parent, DatasetConfig datasetConfig, string datasetConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetConfig(new CreateDatasetConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DatasetConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetConfigId, nameof(datasetConfigId)),
                DatasetConfig = gax::GaxPreconditions.CheckNotNull(datasetConfig, nameof(datasetConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="datasetConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="datasetConfigId">
        /// Required. ID of the requesting object.
        /// If auto-generating ID is enabled on the server-side, remove this field and
        /// `dataset_config_id` from the method_signature of Create RPC
        /// Note: The value should not contain any hyphens.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> CreateDatasetConfigAsync(gagr::LocationName parent, DatasetConfig datasetConfig, string datasetConfigId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDatasetConfigAsync(new CreateDatasetConfigRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DatasetConfigId = gax::GaxPreconditions.CheckNotNullOrEmpty(datasetConfigId, nameof(datasetConfigId)),
                DatasetConfig = gax::GaxPreconditions.CheckNotNull(datasetConfig, nameof(datasetConfig)),
            }, callSettings);

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="datasetConfig">
        /// Required. The resource being created
        /// </param>
        /// <param name="datasetConfigId">
        /// Required. ID of the requesting object.
        /// If auto-generating ID is enabled on the server-side, remove this field and
        /// `dataset_config_id` from the method_signature of Create RPC
        /// Note: The value should not contain any hyphens.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> CreateDatasetConfigAsync(gagr::LocationName parent, DatasetConfig datasetConfig, string datasetConfigId, st::CancellationToken cancellationToken) =>
            CreateDatasetConfigAsync(parent, datasetConfig, datasetConfigId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatasetConfig, OperationMetadata> UpdateDatasetConfig(UpdateDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> UpdateDatasetConfigAsync(UpdateDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> UpdateDatasetConfigAsync(UpdateDatasetConfigRequest request, st::CancellationToken cancellationToken) =>
            UpdateDatasetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDatasetConfig</c>.</summary>
        public virtual lro::OperationsClient UpdateDatasetConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDatasetConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<DatasetConfig, OperationMetadata> PollOnceUpdateDatasetConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DatasetConfig, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDatasetConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDatasetConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> PollOnceUpdateDatasetConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<DatasetConfig, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDatasetConfigOperationsClient, callSettings);

        /// <summary>
        /// Updates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="datasetConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `DatasetConfig` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not provide a mask then it returns an "Invalid Argument" error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<DatasetConfig, OperationMetadata> UpdateDatasetConfig(DatasetConfig datasetConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetConfig(new UpdateDatasetConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DatasetConfig = gax::GaxPreconditions.CheckNotNull(datasetConfig, nameof(datasetConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="datasetConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `DatasetConfig` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not provide a mask then it returns an "Invalid Argument" error.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> UpdateDatasetConfigAsync(DatasetConfig datasetConfig, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDatasetConfigAsync(new UpdateDatasetConfigRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                DatasetConfig = gax::GaxPreconditions.CheckNotNull(datasetConfig, nameof(datasetConfig)),
            }, callSettings);

        /// <summary>
        /// Updates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="datasetConfig">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// `DatasetConfig` resource by the update.
        /// The fields specified in the `update_mask` are relative to the resource, not
        /// the full request. A field is overwritten if it is in the mask. If the
        /// user does not provide a mask then it returns an "Invalid Argument" error.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> UpdateDatasetConfigAsync(DatasetConfig datasetConfig, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDatasetConfigAsync(datasetConfig, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDatasetConfig(DeleteDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetConfigAsync(DeleteDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetConfigAsync(DeleteDatasetConfigRequest request, st::CancellationToken cancellationToken) =>
            DeleteDatasetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDatasetConfig</c>.</summary>
        public virtual lro::OperationsClient DeleteDatasetConfigOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDatasetConfig</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteDatasetConfig(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatasetConfigOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDatasetConfig</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteDatasetConfigAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDatasetConfigOperationsClient, callSettings);

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDatasetConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetConfig(new DeleteDatasetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetConfigAsync(new DeleteDatasetConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetConfigAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDatasetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteDatasetConfig(DatasetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetConfig(new DeleteDatasetConfigRequest
            {
                DatasetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetConfigAsync(DatasetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDatasetConfigAsync(new DeleteDatasetConfigRequest
            {
                DatasetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetConfigAsync(DatasetConfigName name, st::CancellationToken cancellationToken) =>
            DeleteDatasetConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LinkDatasetResponse, OperationMetadata> LinkDataset(LinkDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LinkDatasetResponse, OperationMetadata>> LinkDatasetAsync(LinkDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LinkDatasetResponse, OperationMetadata>> LinkDatasetAsync(LinkDatasetRequest request, st::CancellationToken cancellationToken) =>
            LinkDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>LinkDataset</c>.</summary>
        public virtual lro::OperationsClient LinkDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LinkDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<LinkDatasetResponse, OperationMetadata> PollOnceLinkDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LinkDatasetResponse, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LinkDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>LinkDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<LinkDatasetResponse, OperationMetadata>> PollOnceLinkDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<LinkDatasetResponse, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LinkDatasetOperationsClient, callSettings);

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LinkDatasetResponse, OperationMetadata> LinkDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            LinkDataset(new LinkDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LinkDatasetResponse, OperationMetadata>> LinkDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            LinkDatasetAsync(new LinkDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LinkDatasetResponse, OperationMetadata>> LinkDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            LinkDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<LinkDatasetResponse, OperationMetadata> LinkDataset(DatasetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            LinkDataset(new LinkDatasetRequest
            {
                DatasetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LinkDatasetResponse, OperationMetadata>> LinkDatasetAsync(DatasetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            LinkDatasetAsync(new LinkDatasetRequest
            {
                DatasetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<LinkDatasetResponse, OperationMetadata>> LinkDatasetAsync(DatasetConfigName name, st::CancellationToken cancellationToken) =>
            LinkDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> UnlinkDataset(UnlinkDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UnlinkDatasetAsync(UnlinkDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UnlinkDatasetAsync(UnlinkDatasetRequest request, st::CancellationToken cancellationToken) =>
            UnlinkDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UnlinkDataset</c>.</summary>
        public virtual lro::OperationsClient UnlinkDatasetOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UnlinkDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceUnlinkDataset(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UnlinkDatasetOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UnlinkDataset</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceUnlinkDatasetAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UnlinkDatasetOperationsClient, callSettings);

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> UnlinkDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            UnlinkDataset(new UnlinkDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UnlinkDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UnlinkDatasetAsync(new UnlinkDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UnlinkDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            UnlinkDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> UnlinkDataset(DatasetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            UnlinkDataset(new UnlinkDatasetRequest
            {
                DatasetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UnlinkDatasetAsync(DatasetConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            UnlinkDatasetAsync(new UnlinkDatasetRequest
            {
                DatasetConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UnlinkDatasetAsync(DatasetConfigName name, st::CancellationToken cancellationToken) =>
            UnlinkDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>StorageInsights client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class StorageInsightsClientImpl : StorageInsightsClient
    {
        private readonly gaxgrpc::ApiCall<ListReportConfigsRequest, ListReportConfigsResponse> _callListReportConfigs;

        private readonly gaxgrpc::ApiCall<GetReportConfigRequest, ReportConfig> _callGetReportConfig;

        private readonly gaxgrpc::ApiCall<CreateReportConfigRequest, ReportConfig> _callCreateReportConfig;

        private readonly gaxgrpc::ApiCall<UpdateReportConfigRequest, ReportConfig> _callUpdateReportConfig;

        private readonly gaxgrpc::ApiCall<DeleteReportConfigRequest, wkt::Empty> _callDeleteReportConfig;

        private readonly gaxgrpc::ApiCall<ListReportDetailsRequest, ListReportDetailsResponse> _callListReportDetails;

        private readonly gaxgrpc::ApiCall<GetReportDetailRequest, ReportDetail> _callGetReportDetail;

        private readonly gaxgrpc::ApiCall<ListDatasetConfigsRequest, ListDatasetConfigsResponse> _callListDatasetConfigs;

        private readonly gaxgrpc::ApiCall<GetDatasetConfigRequest, DatasetConfig> _callGetDatasetConfig;

        private readonly gaxgrpc::ApiCall<CreateDatasetConfigRequest, lro::Operation> _callCreateDatasetConfig;

        private readonly gaxgrpc::ApiCall<UpdateDatasetConfigRequest, lro::Operation> _callUpdateDatasetConfig;

        private readonly gaxgrpc::ApiCall<DeleteDatasetConfigRequest, lro::Operation> _callDeleteDatasetConfig;

        private readonly gaxgrpc::ApiCall<LinkDatasetRequest, lro::Operation> _callLinkDataset;

        private readonly gaxgrpc::ApiCall<UnlinkDatasetRequest, lro::Operation> _callUnlinkDataset;

        /// <summary>
        /// Constructs a client wrapper for the StorageInsights service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="StorageInsightsSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public StorageInsightsClientImpl(StorageInsights.StorageInsightsClient grpcClient, StorageInsightsSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            StorageInsightsSettings effectiveSettings = settings ?? StorageInsightsSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDatasetConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDatasetConfigOperationsSettings, logger);
            UpdateDatasetConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDatasetConfigOperationsSettings, logger);
            DeleteDatasetConfigOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDatasetConfigOperationsSettings, logger);
            LinkDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.LinkDatasetOperationsSettings, logger);
            UnlinkDatasetOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UnlinkDatasetOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListReportConfigs = clientHelper.BuildApiCall<ListReportConfigsRequest, ListReportConfigsResponse>("ListReportConfigs", grpcClient.ListReportConfigsAsync, grpcClient.ListReportConfigs, effectiveSettings.ListReportConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReportConfigs);
            Modify_ListReportConfigsApiCall(ref _callListReportConfigs);
            _callGetReportConfig = clientHelper.BuildApiCall<GetReportConfigRequest, ReportConfig>("GetReportConfig", grpcClient.GetReportConfigAsync, grpcClient.GetReportConfig, effectiveSettings.GetReportConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReportConfig);
            Modify_GetReportConfigApiCall(ref _callGetReportConfig);
            _callCreateReportConfig = clientHelper.BuildApiCall<CreateReportConfigRequest, ReportConfig>("CreateReportConfig", grpcClient.CreateReportConfigAsync, grpcClient.CreateReportConfig, effectiveSettings.CreateReportConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateReportConfig);
            Modify_CreateReportConfigApiCall(ref _callCreateReportConfig);
            _callUpdateReportConfig = clientHelper.BuildApiCall<UpdateReportConfigRequest, ReportConfig>("UpdateReportConfig", grpcClient.UpdateReportConfigAsync, grpcClient.UpdateReportConfig, effectiveSettings.UpdateReportConfigSettings).WithGoogleRequestParam("report_config.name", request => request.ReportConfig?.Name);
            Modify_ApiCall(ref _callUpdateReportConfig);
            Modify_UpdateReportConfigApiCall(ref _callUpdateReportConfig);
            _callDeleteReportConfig = clientHelper.BuildApiCall<DeleteReportConfigRequest, wkt::Empty>("DeleteReportConfig", grpcClient.DeleteReportConfigAsync, grpcClient.DeleteReportConfig, effectiveSettings.DeleteReportConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteReportConfig);
            Modify_DeleteReportConfigApiCall(ref _callDeleteReportConfig);
            _callListReportDetails = clientHelper.BuildApiCall<ListReportDetailsRequest, ListReportDetailsResponse>("ListReportDetails", grpcClient.ListReportDetailsAsync, grpcClient.ListReportDetails, effectiveSettings.ListReportDetailsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReportDetails);
            Modify_ListReportDetailsApiCall(ref _callListReportDetails);
            _callGetReportDetail = clientHelper.BuildApiCall<GetReportDetailRequest, ReportDetail>("GetReportDetail", grpcClient.GetReportDetailAsync, grpcClient.GetReportDetail, effectiveSettings.GetReportDetailSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReportDetail);
            Modify_GetReportDetailApiCall(ref _callGetReportDetail);
            _callListDatasetConfigs = clientHelper.BuildApiCall<ListDatasetConfigsRequest, ListDatasetConfigsResponse>("ListDatasetConfigs", grpcClient.ListDatasetConfigsAsync, grpcClient.ListDatasetConfigs, effectiveSettings.ListDatasetConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatasetConfigs);
            Modify_ListDatasetConfigsApiCall(ref _callListDatasetConfigs);
            _callGetDatasetConfig = clientHelper.BuildApiCall<GetDatasetConfigRequest, DatasetConfig>("GetDatasetConfig", grpcClient.GetDatasetConfigAsync, grpcClient.GetDatasetConfig, effectiveSettings.GetDatasetConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDatasetConfig);
            Modify_GetDatasetConfigApiCall(ref _callGetDatasetConfig);
            _callCreateDatasetConfig = clientHelper.BuildApiCall<CreateDatasetConfigRequest, lro::Operation>("CreateDatasetConfig", grpcClient.CreateDatasetConfigAsync, grpcClient.CreateDatasetConfig, effectiveSettings.CreateDatasetConfigSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDatasetConfig);
            Modify_CreateDatasetConfigApiCall(ref _callCreateDatasetConfig);
            _callUpdateDatasetConfig = clientHelper.BuildApiCall<UpdateDatasetConfigRequest, lro::Operation>("UpdateDatasetConfig", grpcClient.UpdateDatasetConfigAsync, grpcClient.UpdateDatasetConfig, effectiveSettings.UpdateDatasetConfigSettings).WithGoogleRequestParam("dataset_config.name", request => request.DatasetConfig?.Name);
            Modify_ApiCall(ref _callUpdateDatasetConfig);
            Modify_UpdateDatasetConfigApiCall(ref _callUpdateDatasetConfig);
            _callDeleteDatasetConfig = clientHelper.BuildApiCall<DeleteDatasetConfigRequest, lro::Operation>("DeleteDatasetConfig", grpcClient.DeleteDatasetConfigAsync, grpcClient.DeleteDatasetConfig, effectiveSettings.DeleteDatasetConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDatasetConfig);
            Modify_DeleteDatasetConfigApiCall(ref _callDeleteDatasetConfig);
            _callLinkDataset = clientHelper.BuildApiCall<LinkDatasetRequest, lro::Operation>("LinkDataset", grpcClient.LinkDatasetAsync, grpcClient.LinkDataset, effectiveSettings.LinkDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callLinkDataset);
            Modify_LinkDatasetApiCall(ref _callLinkDataset);
            _callUnlinkDataset = clientHelper.BuildApiCall<UnlinkDatasetRequest, lro::Operation>("UnlinkDataset", grpcClient.UnlinkDatasetAsync, grpcClient.UnlinkDataset, effectiveSettings.UnlinkDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUnlinkDataset);
            Modify_UnlinkDatasetApiCall(ref _callUnlinkDataset);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListReportConfigsApiCall(ref gaxgrpc::ApiCall<ListReportConfigsRequest, ListReportConfigsResponse> call);

        partial void Modify_GetReportConfigApiCall(ref gaxgrpc::ApiCall<GetReportConfigRequest, ReportConfig> call);

        partial void Modify_CreateReportConfigApiCall(ref gaxgrpc::ApiCall<CreateReportConfigRequest, ReportConfig> call);

        partial void Modify_UpdateReportConfigApiCall(ref gaxgrpc::ApiCall<UpdateReportConfigRequest, ReportConfig> call);

        partial void Modify_DeleteReportConfigApiCall(ref gaxgrpc::ApiCall<DeleteReportConfigRequest, wkt::Empty> call);

        partial void Modify_ListReportDetailsApiCall(ref gaxgrpc::ApiCall<ListReportDetailsRequest, ListReportDetailsResponse> call);

        partial void Modify_GetReportDetailApiCall(ref gaxgrpc::ApiCall<GetReportDetailRequest, ReportDetail> call);

        partial void Modify_ListDatasetConfigsApiCall(ref gaxgrpc::ApiCall<ListDatasetConfigsRequest, ListDatasetConfigsResponse> call);

        partial void Modify_GetDatasetConfigApiCall(ref gaxgrpc::ApiCall<GetDatasetConfigRequest, DatasetConfig> call);

        partial void Modify_CreateDatasetConfigApiCall(ref gaxgrpc::ApiCall<CreateDatasetConfigRequest, lro::Operation> call);

        partial void Modify_UpdateDatasetConfigApiCall(ref gaxgrpc::ApiCall<UpdateDatasetConfigRequest, lro::Operation> call);

        partial void Modify_DeleteDatasetConfigApiCall(ref gaxgrpc::ApiCall<DeleteDatasetConfigRequest, lro::Operation> call);

        partial void Modify_LinkDatasetApiCall(ref gaxgrpc::ApiCall<LinkDatasetRequest, lro::Operation> call);

        partial void Modify_UnlinkDatasetApiCall(ref gaxgrpc::ApiCall<UnlinkDatasetRequest, lro::Operation> call);

        partial void OnConstruction(StorageInsights.StorageInsightsClient grpcClient, StorageInsightsSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC StorageInsights client</summary>
        public override StorageInsights.StorageInsightsClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListReportConfigsRequest(ref ListReportConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReportConfigRequest(ref GetReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReportConfigRequest(ref CreateReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReportConfigRequest(ref UpdateReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReportConfigRequest(ref DeleteReportConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReportDetailsRequest(ref ListReportDetailsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReportDetailRequest(ref GetReportDetailRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetConfigsRequest(ref ListDatasetConfigsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetConfigRequest(ref GetDatasetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDatasetConfigRequest(ref CreateDatasetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDatasetConfigRequest(ref UpdateDatasetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDatasetConfigRequest(ref DeleteDatasetConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LinkDatasetRequest(ref LinkDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnlinkDatasetRequest(ref UnlinkDatasetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigs(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReportConfigsRequest, ListReportConfigsResponse, ReportConfig>(_callListReportConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists ReportConfigs in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReportConfigsResponse, ReportConfig> ListReportConfigsAsync(ListReportConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReportConfigsRequest, ListReportConfigsResponse, ReportConfig>(_callListReportConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportConfig GetReportConfig(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportConfigRequest(ref request, ref callSettings);
            return _callGetReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportConfig> GetReportConfigAsync(GetReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportConfigRequest(ref request, ref callSettings);
            return _callGetReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportConfig CreateReportConfig(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportConfigRequest(ref request, ref callSettings);
            return _callCreateReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a new ReportConfig in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportConfig> CreateReportConfigAsync(CreateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReportConfigRequest(ref request, ref callSettings);
            return _callCreateReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportConfig UpdateReportConfig(UpdateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReportConfigRequest(ref request, ref callSettings);
            return _callUpdateReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportConfig> UpdateReportConfigAsync(UpdateReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReportConfigRequest(ref request, ref callSettings);
            return _callUpdateReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteReportConfig(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportConfigRequest(ref request, ref callSettings);
            _callDeleteReportConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes a single ReportConfig.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteReportConfigAsync(DeleteReportConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReportConfigRequest(ref request, ref callSettings);
            return _callDeleteReportConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReportDetail"/> resources.</returns>
        public override gax::PagedEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetails(ListReportDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReportDetailsRequest, ListReportDetailsResponse, ReportDetail>(_callListReportDetails, request, callSettings);
        }

        /// <summary>
        /// Lists ReportDetails in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReportDetail"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReportDetailsResponse, ReportDetail> ListReportDetailsAsync(ListReportDetailsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReportDetailsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReportDetailsRequest, ListReportDetailsResponse, ReportDetail>(_callListReportDetails, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReportDetail GetReportDetail(GetReportDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportDetailRequest(ref request, ref callSettings);
            return _callGetReportDetail.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ReportDetail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReportDetail> GetReportDetailAsync(GetReportDetailRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReportDetailRequest(ref request, ref callSettings);
            return _callGetReportDetail.Async(request, callSettings);
        }

        /// <summary>
        /// Lists the dataset configurations in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="DatasetConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatasetConfigsResponse, DatasetConfig> ListDatasetConfigs(ListDatasetConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatasetConfigsRequest, ListDatasetConfigsResponse, DatasetConfig>(_callListDatasetConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists the dataset configurations in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="DatasetConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatasetConfigsResponse, DatasetConfig> ListDatasetConfigsAsync(ListDatasetConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatasetConfigsRequest, ListDatasetConfigsResponse, DatasetConfig>(_callListDatasetConfigs, request, callSettings);
        }

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override DatasetConfig GetDatasetConfig(GetDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetConfigRequest(ref request, ref callSettings);
            return _callGetDatasetConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<DatasetConfig> GetDatasetConfigAsync(GetDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetConfigRequest(ref request, ref callSettings);
            return _callGetDatasetConfig.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDatasetConfig</c>.</summary>
        public override lro::OperationsClient CreateDatasetConfigOperationsClient { get; }

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DatasetConfig, OperationMetadata> CreateDatasetConfig(CreateDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetConfigRequest(ref request, ref callSettings);
            return new lro::Operation<DatasetConfig, OperationMetadata>(_callCreateDatasetConfig.Sync(request, callSettings), CreateDatasetConfigOperationsClient);
        }

        /// <summary>
        /// Creates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> CreateDatasetConfigAsync(CreateDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDatasetConfigRequest(ref request, ref callSettings);
            return new lro::Operation<DatasetConfig, OperationMetadata>(await _callCreateDatasetConfig.Async(request, callSettings).ConfigureAwait(false), CreateDatasetConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDatasetConfig</c>.</summary>
        public override lro::OperationsClient UpdateDatasetConfigOperationsClient { get; }

        /// <summary>
        /// Updates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<DatasetConfig, OperationMetadata> UpdateDatasetConfig(UpdateDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetConfigRequest(ref request, ref callSettings);
            return new lro::Operation<DatasetConfig, OperationMetadata>(_callUpdateDatasetConfig.Sync(request, callSettings), UpdateDatasetConfigOperationsClient);
        }

        /// <summary>
        /// Updates a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<DatasetConfig, OperationMetadata>> UpdateDatasetConfigAsync(UpdateDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDatasetConfigRequest(ref request, ref callSettings);
            return new lro::Operation<DatasetConfig, OperationMetadata>(await _callUpdateDatasetConfig.Async(request, callSettings).ConfigureAwait(false), UpdateDatasetConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDatasetConfig</c>.</summary>
        public override lro::OperationsClient DeleteDatasetConfigOperationsClient { get; }

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteDatasetConfig(DeleteDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteDatasetConfig.Sync(request, callSettings), DeleteDatasetConfigOperationsClient);
        }

        /// <summary>
        /// Deletes a dataset configuration in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteDatasetConfigAsync(DeleteDatasetConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDatasetConfigRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteDatasetConfig.Async(request, callSettings).ConfigureAwait(false), DeleteDatasetConfigOperationsClient);
        }

        /// <summary>The long-running operations client for <c>LinkDataset</c>.</summary>
        public override lro::OperationsClient LinkDatasetOperationsClient { get; }

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<LinkDatasetResponse, OperationMetadata> LinkDataset(LinkDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LinkDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<LinkDatasetResponse, OperationMetadata>(_callLinkDataset.Sync(request, callSettings), LinkDatasetOperationsClient);
        }

        /// <summary>
        /// Links a dataset to BigQuery in a given project for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<LinkDatasetResponse, OperationMetadata>> LinkDatasetAsync(LinkDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LinkDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<LinkDatasetResponse, OperationMetadata>(await _callLinkDataset.Async(request, callSettings).ConfigureAwait(false), LinkDatasetOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UnlinkDataset</c>.</summary>
        public override lro::OperationsClient UnlinkDatasetOperationsClient { get; }

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> UnlinkDataset(UnlinkDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnlinkDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callUnlinkDataset.Sync(request, callSettings), UnlinkDatasetOperationsClient);
        }

        /// <summary>
        /// Unlinks a dataset from BigQuery in a given project
        /// for a given location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> UnlinkDatasetAsync(UnlinkDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnlinkDatasetRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callUnlinkDataset.Async(request, callSettings).ConfigureAwait(false), UnlinkDatasetOperationsClient);
        }
    }

    public partial class ListReportConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportDetailsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReportConfigsResponse : gaxgrpc::IPageResponse<ReportConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReportConfig> GetEnumerator() => ReportConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReportDetailsResponse : gaxgrpc::IPageResponse<ReportDetail>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReportDetail> GetEnumerator() => ReportDetails.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatasetConfigsResponse : gaxgrpc::IPageResponse<DatasetConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<DatasetConfig> GetEnumerator() => DatasetConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class StorageInsights
    {
        public partial class StorageInsightsClient
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

    public static partial class StorageInsights
    {
        public partial class StorageInsightsClient
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
