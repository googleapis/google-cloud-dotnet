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

namespace Google.Cloud.Observability.V1
{
    /// <summary>Settings for <see cref="ObservabilityClient"/> instances.</summary>
    public sealed partial class ObservabilitySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ObservabilitySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ObservabilitySettings"/>.</returns>
        public static ObservabilitySettings GetDefault() => new ObservabilitySettings();

        /// <summary>Constructs a new <see cref="ObservabilitySettings"/> object with default settings.</summary>
        public ObservabilitySettings()
        {
        }

        private ObservabilitySettings(ObservabilitySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetScopeSettings = existing.GetScopeSettings;
            UpdateScopeSettings = existing.UpdateScopeSettings;
            GetBucketSettings = existing.GetBucketSettings;
            ListBucketsSettings = existing.ListBucketsSettings;
            CreateBucketSettings = existing.CreateBucketSettings;
            CreateBucketOperationsSettings = existing.CreateBucketOperationsSettings.Clone();
            UpdateBucketSettings = existing.UpdateBucketSettings;
            UpdateBucketOperationsSettings = existing.UpdateBucketOperationsSettings.Clone();
            GetDatasetSettings = existing.GetDatasetSettings;
            ListDatasetsSettings = existing.ListDatasetsSettings;
            GetViewSettings = existing.GetViewSettings;
            ListViewsSettings = existing.ListViewsSettings;
            GetLinkSettings = existing.GetLinkSettings;
            ListLinksSettings = existing.ListLinksSettings;
            CreateLinkSettings = existing.CreateLinkSettings;
            CreateLinkOperationsSettings = existing.CreateLinkOperationsSettings.Clone();
            UpdateLinkSettings = existing.UpdateLinkSettings;
            UpdateLinkOperationsSettings = existing.UpdateLinkOperationsSettings.Clone();
            DeleteLinkSettings = existing.DeleteLinkSettings;
            DeleteLinkOperationsSettings = existing.DeleteLinkOperationsSettings.Clone();
            GetTraceScopeSettings = existing.GetTraceScopeSettings;
            ListTraceScopesSettings = existing.ListTraceScopesSettings;
            CreateTraceScopeSettings = existing.CreateTraceScopeSettings;
            UpdateTraceScopeSettings = existing.UpdateTraceScopeSettings;
            DeleteTraceScopeSettings = existing.DeleteTraceScopeSettings;
            GetSettingsSettings = existing.GetSettingsSettings;
            UpdateSettingsSettings = existing.UpdateSettingsSettings;
            UpdateSettingsOperationsSettings = existing.UpdateSettingsOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ObservabilitySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.GetScope</c> and <c>ObservabilityClient.GetScopeAsync</c>.
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
        public gaxgrpc::CallSettings GetScopeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.UpdateScope</c> and <c>ObservabilityClient.UpdateScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.GetBucket</c> and <c>ObservabilityClient.GetBucketAsync</c>.
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
        public gaxgrpc::CallSettings GetBucketSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.ListBuckets</c> and <c>ObservabilityClient.ListBucketsAsync</c>.
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
        public gaxgrpc::CallSettings ListBucketsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.CreateBucket</c> and <c>ObservabilityClient.CreateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ObservabilityClient.CreateBucket</c> and
        /// <c>ObservabilityClient.CreateBucketAsync</c>.
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
        public lro::OperationsSettings CreateBucketOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.UpdateBucket</c> and <c>ObservabilityClient.UpdateBucketAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateBucketSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ObservabilityClient.UpdateBucket</c> and
        /// <c>ObservabilityClient.UpdateBucketAsync</c>.
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
        public lro::OperationsSettings UpdateBucketOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.GetDataset</c> and <c>ObservabilityClient.GetDatasetAsync</c>.
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
        public gaxgrpc::CallSettings GetDatasetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.ListDatasets</c> and <c>ObservabilityClient.ListDatasetsAsync</c>.
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
        public gaxgrpc::CallSettings ListDatasetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ObservabilityClient.GetView</c>
        ///  and <c>ObservabilityClient.GetViewAsync</c>.
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
        public gaxgrpc::CallSettings GetViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.ListViews</c> and <c>ObservabilityClient.ListViewsAsync</c>.
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
        public gaxgrpc::CallSettings ListViewsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ObservabilityClient.GetLink</c>
        ///  and <c>ObservabilityClient.GetLinkAsync</c>.
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
        public gaxgrpc::CallSettings GetLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.ListLinks</c> and <c>ObservabilityClient.ListLinksAsync</c>.
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
        public gaxgrpc::CallSettings ListLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.CreateLink</c> and <c>ObservabilityClient.CreateLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateLinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ObservabilityClient.CreateLink</c> and
        /// <c>ObservabilityClient.CreateLinkAsync</c>.
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
        public lro::OperationsSettings CreateLinkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.UpdateLink</c> and <c>ObservabilityClient.UpdateLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateLinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ObservabilityClient.UpdateLink</c> and
        /// <c>ObservabilityClient.UpdateLinkAsync</c>.
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
        public lro::OperationsSettings UpdateLinkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.DeleteLink</c> and <c>ObservabilityClient.DeleteLinkAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteLinkSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ObservabilityClient.DeleteLink</c> and
        /// <c>ObservabilityClient.DeleteLinkAsync</c>.
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
        public lro::OperationsSettings DeleteLinkOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.GetTraceScope</c> and <c>ObservabilityClient.GetTraceScopeAsync</c>.
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
        public gaxgrpc::CallSettings GetTraceScopeSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.ListTraceScopes</c> and <c>ObservabilityClient.ListTraceScopesAsync</c>.
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
        public gaxgrpc::CallSettings ListTraceScopesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.CreateTraceScope</c> and <c>ObservabilityClient.CreateTraceScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateTraceScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.UpdateTraceScope</c> and <c>ObservabilityClient.UpdateTraceScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateTraceScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.DeleteTraceScope</c> and <c>ObservabilityClient.DeleteTraceScopeAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteTraceScopeSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.GetSettings</c> and <c>ObservabilityClient.GetSettingsAsync</c>.
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
        public gaxgrpc::CallSettings GetSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ObservabilityClient.UpdateSettings</c> and <c>ObservabilityClient.UpdateSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ObservabilityClient.UpdateSettings</c> and
        /// <c>ObservabilityClient.UpdateSettingsAsync</c>.
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
        public lro::OperationsSettings UpdateSettingsOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ObservabilitySettings"/> object.</returns>
        public ObservabilitySettings Clone() => new ObservabilitySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ObservabilityClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ObservabilityClientBuilder : gaxgrpc::ClientBuilderBase<ObservabilityClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ObservabilitySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ObservabilityClientBuilder() : base(ObservabilityClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ObservabilityClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ObservabilityClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ObservabilityClient Build()
        {
            ObservabilityClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ObservabilityClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ObservabilityClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ObservabilityClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ObservabilityClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ObservabilityClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ObservabilityClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ObservabilityClient.ChannelPool;
    }

    /// <summary>Observability client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class ObservabilityClient
    {
        /// <summary>
        /// The default endpoint for the Observability service, which is a host of "observability.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "observability.googleapis.com:443";

        /// <summary>The default Observability scopes.</summary>
        /// <remarks>
        /// The default Observability scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Observability.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ObservabilityClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ObservabilityClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ObservabilityClient"/>.</returns>
        public static stt::Task<ObservabilityClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ObservabilityClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ObservabilityClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ObservabilityClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ObservabilityClient"/>.</returns>
        public static ObservabilityClient Create() => new ObservabilityClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ObservabilityClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ObservabilitySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ObservabilityClient"/>.</returns>
        internal static ObservabilityClient Create(grpccore::CallInvoker callInvoker, ObservabilitySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Observability.ObservabilityClient grpcClient = new Observability.ObservabilityClient(callInvoker);
            return new ObservabilityClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Observability client</summary>
        public virtual Observability.ObservabilityClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Scope GetScope(GetScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(GetScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(GetScopeRequest request, st::CancellationToken cancellationToken) =>
            GetScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. The format is:
        /// 
        /// projects/{project}/locations/{location}/scopes/{scope}
        /// 
        /// The `{location}` field must be set to `global`. The `{scope}` field must
        /// be set to `_Default`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Scope GetScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScope(new GetScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. The format is:
        /// 
        /// projects/{project}/locations/{location}/scopes/{scope}
        /// 
        /// The `{location}` field must be set to `global`. The `{scope}` field must
        /// be set to `_Default`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeAsync(new GetScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. The format is:
        /// 
        /// projects/{project}/locations/{location}/scopes/{scope}
        /// 
        /// The `{location}` field must be set to `global`. The `{scope}` field must
        /// be set to `_Default`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(string name, st::CancellationToken cancellationToken) =>
            GetScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. The format is:
        /// 
        /// projects/{project}/locations/{location}/scopes/{scope}
        /// 
        /// The `{location}` field must be set to `global`. The `{scope}` field must
        /// be set to `_Default`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Scope GetScope(ScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScope(new GetScopeRequest
            {
                ScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. The format is:
        /// 
        /// projects/{project}/locations/{location}/scopes/{scope}
        /// 
        /// The `{location}` field must be set to `global`. The `{scope}` field must
        /// be set to `_Default`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(ScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetScopeAsync(new GetScopeRequest
            {
                ScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource. The format is:
        /// 
        /// projects/{project}/locations/{location}/scopes/{scope}
        /// 
        /// The `{location}` field must be set to `global`. The `{scope}` field must
        /// be set to `_Default`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> GetScopeAsync(ScopeName name, st::CancellationToken cancellationToken) =>
            GetScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Scope UpdateScope(UpdateScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> UpdateScopeAsync(UpdateScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> UpdateScopeAsync(UpdateScopeRequest request, st::CancellationToken cancellationToken) =>
            UpdateScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Scope.
        /// </summary>
        /// <param name="scope">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Scope resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten when it is in the mask. If the
        /// user does not provide a mask, then all fields present in the request are
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Scope UpdateScope(Scope scope, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScope(new UpdateScopeRequest
            {
                UpdateMask = updateMask,
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Scope.
        /// </summary>
        /// <param name="scope">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Scope resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten when it is in the mask. If the
        /// user does not provide a mask, then all fields present in the request are
        /// overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> UpdateScopeAsync(Scope scope, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateScopeAsync(new UpdateScopeRequest
            {
                UpdateMask = updateMask,
                Scope = gax::GaxPreconditions.CheckNotNull(scope, nameof(scope)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Scope.
        /// </summary>
        /// <param name="scope">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Scope resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field is overwritten when it is in the mask. If the
        /// user does not provide a mask, then all fields present in the request are
        /// overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Scope> UpdateScopeAsync(Scope scope, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateScopeAsync(scope, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, st::CancellationToken cancellationToken) =>
            GetBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the bucket to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucket(new GetBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the bucket to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucketAsync(new GetBucketRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the bucket to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(string name, st::CancellationToken cancellationToken) =>
            GetBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the bucket to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Bucket GetBucket(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucket(new GetBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the bucket to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(BucketName name, gaxgrpc::CallSettings callSettings = null) =>
            GetBucketAsync(new GetBucketRequest
            {
                BucketName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the bucket to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Bucket> GetBucketAsync(BucketName name, st::CancellationToken cancellationToken) =>
            GetBucketAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List buckets of a project in a particular location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List buckets of a project in a particular location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List buckets of a project in a particular location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of buckets. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
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
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
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
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// List buckets of a project in a particular location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of buckets. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
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
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// List buckets of a project in a particular location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of buckets. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
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
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
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
            return ListBuckets(request, callSettings);
        }

        /// <summary>
        /// List buckets of a project in a particular location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent, which owns this collection of buckets. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListBucketsRequest request = new ListBucketsRequest
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
            return ListBucketsAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Bucket, OperationMetadata> CreateBucket(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> CreateBucketAsync(CreateBucketRequest request, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateBucket</c>.</summary>
        public virtual lro::OperationsClient CreateBucketOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateBucket</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Bucket, OperationMetadata> PollOnceCreateBucket(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Bucket, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBucketOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateBucket</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> PollOnceCreateBucketAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Bucket, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateBucketOperationsClient, callSettings);

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project and location for the bucket. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
        /// </param>
        /// <param name="bucket">
        /// Required. Bucket to create.
        /// </param>
        /// <param name="bucketId">
        /// Required. Id of the bucket to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Bucket, OperationMetadata> CreateBucket(string parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucket(new CreateBucketRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project and location for the bucket. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
        /// </param>
        /// <param name="bucket">
        /// Required. Bucket to create.
        /// </param>
        /// <param name="bucketId">
        /// Required. Id of the bucket to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> CreateBucketAsync(string parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucketAsync(new CreateBucketRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project and location for the bucket. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
        /// </param>
        /// <param name="bucket">
        /// Required. Bucket to create.
        /// </param>
        /// <param name="bucketId">
        /// Required. Id of the bucket to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> CreateBucketAsync(string parent, Bucket bucket, string bucketId, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(parent, bucket, bucketId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project and location for the bucket. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
        /// </param>
        /// <param name="bucket">
        /// Required. Bucket to create.
        /// </param>
        /// <param name="bucketId">
        /// Required. Id of the bucket to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Bucket, OperationMetadata> CreateBucket(gagr::LocationName parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucket(new CreateBucketRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project and location for the bucket. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
        /// </param>
        /// <param name="bucket">
        /// Required. Bucket to create.
        /// </param>
        /// <param name="bucketId">
        /// Required. Id of the bucket to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> CreateBucketAsync(gagr::LocationName parent, Bucket bucket, string bucketId, gaxgrpc::CallSettings callSettings = null) =>
            CreateBucketAsync(new CreateBucketRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                BucketId = gax::GaxPreconditions.CheckNotNullOrEmpty(bucketId, nameof(bucketId)),
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
            }, callSettings);

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the project and location for the bucket. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]
        /// </param>
        /// <param name="bucket">
        /// Required. Bucket to create.
        /// </param>
        /// <param name="bucketId">
        /// Required. Id of the bucket to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> CreateBucketAsync(gagr::LocationName parent, Bucket bucket, string bucketId, st::CancellationToken cancellationToken) =>
            CreateBucketAsync(parent, bucket, bucketId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Bucket, OperationMetadata> UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> UpdateBucketAsync(UpdateBucketRequest request, st::CancellationToken cancellationToken) =>
            UpdateBucketAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateBucket</c>.</summary>
        public virtual lro::OperationsClient UpdateBucketOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateBucket</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Bucket, OperationMetadata> PollOnceUpdateBucket(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Bucket, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBucketOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateBucket</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> PollOnceUpdateBucketAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Bucket, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateBucketOperationsClient, callSettings);

        /// <summary>
        /// Update a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. The  bucket to update.
        /// 
        /// The name field of bucket identifies the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Bucket, OperationMetadata> UpdateBucket(Bucket bucket, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBucket(new UpdateBucketRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. The  bucket to update.
        /// 
        /// The name field of bucket identifies the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> UpdateBucketAsync(Bucket bucket, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateBucketAsync(new UpdateBucketRequest
            {
                Bucket = gax::GaxPreconditions.CheckNotNull(bucket, nameof(bucket)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a bucket.
        /// </summary>
        /// <param name="bucket">
        /// Required. The  bucket to update.
        /// 
        /// The name field of bucket identifies the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Bucket, OperationMetadata>> UpdateBucketAsync(Bucket bucket, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateBucketAsync(bucket, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the dataset to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the dataset to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the dataset to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(string name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the dataset to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Dataset GetDataset(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDataset(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the dataset to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDatasetAsync(new GetDatasetRequest
            {
                DatasetName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the dataset to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Dataset> GetDatasetAsync(DatasetName name, st::CancellationToken cancellationToken) =>
            GetDatasetAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List datasets of a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List datasets of a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List datasets of a bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent bucket that owns this collection of datasets. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
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
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasets(request, callSettings);
        }

        /// <summary>
        /// List datasets of a bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent bucket that owns this collection of datasets. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
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
            return ListDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// List datasets of a bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent bucket that owns this collection of datasets. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
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
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatasets(request, callSettings);
        }

        /// <summary>
        /// List datasets of a bucket.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent bucket that owns this collection of datasets. The
        /// format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(BucketName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDatasetsRequest request = new ListDatasetsRequest
            {
                ParentAsBucketName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDatasetsAsync(request, callSettings);
        }

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View GetView(GetViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(GetViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(GetViewRequest request, st::CancellationToken cancellationToken) =>
            GetViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the view to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/views/[VIEW_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View GetView(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetView(new GetViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the view to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/views/[VIEW_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetViewAsync(new GetViewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the view to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/views/[VIEW_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(string name, st::CancellationToken cancellationToken) =>
            GetViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the view to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/views/[VIEW_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual View GetView(ViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetView(new GetViewRequest
            {
                ViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the view to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/views/[VIEW_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(ViewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetViewAsync(new GetViewRequest
            {
                ViewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the view to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/views/[VIEW_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<View> GetViewAsync(ViewName name, st::CancellationToken cancellationToken) =>
            GetViewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List views of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewsResponse, View> ListViews(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List views of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewsResponse, View> ListViewsAsync(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List views of a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset whose views are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
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
        /// <returns>A pageable sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewsResponse, View> ListViews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
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
            return ListViews(request, callSettings);
        }

        /// <summary>
        /// List views of a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset whose views are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewsResponse, View> ListViewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
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
            return ListViewsAsync(request, callSettings);
        }

        /// <summary>
        /// List views of a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset whose views are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
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
        /// <returns>A pageable sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListViewsResponse, View> ListViews(DatasetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListViews(request, callSettings);
        }

        /// <summary>
        /// List views of a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. Dataset whose views are to be listed. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="View"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListViewsResponse, View> ListViewsAsync(DatasetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListViewsRequest request = new ListViewsRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListViewsAsync(request, callSettings);
        }

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Link GetLink(GetLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(GetLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(GetLinkRequest request, st::CancellationToken cancellationToken) =>
            GetLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Link GetLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLink(new GetLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetLinkAsync(new GetLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(string name, st::CancellationToken cancellationToken) =>
            GetLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Link GetLink(LinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLink(new GetLinkRequest
            {
                LinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(LinkName name, gaxgrpc::CallSettings callSettings = null) =>
            GetLinkAsync(new GetLinkRequest
            {
                LinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to retrieve. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Link> GetLinkAsync(LinkName name, st::CancellationToken cancellationToken) =>
            GetLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List links of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLinksResponse, Link> ListLinks(ListLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List links of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLinksResponse, Link> ListLinksAsync(ListLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List links of a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent dataset that owns this collection of links. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
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
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLinksResponse, Link> ListLinks(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLinksRequest request = new ListLinksRequest
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
            return ListLinks(request, callSettings);
        }

        /// <summary>
        /// List links of a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent dataset that owns this collection of links. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLinksResponse, Link> ListLinksAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLinksRequest request = new ListLinksRequest
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
            return ListLinksAsync(request, callSettings);
        }

        /// <summary>
        /// List links of a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent dataset that owns this collection of links. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
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
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListLinksResponse, Link> ListLinks(DatasetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLinksRequest request = new ListLinksRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLinks(request, callSettings);
        }

        /// <summary>
        /// List links of a dataset.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent dataset that owns this collection of links. The format
        /// is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
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
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListLinksResponse, Link> ListLinksAsync(DatasetName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListLinksRequest request = new ListLinksRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListLinksAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Link, OperationMetadata> CreateLink(CreateLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> CreateLinkAsync(CreateLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> CreateLinkAsync(CreateLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateLink</c>.</summary>
        public virtual lro::OperationsClient CreateLinkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Link, OperationMetadata> PollOnceCreateLink(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Link, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLinkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> PollOnceCreateLinkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Link, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateLinkOperationsClient, callSettings);

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the containing dataset for this link. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="link">
        /// Required. Link to create.
        /// </param>
        /// <param name="linkId">
        /// Required. Id of the link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Link, OperationMetadata> CreateLink(string parent, Link link, string linkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLink(new CreateLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)),
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
            }, callSettings);

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the containing dataset for this link. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="link">
        /// Required. Link to create.
        /// </param>
        /// <param name="linkId">
        /// Required. Id of the link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> CreateLinkAsync(string parent, Link link, string linkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLinkAsync(new CreateLinkRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)),
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
            }, callSettings);

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the containing dataset for this link. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="link">
        /// Required. Link to create.
        /// </param>
        /// <param name="linkId">
        /// Required. Id of the link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> CreateLinkAsync(string parent, Link link, string linkId, st::CancellationToken cancellationToken) =>
            CreateLinkAsync(parent, link, linkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the containing dataset for this link. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="link">
        /// Required. Link to create.
        /// </param>
        /// <param name="linkId">
        /// Required. Id of the link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Link, OperationMetadata> CreateLink(DatasetName parent, Link link, string linkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLink(new CreateLinkRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)),
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
            }, callSettings);

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the containing dataset for this link. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="link">
        /// Required. Link to create.
        /// </param>
        /// <param name="linkId">
        /// Required. Id of the link to create.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> CreateLinkAsync(DatasetName parent, Link link, string linkId, gaxgrpc::CallSettings callSettings = null) =>
            CreateLinkAsync(new CreateLinkRequest
            {
                ParentAsDatasetName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LinkId = gax::GaxPreconditions.CheckNotNullOrEmpty(linkId, nameof(linkId)),
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
            }, callSettings);

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the containing dataset for this link. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]
        /// </param>
        /// <param name="link">
        /// Required. Link to create.
        /// </param>
        /// <param name="linkId">
        /// Required. Id of the link to create.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> CreateLinkAsync(DatasetName parent, Link link, string linkId, st::CancellationToken cancellationToken) =>
            CreateLinkAsync(parent, link, linkId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Link, OperationMetadata> UpdateLink(UpdateLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> UpdateLinkAsync(UpdateLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> UpdateLinkAsync(UpdateLinkRequest request, st::CancellationToken cancellationToken) =>
            UpdateLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateLink</c>.</summary>
        public virtual lro::OperationsClient UpdateLinkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Link, OperationMetadata> PollOnceUpdateLink(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Link, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateLinkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> PollOnceUpdateLinkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Link, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateLinkOperationsClient, callSettings);

        /// <summary>
        /// Update a link.
        /// </summary>
        /// <param name="link">
        /// Required. Link to update.
        /// 
        /// The name field of link identifies the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Link, OperationMetadata> UpdateLink(Link link, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLink(new UpdateLinkRequest
            {
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a link.
        /// </summary>
        /// <param name="link">
        /// Required. Link to update.
        /// 
        /// The name field of link identifies the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> UpdateLinkAsync(Link link, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateLinkAsync(new UpdateLinkRequest
            {
                Link = gax::GaxPreconditions.CheckNotNull(link, nameof(link)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a link.
        /// </summary>
        /// <param name="link">
        /// Required. Link to update.
        /// 
        /// The name field of link identifies the resource to update.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Link, OperationMetadata>> UpdateLinkAsync(Link link, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateLinkAsync(link, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLink(DeleteLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLinkAsync(DeleteLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLinkAsync(DeleteLinkRequest request, st::CancellationToken cancellationToken) =>
            DeleteLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteLink</c>.</summary>
        public virtual lro::OperationsClient DeleteLinkOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteLink(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLinkOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteLink</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteLinkAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteLinkOperationsClient, callSettings);

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to delete. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLink(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLink(new DeleteLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to delete. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLinkAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLinkAsync(new DeleteLinkRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to delete. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLinkAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to delete. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteLink(LinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLink(new DeleteLinkRequest
            {
                LinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to delete. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLinkAsync(LinkName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteLinkAsync(new DeleteLinkRequest
            {
                LinkName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the link to delete. The format is:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION]/buckets/[BUCKET_ID]/datasets/[DATASET_ID]/links/[LINK_ID]
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLinkAsync(LinkName name, st::CancellationToken cancellationToken) =>
            DeleteLinkAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TraceScope GetTraceScope(GetTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> GetTraceScopeAsync(GetTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> GetTraceScopeAsync(GetTraceScopeRequest request, st::CancellationToken cancellationToken) =>
            GetTraceScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the trace scope:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TraceScope GetTraceScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTraceScope(new GetTraceScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the trace scope:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> GetTraceScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTraceScopeAsync(new GetTraceScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the trace scope:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> GetTraceScopeAsync(string name, st::CancellationToken cancellationToken) =>
            GetTraceScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the trace scope:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TraceScope GetTraceScope(TraceScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTraceScope(new GetTraceScopeRequest
            {
                TraceScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the trace scope:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> GetTraceScopeAsync(TraceScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTraceScopeAsync(new GetTraceScopeRequest
            {
                TraceScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the trace scope:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> GetTraceScopeAsync(TraceScopeName name, st::CancellationToken cancellationToken) =>
            GetTraceScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// List TraceScopes of a project in a particular location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TraceScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTraceScopesResponse, TraceScope> ListTraceScopes(ListTraceScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List TraceScopes of a project in a particular location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TraceScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTraceScopesResponse, TraceScope> ListTraceScopesAsync(ListTraceScopesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// List TraceScopes of a project in a particular location.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location to look for trace scopes:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
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
        /// <returns>A pageable sequence of <see cref="TraceScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTraceScopesResponse, TraceScope> ListTraceScopes(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTraceScopesRequest request = new ListTraceScopesRequest
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
            return ListTraceScopes(request, callSettings);
        }

        /// <summary>
        /// List TraceScopes of a project in a particular location.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location to look for trace scopes:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
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
        /// <returns>A pageable asynchronous sequence of <see cref="TraceScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTraceScopesResponse, TraceScope> ListTraceScopesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTraceScopesRequest request = new ListTraceScopesRequest
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
            return ListTraceScopesAsync(request, callSettings);
        }

        /// <summary>
        /// List TraceScopes of a project in a particular location.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location to look for trace scopes:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
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
        /// <returns>A pageable sequence of <see cref="TraceScope"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTraceScopesResponse, TraceScope> ListTraceScopes(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTraceScopesRequest request = new ListTraceScopesRequest
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
            return ListTraceScopes(request, callSettings);
        }

        /// <summary>
        /// List TraceScopes of a project in a particular location.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location to look for trace scopes:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
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
        /// <returns>A pageable asynchronous sequence of <see cref="TraceScope"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTraceScopesResponse, TraceScope> ListTraceScopesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTraceScopesRequest request = new ListTraceScopesRequest
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
            return ListTraceScopesAsync(request, callSettings);
        }

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TraceScope CreateTraceScope(CreateTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> CreateTraceScopeAsync(CreateTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> CreateTraceScopeAsync(CreateTraceScopeRequest request, st::CancellationToken cancellationToken) =>
            CreateTraceScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location where the trace scope
        /// should be created
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
        /// </param>
        /// <param name="traceScope">
        /// Required. The new trace scope.
        /// </param>
        /// <param name="traceScopeId">
        /// Required. A client-assigned identifier for the trace scope.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TraceScope CreateTraceScope(string parent, TraceScope traceScope, string traceScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTraceScope(new CreateTraceScopeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TraceScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(traceScopeId, nameof(traceScopeId)),
                TraceScope = gax::GaxPreconditions.CheckNotNull(traceScope, nameof(traceScope)),
            }, callSettings);

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location where the trace scope
        /// should be created
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
        /// </param>
        /// <param name="traceScope">
        /// Required. The new trace scope.
        /// </param>
        /// <param name="traceScopeId">
        /// Required. A client-assigned identifier for the trace scope.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> CreateTraceScopeAsync(string parent, TraceScope traceScope, string traceScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTraceScopeAsync(new CreateTraceScopeRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                TraceScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(traceScopeId, nameof(traceScopeId)),
                TraceScope = gax::GaxPreconditions.CheckNotNull(traceScope, nameof(traceScope)),
            }, callSettings);

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location where the trace scope
        /// should be created
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
        /// </param>
        /// <param name="traceScope">
        /// Required. The new trace scope.
        /// </param>
        /// <param name="traceScopeId">
        /// Required. A client-assigned identifier for the trace scope.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> CreateTraceScopeAsync(string parent, TraceScope traceScope, string traceScopeId, st::CancellationToken cancellationToken) =>
            CreateTraceScopeAsync(parent, traceScope, traceScopeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location where the trace scope
        /// should be created
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
        /// </param>
        /// <param name="traceScope">
        /// Required. The new trace scope.
        /// </param>
        /// <param name="traceScopeId">
        /// Required. A client-assigned identifier for the trace scope.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TraceScope CreateTraceScope(gagr::LocationName parent, TraceScope traceScope, string traceScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTraceScope(new CreateTraceScopeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TraceScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(traceScopeId, nameof(traceScopeId)),
                TraceScope = gax::GaxPreconditions.CheckNotNull(traceScope, nameof(traceScope)),
            }, callSettings);

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location where the trace scope
        /// should be created
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
        /// </param>
        /// <param name="traceScope">
        /// Required. The new trace scope.
        /// </param>
        /// <param name="traceScopeId">
        /// Required. A client-assigned identifier for the trace scope.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> CreateTraceScopeAsync(gagr::LocationName parent, TraceScope traceScope, string traceScopeId, gaxgrpc::CallSettings callSettings = null) =>
            CreateTraceScopeAsync(new CreateTraceScopeRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                TraceScopeId = gax::GaxPreconditions.CheckNotNullOrEmpty(traceScopeId, nameof(traceScopeId)),
                TraceScope = gax::GaxPreconditions.CheckNotNull(traceScope, nameof(traceScope)),
            }, callSettings);

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="parent">
        /// Required. The full resource name of the location where the trace scope
        /// should be created
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global
        /// </param>
        /// <param name="traceScope">
        /// Required. The new trace scope.
        /// </param>
        /// <param name="traceScopeId">
        /// Required. A client-assigned identifier for the trace scope.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> CreateTraceScopeAsync(gagr::LocationName parent, TraceScope traceScope, string traceScopeId, st::CancellationToken cancellationToken) =>
            CreateTraceScopeAsync(parent, traceScope, traceScopeId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TraceScope UpdateTraceScope(UpdateTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> UpdateTraceScopeAsync(UpdateTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> UpdateTraceScopeAsync(UpdateTraceScopeRequest request, st::CancellationToken cancellationToken) =>
            UpdateTraceScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a TraceScope.
        /// </summary>
        /// <param name="traceScope">
        /// Required. The updated trace scope.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TraceScope UpdateTraceScope(TraceScope traceScope, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTraceScope(new UpdateTraceScopeRequest
            {
                TraceScope = gax::GaxPreconditions.CheckNotNull(traceScope, nameof(traceScope)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a TraceScope.
        /// </summary>
        /// <param name="traceScope">
        /// Required. The updated trace scope.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> UpdateTraceScopeAsync(TraceScope traceScope, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateTraceScopeAsync(new UpdateTraceScopeRequest
            {
                TraceScope = gax::GaxPreconditions.CheckNotNull(traceScope, nameof(traceScope)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update a TraceScope.
        /// </summary>
        /// <param name="traceScope">
        /// Required. The updated trace scope.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The list of fields to update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TraceScope> UpdateTraceScopeAsync(TraceScope traceScope, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateTraceScopeAsync(traceScope, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTraceScope(DeleteTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTraceScopeAsync(DeleteTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTraceScopeAsync(DeleteTraceScopeRequest request, st::CancellationToken cancellationToken) =>
            DeleteTraceScopeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the trace scope to delete:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTraceScope(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTraceScope(new DeleteTraceScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the trace scope to delete:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTraceScopeAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTraceScopeAsync(new DeleteTraceScopeRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the trace scope to delete:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTraceScopeAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteTraceScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the trace scope to delete:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteTraceScope(TraceScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTraceScope(new DeleteTraceScopeRequest
            {
                TraceScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the trace scope to delete:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTraceScopeAsync(TraceScopeName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteTraceScopeAsync(new DeleteTraceScopeRequest
            {
                TraceScopeName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the trace scope to delete:
        /// 
        /// projects/[PROJECT_ID]/locations/[LOCATION_ID]/traceScopes/[TRACE_SCOPE_ID]
        /// 
        /// For example:
        /// 
        /// projects/my-project/locations/global/traceScopes/my-trace-scope
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteTraceScopeAsync(TraceScopeName name, st::CancellationToken cancellationToken) =>
            DeleteTraceScopeAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="name">
        /// Required. Name of the settings to retrieve.
        /// 
        /// Name format:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION]/settings"
        /// "folders/[FOLDER_ID]/locations/[LOCATION]/settings"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION]/settings"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="name">
        /// Required. Name of the settings to retrieve.
        /// 
        /// Name format:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION]/settings"
        /// "folders/[FOLDER_ID]/locations/[LOCATION]/settings"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION]/settings"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="name">
        /// Required. Name of the settings to retrieve.
        /// 
        /// Name format:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION]/settings"
        /// "folders/[FOLDER_ID]/locations/[LOCATION]/settings"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION]/settings"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(string name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="name">
        /// Required. Name of the settings to retrieve.
        /// 
        /// Name format:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION]/settings"
        /// "folders/[FOLDER_ID]/locations/[LOCATION]/settings"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION]/settings"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Settings GetSettings(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettings(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="name">
        /// Required. Name of the settings to retrieve.
        /// 
        /// Name format:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION]/settings"
        /// "folders/[FOLDER_ID]/locations/[LOCATION]/settings"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION]/settings"
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSettingsAsync(new GetSettingsRequest
            {
                SettingsName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="name">
        /// Required. Name of the settings to retrieve.
        /// 
        /// Name format:
        /// 
        /// "projects/[PROJECT_ID]/locations/[LOCATION]/settings"
        /// "folders/[FOLDER_ID]/locations/[LOCATION]/settings"
        /// "organizations/[ORGANIZATION_ID]/locations/[LOCATION]/settings"
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Settings> GetSettingsAsync(SettingsName name, st::CancellationToken cancellationToken) =>
            GetSettingsAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Settings, OperationMetadata> UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(UpdateSettingsRequest request, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateSettings</c>.</summary>
        public virtual lro::OperationsClient UpdateSettingsOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Settings, OperationMetadata> PollOnceUpdateSettings(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Settings, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSettingsOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateSettings</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> PollOnceUpdateSettingsAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Settings, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateSettingsOperationsClient, callSettings);

        /// <summary>
        /// Update Settings
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// The name field of settings is used to identify the resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The field mask specifying which fields of the settings are to be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Settings, OperationMetadata> UpdateSettings(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettings(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update Settings
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// The name field of settings is used to identify the resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The field mask specifying which fields of the settings are to be
        /// updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSettingsAsync(new UpdateSettingsRequest
            {
                Settings = gax::GaxPreconditions.CheckNotNull(settings, nameof(settings)),
                UpdateMask = updateMask,
            }, callSettings);

        /// <summary>
        /// Update Settings
        /// </summary>
        /// <param name="settings">
        /// Required. The settings to update.
        /// 
        /// The name field of settings is used to identify the resource to be updated.
        /// </param>
        /// <param name="updateMask">
        /// Optional. The field mask specifying which fields of the settings are to be
        /// updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(Settings settings, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSettingsAsync(settings, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Observability client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class ObservabilityClientImpl : ObservabilityClient
    {
        private readonly gaxgrpc::ApiCall<GetScopeRequest, Scope> _callGetScope;

        private readonly gaxgrpc::ApiCall<UpdateScopeRequest, Scope> _callUpdateScope;

        private readonly gaxgrpc::ApiCall<GetBucketRequest, Bucket> _callGetBucket;

        private readonly gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> _callListBuckets;

        private readonly gaxgrpc::ApiCall<CreateBucketRequest, lro::Operation> _callCreateBucket;

        private readonly gaxgrpc::ApiCall<UpdateBucketRequest, lro::Operation> _callUpdateBucket;

        private readonly gaxgrpc::ApiCall<GetDatasetRequest, Dataset> _callGetDataset;

        private readonly gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> _callListDatasets;

        private readonly gaxgrpc::ApiCall<GetViewRequest, View> _callGetView;

        private readonly gaxgrpc::ApiCall<ListViewsRequest, ListViewsResponse> _callListViews;

        private readonly gaxgrpc::ApiCall<GetLinkRequest, Link> _callGetLink;

        private readonly gaxgrpc::ApiCall<ListLinksRequest, ListLinksResponse> _callListLinks;

        private readonly gaxgrpc::ApiCall<CreateLinkRequest, lro::Operation> _callCreateLink;

        private readonly gaxgrpc::ApiCall<UpdateLinkRequest, lro::Operation> _callUpdateLink;

        private readonly gaxgrpc::ApiCall<DeleteLinkRequest, lro::Operation> _callDeleteLink;

        private readonly gaxgrpc::ApiCall<GetTraceScopeRequest, TraceScope> _callGetTraceScope;

        private readonly gaxgrpc::ApiCall<ListTraceScopesRequest, ListTraceScopesResponse> _callListTraceScopes;

        private readonly gaxgrpc::ApiCall<CreateTraceScopeRequest, TraceScope> _callCreateTraceScope;

        private readonly gaxgrpc::ApiCall<UpdateTraceScopeRequest, TraceScope> _callUpdateTraceScope;

        private readonly gaxgrpc::ApiCall<DeleteTraceScopeRequest, wkt::Empty> _callDeleteTraceScope;

        private readonly gaxgrpc::ApiCall<GetSettingsRequest, Settings> _callGetSettings;

        private readonly gaxgrpc::ApiCall<UpdateSettingsRequest, lro::Operation> _callUpdateSettings;

        /// <summary>
        /// Constructs a client wrapper for the Observability service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ObservabilitySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ObservabilityClientImpl(Observability.ObservabilityClient grpcClient, ObservabilitySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ObservabilitySettings effectiveSettings = settings ?? ObservabilitySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateBucketOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateBucketOperationsSettings, logger);
            UpdateBucketOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateBucketOperationsSettings, logger);
            CreateLinkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateLinkOperationsSettings, logger);
            UpdateLinkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateLinkOperationsSettings, logger);
            DeleteLinkOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteLinkOperationsSettings, logger);
            UpdateSettingsOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateSettingsOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callGetScope = clientHelper.BuildApiCall<GetScopeRequest, Scope>("GetScope", grpcClient.GetScopeAsync, grpcClient.GetScope, effectiveSettings.GetScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetScope);
            Modify_GetScopeApiCall(ref _callGetScope);
            _callUpdateScope = clientHelper.BuildApiCall<UpdateScopeRequest, Scope>("UpdateScope", grpcClient.UpdateScopeAsync, grpcClient.UpdateScope, effectiveSettings.UpdateScopeSettings).WithGoogleRequestParam("scope.name", request => request.Scope?.Name);
            Modify_ApiCall(ref _callUpdateScope);
            Modify_UpdateScopeApiCall(ref _callUpdateScope);
            _callGetBucket = clientHelper.BuildApiCall<GetBucketRequest, Bucket>("GetBucket", grpcClient.GetBucketAsync, grpcClient.GetBucket, effectiveSettings.GetBucketSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetBucket);
            Modify_GetBucketApiCall(ref _callGetBucket);
            _callListBuckets = clientHelper.BuildApiCall<ListBucketsRequest, ListBucketsResponse>("ListBuckets", grpcClient.ListBucketsAsync, grpcClient.ListBuckets, effectiveSettings.ListBucketsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListBuckets);
            Modify_ListBucketsApiCall(ref _callListBuckets);
            _callCreateBucket = clientHelper.BuildApiCall<CreateBucketRequest, lro::Operation>("CreateBucket", grpcClient.CreateBucketAsync, grpcClient.CreateBucket, effectiveSettings.CreateBucketSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateBucket);
            Modify_CreateBucketApiCall(ref _callCreateBucket);
            _callUpdateBucket = clientHelper.BuildApiCall<UpdateBucketRequest, lro::Operation>("UpdateBucket", grpcClient.UpdateBucketAsync, grpcClient.UpdateBucket, effectiveSettings.UpdateBucketSettings).WithGoogleRequestParam("bucket.name", request => request.Bucket?.Name);
            Modify_ApiCall(ref _callUpdateBucket);
            Modify_UpdateBucketApiCall(ref _callUpdateBucket);
            _callGetDataset = clientHelper.BuildApiCall<GetDatasetRequest, Dataset>("GetDataset", grpcClient.GetDatasetAsync, grpcClient.GetDataset, effectiveSettings.GetDatasetSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDataset);
            Modify_GetDatasetApiCall(ref _callGetDataset);
            _callListDatasets = clientHelper.BuildApiCall<ListDatasetsRequest, ListDatasetsResponse>("ListDatasets", grpcClient.ListDatasetsAsync, grpcClient.ListDatasets, effectiveSettings.ListDatasetsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDatasets);
            Modify_ListDatasetsApiCall(ref _callListDatasets);
            _callGetView = clientHelper.BuildApiCall<GetViewRequest, View>("GetView", grpcClient.GetViewAsync, grpcClient.GetView, effectiveSettings.GetViewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetView);
            Modify_GetViewApiCall(ref _callGetView);
            _callListViews = clientHelper.BuildApiCall<ListViewsRequest, ListViewsResponse>("ListViews", grpcClient.ListViewsAsync, grpcClient.ListViews, effectiveSettings.ListViewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListViews);
            Modify_ListViewsApiCall(ref _callListViews);
            _callGetLink = clientHelper.BuildApiCall<GetLinkRequest, Link>("GetLink", grpcClient.GetLinkAsync, grpcClient.GetLink, effectiveSettings.GetLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetLink);
            Modify_GetLinkApiCall(ref _callGetLink);
            _callListLinks = clientHelper.BuildApiCall<ListLinksRequest, ListLinksResponse>("ListLinks", grpcClient.ListLinksAsync, grpcClient.ListLinks, effectiveSettings.ListLinksSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListLinks);
            Modify_ListLinksApiCall(ref _callListLinks);
            _callCreateLink = clientHelper.BuildApiCall<CreateLinkRequest, lro::Operation>("CreateLink", grpcClient.CreateLinkAsync, grpcClient.CreateLink, effectiveSettings.CreateLinkSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateLink);
            Modify_CreateLinkApiCall(ref _callCreateLink);
            _callUpdateLink = clientHelper.BuildApiCall<UpdateLinkRequest, lro::Operation>("UpdateLink", grpcClient.UpdateLinkAsync, grpcClient.UpdateLink, effectiveSettings.UpdateLinkSettings).WithGoogleRequestParam("link.name", request => request.Link?.Name);
            Modify_ApiCall(ref _callUpdateLink);
            Modify_UpdateLinkApiCall(ref _callUpdateLink);
            _callDeleteLink = clientHelper.BuildApiCall<DeleteLinkRequest, lro::Operation>("DeleteLink", grpcClient.DeleteLinkAsync, grpcClient.DeleteLink, effectiveSettings.DeleteLinkSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteLink);
            Modify_DeleteLinkApiCall(ref _callDeleteLink);
            _callGetTraceScope = clientHelper.BuildApiCall<GetTraceScopeRequest, TraceScope>("GetTraceScope", grpcClient.GetTraceScopeAsync, grpcClient.GetTraceScope, effectiveSettings.GetTraceScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTraceScope);
            Modify_GetTraceScopeApiCall(ref _callGetTraceScope);
            _callListTraceScopes = clientHelper.BuildApiCall<ListTraceScopesRequest, ListTraceScopesResponse>("ListTraceScopes", grpcClient.ListTraceScopesAsync, grpcClient.ListTraceScopes, effectiveSettings.ListTraceScopesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTraceScopes);
            Modify_ListTraceScopesApiCall(ref _callListTraceScopes);
            _callCreateTraceScope = clientHelper.BuildApiCall<CreateTraceScopeRequest, TraceScope>("CreateTraceScope", grpcClient.CreateTraceScopeAsync, grpcClient.CreateTraceScope, effectiveSettings.CreateTraceScopeSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateTraceScope);
            Modify_CreateTraceScopeApiCall(ref _callCreateTraceScope);
            _callUpdateTraceScope = clientHelper.BuildApiCall<UpdateTraceScopeRequest, TraceScope>("UpdateTraceScope", grpcClient.UpdateTraceScopeAsync, grpcClient.UpdateTraceScope, effectiveSettings.UpdateTraceScopeSettings).WithGoogleRequestParam("trace_scope.name", request => request.TraceScope?.Name);
            Modify_ApiCall(ref _callUpdateTraceScope);
            Modify_UpdateTraceScopeApiCall(ref _callUpdateTraceScope);
            _callDeleteTraceScope = clientHelper.BuildApiCall<DeleteTraceScopeRequest, wkt::Empty>("DeleteTraceScope", grpcClient.DeleteTraceScopeAsync, grpcClient.DeleteTraceScope, effectiveSettings.DeleteTraceScopeSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteTraceScope);
            Modify_DeleteTraceScopeApiCall(ref _callDeleteTraceScope);
            _callGetSettings = clientHelper.BuildApiCall<GetSettingsRequest, Settings>("GetSettings", grpcClient.GetSettingsAsync, grpcClient.GetSettings, effectiveSettings.GetSettingsSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSettings);
            Modify_GetSettingsApiCall(ref _callGetSettings);
            _callUpdateSettings = clientHelper.BuildApiCall<UpdateSettingsRequest, lro::Operation>("UpdateSettings", grpcClient.UpdateSettingsAsync, grpcClient.UpdateSettings, effectiveSettings.UpdateSettingsSettings).WithGoogleRequestParam("settings.name", request => request.Settings?.Name);
            Modify_ApiCall(ref _callUpdateSettings);
            Modify_UpdateSettingsApiCall(ref _callUpdateSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetScopeApiCall(ref gaxgrpc::ApiCall<GetScopeRequest, Scope> call);

        partial void Modify_UpdateScopeApiCall(ref gaxgrpc::ApiCall<UpdateScopeRequest, Scope> call);

        partial void Modify_GetBucketApiCall(ref gaxgrpc::ApiCall<GetBucketRequest, Bucket> call);

        partial void Modify_ListBucketsApiCall(ref gaxgrpc::ApiCall<ListBucketsRequest, ListBucketsResponse> call);

        partial void Modify_CreateBucketApiCall(ref gaxgrpc::ApiCall<CreateBucketRequest, lro::Operation> call);

        partial void Modify_UpdateBucketApiCall(ref gaxgrpc::ApiCall<UpdateBucketRequest, lro::Operation> call);

        partial void Modify_GetDatasetApiCall(ref gaxgrpc::ApiCall<GetDatasetRequest, Dataset> call);

        partial void Modify_ListDatasetsApiCall(ref gaxgrpc::ApiCall<ListDatasetsRequest, ListDatasetsResponse> call);

        partial void Modify_GetViewApiCall(ref gaxgrpc::ApiCall<GetViewRequest, View> call);

        partial void Modify_ListViewsApiCall(ref gaxgrpc::ApiCall<ListViewsRequest, ListViewsResponse> call);

        partial void Modify_GetLinkApiCall(ref gaxgrpc::ApiCall<GetLinkRequest, Link> call);

        partial void Modify_ListLinksApiCall(ref gaxgrpc::ApiCall<ListLinksRequest, ListLinksResponse> call);

        partial void Modify_CreateLinkApiCall(ref gaxgrpc::ApiCall<CreateLinkRequest, lro::Operation> call);

        partial void Modify_UpdateLinkApiCall(ref gaxgrpc::ApiCall<UpdateLinkRequest, lro::Operation> call);

        partial void Modify_DeleteLinkApiCall(ref gaxgrpc::ApiCall<DeleteLinkRequest, lro::Operation> call);

        partial void Modify_GetTraceScopeApiCall(ref gaxgrpc::ApiCall<GetTraceScopeRequest, TraceScope> call);

        partial void Modify_ListTraceScopesApiCall(ref gaxgrpc::ApiCall<ListTraceScopesRequest, ListTraceScopesResponse> call);

        partial void Modify_CreateTraceScopeApiCall(ref gaxgrpc::ApiCall<CreateTraceScopeRequest, TraceScope> call);

        partial void Modify_UpdateTraceScopeApiCall(ref gaxgrpc::ApiCall<UpdateTraceScopeRequest, TraceScope> call);

        partial void Modify_DeleteTraceScopeApiCall(ref gaxgrpc::ApiCall<DeleteTraceScopeRequest, wkt::Empty> call);

        partial void Modify_GetSettingsApiCall(ref gaxgrpc::ApiCall<GetSettingsRequest, Settings> call);

        partial void Modify_UpdateSettingsApiCall(ref gaxgrpc::ApiCall<UpdateSettingsRequest, lro::Operation> call);

        partial void OnConstruction(Observability.ObservabilityClient grpcClient, ObservabilitySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Observability client</summary>
        public override Observability.ObservabilityClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_GetScopeRequest(ref GetScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateScopeRequest(ref UpdateScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetBucketRequest(ref GetBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBucketsRequest(ref ListBucketsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateBucketRequest(ref CreateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateBucketRequest(ref UpdateBucketRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDatasetRequest(ref GetDatasetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDatasetsRequest(ref ListDatasetsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetViewRequest(ref GetViewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListViewsRequest(ref ListViewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetLinkRequest(ref GetLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListLinksRequest(ref ListLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateLinkRequest(ref CreateLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateLinkRequest(ref UpdateLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteLinkRequest(ref DeleteLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTraceScopeRequest(ref GetTraceScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTraceScopesRequest(ref ListTraceScopesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateTraceScopeRequest(ref CreateTraceScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateTraceScopeRequest(ref UpdateTraceScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteTraceScopeRequest(ref DeleteTraceScopeRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSettingsRequest(ref GetSettingsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSettingsRequest(ref UpdateSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Scope GetScope(GetScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScopeRequest(ref request, ref callSettings);
            return _callGetScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Scope> GetScopeAsync(GetScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetScopeRequest(ref request, ref callSettings);
            return _callGetScope.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Scope UpdateScope(UpdateScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScopeRequest(ref request, ref callSettings);
            return _callUpdateScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the parameters of a single Scope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Scope> UpdateScopeAsync(UpdateScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateScopeRequest(ref request, ref callSettings);
            return _callUpdateScope.Async(request, callSettings);
        }

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Bucket GetBucket(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Sync(request, callSettings);
        }

        /// <summary>
        /// Get bucket resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Bucket> GetBucketAsync(GetBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBucketRequest(ref request, ref callSettings);
            return _callGetBucket.Async(request, callSettings);
        }

        /// <summary>
        /// List buckets of a project in a particular location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Bucket"/> resources.</returns>
        public override gax::PagedEnumerable<ListBucketsResponse, Bucket> ListBuckets(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBucketsRequest, ListBucketsResponse, Bucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>
        /// List buckets of a project in a particular location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Bucket"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBucketsResponse, Bucket> ListBucketsAsync(ListBucketsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBucketsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBucketsRequest, ListBucketsResponse, Bucket>(_callListBuckets, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateBucket</c>.</summary>
        public override lro::OperationsClient CreateBucketOperationsClient { get; }

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Bucket, OperationMetadata> CreateBucket(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return new lro::Operation<Bucket, OperationMetadata>(_callCreateBucket.Sync(request, callSettings), CreateBucketOperationsClient);
        }

        /// <summary>
        /// Create a new bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Bucket, OperationMetadata>> CreateBucketAsync(CreateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateBucketRequest(ref request, ref callSettings);
            return new lro::Operation<Bucket, OperationMetadata>(await _callCreateBucket.Async(request, callSettings).ConfigureAwait(false), CreateBucketOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateBucket</c>.</summary>
        public override lro::OperationsClient UpdateBucketOperationsClient { get; }

        /// <summary>
        /// Update a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Bucket, OperationMetadata> UpdateBucket(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return new lro::Operation<Bucket, OperationMetadata>(_callUpdateBucket.Sync(request, callSettings), UpdateBucketOperationsClient);
        }

        /// <summary>
        /// Update a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Bucket, OperationMetadata>> UpdateBucketAsync(UpdateBucketRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateBucketRequest(ref request, ref callSettings);
            return new lro::Operation<Bucket, OperationMetadata>(await _callUpdateBucket.Async(request, callSettings).ConfigureAwait(false), UpdateBucketOperationsClient);
        }

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Dataset GetDataset(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetRequest(ref request, ref callSettings);
            return _callGetDataset.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Dataset> GetDatasetAsync(GetDatasetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDatasetRequest(ref request, ref callSettings);
            return _callGetDataset.Async(request, callSettings);
        }

        /// <summary>
        /// List datasets of a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedEnumerable<ListDatasetsResponse, Dataset> ListDatasets(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>
        /// List datasets of a bucket.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Dataset"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDatasetsResponse, Dataset> ListDatasetsAsync(ListDatasetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDatasetsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDatasetsRequest, ListDatasetsResponse, Dataset>(_callListDatasets, request, callSettings);
        }

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override View GetView(GetViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViewRequest(ref request, ref callSettings);
            return _callGetView.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a view.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<View> GetViewAsync(GetViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetViewRequest(ref request, ref callSettings);
            return _callGetView.Async(request, callSettings);
        }

        /// <summary>
        /// List views of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="View"/> resources.</returns>
        public override gax::PagedEnumerable<ListViewsResponse, View> ListViews(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListViewsRequest, ListViewsResponse, View>(_callListViews, request, callSettings);
        }

        /// <summary>
        /// List views of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="View"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListViewsResponse, View> ListViewsAsync(ListViewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListViewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListViewsRequest, ListViewsResponse, View>(_callListViews, request, callSettings);
        }

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Link GetLink(GetLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLinkRequest(ref request, ref callSettings);
            return _callGetLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Get a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Link> GetLinkAsync(GetLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLinkRequest(ref request, ref callSettings);
            return _callGetLink.Async(request, callSettings);
        }

        /// <summary>
        /// List links of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Link"/> resources.</returns>
        public override gax::PagedEnumerable<ListLinksResponse, Link> ListLinks(ListLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListLinksRequest, ListLinksResponse, Link>(_callListLinks, request, callSettings);
        }

        /// <summary>
        /// List links of a dataset.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Link"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListLinksResponse, Link> ListLinksAsync(ListLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListLinksRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListLinksRequest, ListLinksResponse, Link>(_callListLinks, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateLink</c>.</summary>
        public override lro::OperationsClient CreateLinkOperationsClient { get; }

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Link, OperationMetadata> CreateLink(CreateLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLinkRequest(ref request, ref callSettings);
            return new lro::Operation<Link, OperationMetadata>(_callCreateLink.Sync(request, callSettings), CreateLinkOperationsClient);
        }

        /// <summary>
        /// Create a new link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Link, OperationMetadata>> CreateLinkAsync(CreateLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateLinkRequest(ref request, ref callSettings);
            return new lro::Operation<Link, OperationMetadata>(await _callCreateLink.Async(request, callSettings).ConfigureAwait(false), CreateLinkOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateLink</c>.</summary>
        public override lro::OperationsClient UpdateLinkOperationsClient { get; }

        /// <summary>
        /// Update a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Link, OperationMetadata> UpdateLink(UpdateLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLinkRequest(ref request, ref callSettings);
            return new lro::Operation<Link, OperationMetadata>(_callUpdateLink.Sync(request, callSettings), UpdateLinkOperationsClient);
        }

        /// <summary>
        /// Update a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Link, OperationMetadata>> UpdateLinkAsync(UpdateLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateLinkRequest(ref request, ref callSettings);
            return new lro::Operation<Link, OperationMetadata>(await _callUpdateLink.Async(request, callSettings).ConfigureAwait(false), UpdateLinkOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteLink</c>.</summary>
        public override lro::OperationsClient DeleteLinkOperationsClient { get; }

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteLink(DeleteLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLinkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteLink.Sync(request, callSettings), DeleteLinkOperationsClient);
        }

        /// <summary>
        /// Delete a link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteLinkAsync(DeleteLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteLinkRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteLink.Async(request, callSettings).ConfigureAwait(false), DeleteLinkOperationsClient);
        }

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TraceScope GetTraceScope(GetTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTraceScopeRequest(ref request, ref callSettings);
            return _callGetTraceScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Get TraceScope resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TraceScope> GetTraceScopeAsync(GetTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTraceScopeRequest(ref request, ref callSettings);
            return _callGetTraceScope.Async(request, callSettings);
        }

        /// <summary>
        /// List TraceScopes of a project in a particular location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TraceScope"/> resources.</returns>
        public override gax::PagedEnumerable<ListTraceScopesResponse, TraceScope> ListTraceScopes(ListTraceScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTraceScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTraceScopesRequest, ListTraceScopesResponse, TraceScope>(_callListTraceScopes, request, callSettings);
        }

        /// <summary>
        /// List TraceScopes of a project in a particular location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TraceScope"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTraceScopesResponse, TraceScope> ListTraceScopesAsync(ListTraceScopesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTraceScopesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTraceScopesRequest, ListTraceScopesResponse, TraceScope>(_callListTraceScopes, request, callSettings);
        }

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TraceScope CreateTraceScope(CreateTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTraceScopeRequest(ref request, ref callSettings);
            return _callCreateTraceScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TraceScope> CreateTraceScopeAsync(CreateTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateTraceScopeRequest(ref request, ref callSettings);
            return _callCreateTraceScope.Async(request, callSettings);
        }

        /// <summary>
        /// Update a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TraceScope UpdateTraceScope(UpdateTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTraceScopeRequest(ref request, ref callSettings);
            return _callUpdateTraceScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TraceScope> UpdateTraceScopeAsync(UpdateTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateTraceScopeRequest(ref request, ref callSettings);
            return _callUpdateTraceScope.Async(request, callSettings);
        }

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteTraceScope(DeleteTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTraceScopeRequest(ref request, ref callSettings);
            _callDeleteTraceScope.Sync(request, callSettings);
        }

        /// <summary>
        /// Delete a TraceScope.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteTraceScopeAsync(DeleteTraceScopeRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteTraceScopeRequest(ref request, ref callSettings);
            return _callDeleteTraceScope.Async(request, callSettings);
        }

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Settings GetSettings(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Get Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Settings> GetSettingsAsync(GetSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSettingsRequest(ref request, ref callSettings);
            return _callGetSettings.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateSettings</c>.</summary>
        public override lro::OperationsClient UpdateSettingsOperationsClient { get; }

        /// <summary>
        /// Update Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Settings, OperationMetadata> UpdateSettings(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Settings, OperationMetadata>(_callUpdateSettings.Sync(request, callSettings), UpdateSettingsOperationsClient);
        }

        /// <summary>
        /// Update Settings
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Settings, OperationMetadata>> UpdateSettingsAsync(UpdateSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSettingsRequest(ref request, ref callSettings);
            return new lro::Operation<Settings, OperationMetadata>(await _callUpdateSettings.Async(request, callSettings).ConfigureAwait(false), UpdateSettingsOperationsClient);
        }
    }

    public partial class ListBucketsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDatasetsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListViewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListLinksRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTraceScopesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBucketsResponse : gaxgrpc::IPageResponse<Bucket>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Bucket> GetEnumerator() => Buckets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDatasetsResponse : gaxgrpc::IPageResponse<Dataset>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Dataset> GetEnumerator() => Datasets.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListViewsResponse : gaxgrpc::IPageResponse<View>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<View> GetEnumerator() => Views.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListLinksResponse : gaxgrpc::IPageResponse<Link>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Link> GetEnumerator() => Links.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTraceScopesResponse : gaxgrpc::IPageResponse<TraceScope>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TraceScope> GetEnumerator() => TraceScopes.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Observability
    {
        public partial class ObservabilityClient
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

    public static partial class Observability
    {
        public partial class ObservabilityClient
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
