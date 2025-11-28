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

namespace Google.Cloud.ConfigDelivery.V1Beta
{
    /// <summary>Settings for <see cref="ConfigDeliveryClient"/> instances.</summary>
    public sealed partial class ConfigDeliverySettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConfigDeliverySettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConfigDeliverySettings"/>.</returns>
        public static ConfigDeliverySettings GetDefault() => new ConfigDeliverySettings();

        /// <summary>Constructs a new <see cref="ConfigDeliverySettings"/> object with default settings.</summary>
        public ConfigDeliverySettings()
        {
        }

        private ConfigDeliverySettings(ConfigDeliverySettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListResourceBundlesSettings = existing.ListResourceBundlesSettings;
            GetResourceBundleSettings = existing.GetResourceBundleSettings;
            CreateResourceBundleSettings = existing.CreateResourceBundleSettings;
            CreateResourceBundleOperationsSettings = existing.CreateResourceBundleOperationsSettings.Clone();
            UpdateResourceBundleSettings = existing.UpdateResourceBundleSettings;
            UpdateResourceBundleOperationsSettings = existing.UpdateResourceBundleOperationsSettings.Clone();
            DeleteResourceBundleSettings = existing.DeleteResourceBundleSettings;
            DeleteResourceBundleOperationsSettings = existing.DeleteResourceBundleOperationsSettings.Clone();
            ListFleetPackagesSettings = existing.ListFleetPackagesSettings;
            GetFleetPackageSettings = existing.GetFleetPackageSettings;
            CreateFleetPackageSettings = existing.CreateFleetPackageSettings;
            CreateFleetPackageOperationsSettings = existing.CreateFleetPackageOperationsSettings.Clone();
            UpdateFleetPackageSettings = existing.UpdateFleetPackageSettings;
            UpdateFleetPackageOperationsSettings = existing.UpdateFleetPackageOperationsSettings.Clone();
            DeleteFleetPackageSettings = existing.DeleteFleetPackageSettings;
            DeleteFleetPackageOperationsSettings = existing.DeleteFleetPackageOperationsSettings.Clone();
            ListReleasesSettings = existing.ListReleasesSettings;
            GetReleaseSettings = existing.GetReleaseSettings;
            CreateReleaseSettings = existing.CreateReleaseSettings;
            CreateReleaseOperationsSettings = existing.CreateReleaseOperationsSettings.Clone();
            UpdateReleaseSettings = existing.UpdateReleaseSettings;
            UpdateReleaseOperationsSettings = existing.UpdateReleaseOperationsSettings.Clone();
            DeleteReleaseSettings = existing.DeleteReleaseSettings;
            DeleteReleaseOperationsSettings = existing.DeleteReleaseOperationsSettings.Clone();
            ListVariantsSettings = existing.ListVariantsSettings;
            GetVariantSettings = existing.GetVariantSettings;
            CreateVariantSettings = existing.CreateVariantSettings;
            CreateVariantOperationsSettings = existing.CreateVariantOperationsSettings.Clone();
            UpdateVariantSettings = existing.UpdateVariantSettings;
            UpdateVariantOperationsSettings = existing.UpdateVariantOperationsSettings.Clone();
            DeleteVariantSettings = existing.DeleteVariantSettings;
            DeleteVariantOperationsSettings = existing.DeleteVariantOperationsSettings.Clone();
            ListRolloutsSettings = existing.ListRolloutsSettings;
            GetRolloutSettings = existing.GetRolloutSettings;
            SuspendRolloutSettings = existing.SuspendRolloutSettings;
            SuspendRolloutOperationsSettings = existing.SuspendRolloutOperationsSettings.Clone();
            ResumeRolloutSettings = existing.ResumeRolloutSettings;
            ResumeRolloutOperationsSettings = existing.ResumeRolloutOperationsSettings.Clone();
            AbortRolloutSettings = existing.AbortRolloutSettings;
            AbortRolloutOperationsSettings = existing.AbortRolloutOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConfigDeliverySettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.ListResourceBundles</c> and <c>ConfigDeliveryClient.ListResourceBundlesAsync</c>.
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
        public gaxgrpc::CallSettings ListResourceBundlesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.GetResourceBundle</c> and <c>ConfigDeliveryClient.GetResourceBundleAsync</c>.
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
        public gaxgrpc::CallSettings GetResourceBundleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.CreateResourceBundle</c> and <c>ConfigDeliveryClient.CreateResourceBundleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateResourceBundleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.CreateResourceBundle</c> and
        /// <c>ConfigDeliveryClient.CreateResourceBundleAsync</c>.
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
        public lro::OperationsSettings CreateResourceBundleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.UpdateResourceBundle</c> and <c>ConfigDeliveryClient.UpdateResourceBundleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateResourceBundleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.UpdateResourceBundle</c> and
        /// <c>ConfigDeliveryClient.UpdateResourceBundleAsync</c>.
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
        public lro::OperationsSettings UpdateResourceBundleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.DeleteResourceBundle</c> and <c>ConfigDeliveryClient.DeleteResourceBundleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteResourceBundleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.DeleteResourceBundle</c> and
        /// <c>ConfigDeliveryClient.DeleteResourceBundleAsync</c>.
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
        public lro::OperationsSettings DeleteResourceBundleOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.ListFleetPackages</c> and <c>ConfigDeliveryClient.ListFleetPackagesAsync</c>.
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
        public gaxgrpc::CallSettings ListFleetPackagesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.GetFleetPackage</c> and <c>ConfigDeliveryClient.GetFleetPackageAsync</c>.
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
        public gaxgrpc::CallSettings GetFleetPackageSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.CreateFleetPackage</c> and <c>ConfigDeliveryClient.CreateFleetPackageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateFleetPackageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.CreateFleetPackage</c> and
        /// <c>ConfigDeliveryClient.CreateFleetPackageAsync</c>.
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
        public lro::OperationsSettings CreateFleetPackageOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.UpdateFleetPackage</c> and <c>ConfigDeliveryClient.UpdateFleetPackageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateFleetPackageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.UpdateFleetPackage</c> and
        /// <c>ConfigDeliveryClient.UpdateFleetPackageAsync</c>.
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
        public lro::OperationsSettings UpdateFleetPackageOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.DeleteFleetPackage</c> and <c>ConfigDeliveryClient.DeleteFleetPackageAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteFleetPackageSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.DeleteFleetPackage</c> and
        /// <c>ConfigDeliveryClient.DeleteFleetPackageAsync</c>.
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
        public lro::OperationsSettings DeleteFleetPackageOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.ListReleases</c> and <c>ConfigDeliveryClient.ListReleasesAsync</c>.
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
        public gaxgrpc::CallSettings ListReleasesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.GetRelease</c> and <c>ConfigDeliveryClient.GetReleaseAsync</c>.
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
        public gaxgrpc::CallSettings GetReleaseSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.CreateRelease</c> and <c>ConfigDeliveryClient.CreateReleaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateReleaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.CreateRelease</c> and
        /// <c>ConfigDeliveryClient.CreateReleaseAsync</c>.
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
        public lro::OperationsSettings CreateReleaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.UpdateRelease</c> and <c>ConfigDeliveryClient.UpdateReleaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateReleaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.UpdateRelease</c> and
        /// <c>ConfigDeliveryClient.UpdateReleaseAsync</c>.
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
        public lro::OperationsSettings UpdateReleaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.DeleteRelease</c> and <c>ConfigDeliveryClient.DeleteReleaseAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteReleaseSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.DeleteRelease</c> and
        /// <c>ConfigDeliveryClient.DeleteReleaseAsync</c>.
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
        public lro::OperationsSettings DeleteReleaseOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.ListVariants</c> and <c>ConfigDeliveryClient.ListVariantsAsync</c>.
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
        public gaxgrpc::CallSettings ListVariantsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.GetVariant</c> and <c>ConfigDeliveryClient.GetVariantAsync</c>.
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
        public gaxgrpc::CallSettings GetVariantSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.CreateVariant</c> and <c>ConfigDeliveryClient.CreateVariantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateVariantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.CreateVariant</c> and
        /// <c>ConfigDeliveryClient.CreateVariantAsync</c>.
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
        public lro::OperationsSettings CreateVariantOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.UpdateVariant</c> and <c>ConfigDeliveryClient.UpdateVariantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateVariantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.UpdateVariant</c> and
        /// <c>ConfigDeliveryClient.UpdateVariantAsync</c>.
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
        public lro::OperationsSettings UpdateVariantOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.DeleteVariant</c> and <c>ConfigDeliveryClient.DeleteVariantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteVariantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.DeleteVariant</c> and
        /// <c>ConfigDeliveryClient.DeleteVariantAsync</c>.
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
        public lro::OperationsSettings DeleteVariantOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.ListRollouts</c> and <c>ConfigDeliveryClient.ListRolloutsAsync</c>.
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
        public gaxgrpc::CallSettings ListRolloutsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.GetRollout</c> and <c>ConfigDeliveryClient.GetRolloutAsync</c>.
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
        public gaxgrpc::CallSettings GetRolloutSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.SuspendRollout</c> and <c>ConfigDeliveryClient.SuspendRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SuspendRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.SuspendRollout</c> and
        /// <c>ConfigDeliveryClient.SuspendRolloutAsync</c>.
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
        public lro::OperationsSettings SuspendRolloutOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.ResumeRollout</c> and <c>ConfigDeliveryClient.ResumeRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ResumeRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.ResumeRollout</c> and
        /// <c>ConfigDeliveryClient.ResumeRolloutAsync</c>.
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
        public lro::OperationsSettings ResumeRolloutOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigDeliveryClient.AbortRollout</c> and <c>ConfigDeliveryClient.AbortRolloutAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AbortRolloutSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigDeliveryClient.AbortRollout</c> and
        /// <c>ConfigDeliveryClient.AbortRolloutAsync</c>.
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
        public lro::OperationsSettings AbortRolloutOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConfigDeliverySettings"/> object.</returns>
        public ConfigDeliverySettings Clone() => new ConfigDeliverySettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConfigDeliveryClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class ConfigDeliveryClientBuilder : gaxgrpc::ClientBuilderBase<ConfigDeliveryClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConfigDeliverySettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConfigDeliveryClientBuilder() : base(ConfigDeliveryClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConfigDeliveryClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConfigDeliveryClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConfigDeliveryClient Build()
        {
            ConfigDeliveryClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConfigDeliveryClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConfigDeliveryClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConfigDeliveryClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConfigDeliveryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConfigDeliveryClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConfigDeliveryClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConfigDeliveryClient.ChannelPool;
    }

    /// <summary>ConfigDelivery client wrapper, for convenient use.</summary>
    /// <remarks>
    /// ConfigDelivery service manages the deployment of kubernetes configuration to
    /// a fleet of kubernetes clusters.
    /// </remarks>
    public abstract partial class ConfigDeliveryClient
    {
        /// <summary>
        /// The default endpoint for the ConfigDelivery service, which is a host of "configdelivery.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "configdelivery.googleapis.com:443";

        /// <summary>The default ConfigDelivery scopes.</summary>
        /// <remarks>
        /// The default ConfigDelivery scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConfigDelivery.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigDeliveryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConfigDeliveryClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConfigDeliveryClient"/>.</returns>
        public static stt::Task<ConfigDeliveryClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConfigDeliveryClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConfigDeliveryClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ConfigDeliveryClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConfigDeliveryClient"/>.</returns>
        public static ConfigDeliveryClient Create() => new ConfigDeliveryClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConfigDeliveryClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConfigDeliverySettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConfigDeliveryClient"/>.</returns>
        internal static ConfigDeliveryClient Create(grpccore::CallInvoker callInvoker, ConfigDeliverySettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConfigDelivery.ConfigDeliveryClient grpcClient = new ConfigDelivery.ConfigDeliveryClient(callInvoker);
            return new ConfigDeliveryClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConfigDelivery client</summary>
        public virtual ConfigDelivery.ConfigDeliveryClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ResourceBundles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceBundle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceBundlesResponse, ResourceBundle> ListResourceBundles(ListResourceBundlesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ResourceBundles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceBundle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceBundlesResponse, ResourceBundle> ListResourceBundlesAsync(ListResourceBundlesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists ResourceBundles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListResourceBundlesRequest.
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
        /// <returns>A pageable sequence of <see cref="ResourceBundle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceBundlesResponse, ResourceBundle> ListResourceBundles(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceBundlesRequest request = new ListResourceBundlesRequest
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
            return ListResourceBundles(request, callSettings);
        }

        /// <summary>
        /// Lists ResourceBundles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListResourceBundlesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceBundle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceBundlesResponse, ResourceBundle> ListResourceBundlesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceBundlesRequest request = new ListResourceBundlesRequest
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
            return ListResourceBundlesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists ResourceBundles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListResourceBundlesRequest.
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
        /// <returns>A pageable sequence of <see cref="ResourceBundle"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourceBundlesResponse, ResourceBundle> ListResourceBundles(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceBundlesRequest request = new ListResourceBundlesRequest
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
            return ListResourceBundles(request, callSettings);
        }

        /// <summary>
        /// Lists ResourceBundles in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListResourceBundlesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceBundle"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourceBundlesResponse, ResourceBundle> ListResourceBundlesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourceBundlesRequest request = new ListResourceBundlesRequest
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
            return ListResourceBundlesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceBundle GetResourceBundle(GetResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceBundle> GetResourceBundleAsync(GetResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceBundle> GetResourceBundleAsync(GetResourceBundleRequest request, st::CancellationToken cancellationToken) =>
            GetResourceBundleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceBundle GetResourceBundle(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceBundle(new GetResourceBundleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceBundle> GetResourceBundleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceBundleAsync(new GetResourceBundleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceBundle> GetResourceBundleAsync(string name, st::CancellationToken cancellationToken) =>
            GetResourceBundleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ResourceBundle GetResourceBundle(ResourceBundleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceBundle(new GetResourceBundleRequest
            {
                ResourceBundleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceBundle> GetResourceBundleAsync(ResourceBundleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceBundleAsync(new GetResourceBundleRequest
            {
                ResourceBundleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ResourceBundle> GetResourceBundleAsync(ResourceBundleName name, st::CancellationToken cancellationToken) =>
            GetResourceBundleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResourceBundle, OperationMetadata> CreateResourceBundle(CreateResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> CreateResourceBundleAsync(CreateResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> CreateResourceBundleAsync(CreateResourceBundleRequest request, st::CancellationToken cancellationToken) =>
            CreateResourceBundleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateResourceBundle</c>.</summary>
        public virtual lro::OperationsClient CreateResourceBundleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateResourceBundle</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ResourceBundle, OperationMetadata> PollOnceCreateResourceBundle(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResourceBundle, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateResourceBundleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateResourceBundle</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> PollOnceCreateResourceBundleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResourceBundle, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateResourceBundleOperationsClient, callSettings);

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="resourceBundle">
        /// Required. The resource being created
        /// </param>
        /// <param name="resourceBundleId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// resource_bundle_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResourceBundle, OperationMetadata> CreateResourceBundle(string parent, ResourceBundle resourceBundle, string resourceBundleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateResourceBundle(new CreateResourceBundleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ResourceBundleId = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)),
                ResourceBundle = gax::GaxPreconditions.CheckNotNull(resourceBundle, nameof(resourceBundle)),
            }, callSettings);

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="resourceBundle">
        /// Required. The resource being created
        /// </param>
        /// <param name="resourceBundleId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// resource_bundle_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> CreateResourceBundleAsync(string parent, ResourceBundle resourceBundle, string resourceBundleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateResourceBundleAsync(new CreateResourceBundleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ResourceBundleId = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)),
                ResourceBundle = gax::GaxPreconditions.CheckNotNull(resourceBundle, nameof(resourceBundle)),
            }, callSettings);

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="resourceBundle">
        /// Required. The resource being created
        /// </param>
        /// <param name="resourceBundleId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// resource_bundle_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> CreateResourceBundleAsync(string parent, ResourceBundle resourceBundle, string resourceBundleId, st::CancellationToken cancellationToken) =>
            CreateResourceBundleAsync(parent, resourceBundle, resourceBundleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="resourceBundle">
        /// Required. The resource being created
        /// </param>
        /// <param name="resourceBundleId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// resource_bundle_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResourceBundle, OperationMetadata> CreateResourceBundle(gagr::LocationName parent, ResourceBundle resourceBundle, string resourceBundleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateResourceBundle(new CreateResourceBundleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ResourceBundleId = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)),
                ResourceBundle = gax::GaxPreconditions.CheckNotNull(resourceBundle, nameof(resourceBundle)),
            }, callSettings);

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="resourceBundle">
        /// Required. The resource being created
        /// </param>
        /// <param name="resourceBundleId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// resource_bundle_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> CreateResourceBundleAsync(gagr::LocationName parent, ResourceBundle resourceBundle, string resourceBundleId, gaxgrpc::CallSettings callSettings = null) =>
            CreateResourceBundleAsync(new CreateResourceBundleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ResourceBundleId = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceBundleId, nameof(resourceBundleId)),
                ResourceBundle = gax::GaxPreconditions.CheckNotNull(resourceBundle, nameof(resourceBundle)),
            }, callSettings);

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="resourceBundle">
        /// Required. The resource being created
        /// </param>
        /// <param name="resourceBundleId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// resource_bundle_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> CreateResourceBundleAsync(gagr::LocationName parent, ResourceBundle resourceBundle, string resourceBundleId, st::CancellationToken cancellationToken) =>
            CreateResourceBundleAsync(parent, resourceBundle, resourceBundleId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResourceBundle, OperationMetadata> UpdateResourceBundle(UpdateResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> UpdateResourceBundleAsync(UpdateResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> UpdateResourceBundleAsync(UpdateResourceBundleRequest request, st::CancellationToken cancellationToken) =>
            UpdateResourceBundleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateResourceBundle</c>.</summary>
        public virtual lro::OperationsClient UpdateResourceBundleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateResourceBundle</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<ResourceBundle, OperationMetadata> PollOnceUpdateResourceBundle(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResourceBundle, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateResourceBundleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateResourceBundle</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> PollOnceUpdateResourceBundleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<ResourceBundle, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateResourceBundleOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single ResourceBundle.
        /// </summary>
        /// <param name="resourceBundle">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ResourceBundle resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<ResourceBundle, OperationMetadata> UpdateResourceBundle(ResourceBundle resourceBundle, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateResourceBundle(new UpdateResourceBundleRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ResourceBundle = gax::GaxPreconditions.CheckNotNull(resourceBundle, nameof(resourceBundle)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ResourceBundle.
        /// </summary>
        /// <param name="resourceBundle">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ResourceBundle resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> UpdateResourceBundleAsync(ResourceBundle resourceBundle, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateResourceBundleAsync(new UpdateResourceBundleRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                ResourceBundle = gax::GaxPreconditions.CheckNotNull(resourceBundle, nameof(resourceBundle)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single ResourceBundle.
        /// </summary>
        /// <param name="resourceBundle">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// ResourceBundle resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> UpdateResourceBundleAsync(ResourceBundle resourceBundle, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateResourceBundleAsync(resourceBundle, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteResourceBundle(DeleteResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceBundleAsync(DeleteResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceBundleAsync(DeleteResourceBundleRequest request, st::CancellationToken cancellationToken) =>
            DeleteResourceBundleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteResourceBundle</c>.</summary>
        public virtual lro::OperationsClient DeleteResourceBundleOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteResourceBundle</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteResourceBundle(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteResourceBundleOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteResourceBundle</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteResourceBundleAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteResourceBundleOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteResourceBundle(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceBundle(new DeleteResourceBundleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceBundleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceBundleAsync(new DeleteResourceBundleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceBundleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteResourceBundleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteResourceBundle(ResourceBundleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceBundle(new DeleteResourceBundleRequest
            {
                ResourceBundleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceBundleAsync(ResourceBundleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteResourceBundleAsync(new DeleteResourceBundleRequest
            {
                ResourceBundleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceBundleAsync(ResourceBundleName name, st::CancellationToken cancellationToken) =>
            DeleteResourceBundleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists FleetPackages in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FleetPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFleetPackagesResponse, FleetPackage> ListFleetPackages(ListFleetPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FleetPackages in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FleetPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFleetPackagesResponse, FleetPackage> ListFleetPackagesAsync(ListFleetPackagesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists FleetPackages in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFleetPackagesRequest.
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
        /// <returns>A pageable sequence of <see cref="FleetPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFleetPackagesResponse, FleetPackage> ListFleetPackages(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFleetPackagesRequest request = new ListFleetPackagesRequest
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
            return ListFleetPackages(request, callSettings);
        }

        /// <summary>
        /// Lists FleetPackages in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFleetPackagesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FleetPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFleetPackagesResponse, FleetPackage> ListFleetPackagesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFleetPackagesRequest request = new ListFleetPackagesRequest
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
            return ListFleetPackagesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists FleetPackages in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFleetPackagesRequest.
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
        /// <returns>A pageable sequence of <see cref="FleetPackage"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListFleetPackagesResponse, FleetPackage> ListFleetPackages(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFleetPackagesRequest request = new ListFleetPackagesRequest
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
            return ListFleetPackages(request, callSettings);
        }

        /// <summary>
        /// Lists FleetPackages in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListFleetPackagesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="FleetPackage"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListFleetPackagesResponse, FleetPackage> ListFleetPackagesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListFleetPackagesRequest request = new ListFleetPackagesRequest
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
            return ListFleetPackagesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FleetPackage GetFleetPackage(GetFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FleetPackage> GetFleetPackageAsync(GetFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FleetPackage> GetFleetPackageAsync(GetFleetPackageRequest request, st::CancellationToken cancellationToken) =>
            GetFleetPackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FleetPackage GetFleetPackage(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFleetPackage(new GetFleetPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FleetPackage> GetFleetPackageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetFleetPackageAsync(new GetFleetPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FleetPackage> GetFleetPackageAsync(string name, st::CancellationToken cancellationToken) =>
            GetFleetPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FleetPackage GetFleetPackage(FleetPackageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFleetPackage(new GetFleetPackageRequest
            {
                FleetPackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FleetPackage> GetFleetPackageAsync(FleetPackageName name, gaxgrpc::CallSettings callSettings = null) =>
            GetFleetPackageAsync(new GetFleetPackageRequest
            {
                FleetPackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FleetPackage> GetFleetPackageAsync(FleetPackageName name, st::CancellationToken cancellationToken) =>
            GetFleetPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FleetPackage, OperationMetadata> CreateFleetPackage(CreateFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> CreateFleetPackageAsync(CreateFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> CreateFleetPackageAsync(CreateFleetPackageRequest request, st::CancellationToken cancellationToken) =>
            CreateFleetPackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateFleetPackage</c>.</summary>
        public virtual lro::OperationsClient CreateFleetPackageOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateFleetPackage</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FleetPackage, OperationMetadata> PollOnceCreateFleetPackage(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FleetPackage, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFleetPackageOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateFleetPackage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> PollOnceCreateFleetPackageAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FleetPackage, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateFleetPackageOperationsClient, callSettings);

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="fleetPackage">
        /// Required. The resource being created.
        /// </param>
        /// <param name="fleetPackageId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// fleet_package_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FleetPackage, OperationMetadata> CreateFleetPackage(string parent, FleetPackage fleetPackage, string fleetPackageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFleetPackage(new CreateFleetPackageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FleetPackageId = gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)),
                FleetPackage = gax::GaxPreconditions.CheckNotNull(fleetPackage, nameof(fleetPackage)),
            }, callSettings);

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="fleetPackage">
        /// Required. The resource being created.
        /// </param>
        /// <param name="fleetPackageId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// fleet_package_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> CreateFleetPackageAsync(string parent, FleetPackage fleetPackage, string fleetPackageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFleetPackageAsync(new CreateFleetPackageRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                FleetPackageId = gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)),
                FleetPackage = gax::GaxPreconditions.CheckNotNull(fleetPackage, nameof(fleetPackage)),
            }, callSettings);

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="fleetPackage">
        /// Required. The resource being created.
        /// </param>
        /// <param name="fleetPackageId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// fleet_package_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> CreateFleetPackageAsync(string parent, FleetPackage fleetPackage, string fleetPackageId, st::CancellationToken cancellationToken) =>
            CreateFleetPackageAsync(parent, fleetPackage, fleetPackageId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="fleetPackage">
        /// Required. The resource being created.
        /// </param>
        /// <param name="fleetPackageId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// fleet_package_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FleetPackage, OperationMetadata> CreateFleetPackage(gagr::LocationName parent, FleetPackage fleetPackage, string fleetPackageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFleetPackage(new CreateFleetPackageRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FleetPackageId = gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)),
                FleetPackage = gax::GaxPreconditions.CheckNotNull(fleetPackage, nameof(fleetPackage)),
            }, callSettings);

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="fleetPackage">
        /// Required. The resource being created.
        /// </param>
        /// <param name="fleetPackageId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// fleet_package_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> CreateFleetPackageAsync(gagr::LocationName parent, FleetPackage fleetPackage, string fleetPackageId, gaxgrpc::CallSettings callSettings = null) =>
            CreateFleetPackageAsync(new CreateFleetPackageRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                FleetPackageId = gax::GaxPreconditions.CheckNotNullOrEmpty(fleetPackageId, nameof(fleetPackageId)),
                FleetPackage = gax::GaxPreconditions.CheckNotNull(fleetPackage, nameof(fleetPackage)),
            }, callSettings);

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="fleetPackage">
        /// Required. The resource being created.
        /// </param>
        /// <param name="fleetPackageId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// fleet_package_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> CreateFleetPackageAsync(gagr::LocationName parent, FleetPackage fleetPackage, string fleetPackageId, st::CancellationToken cancellationToken) =>
            CreateFleetPackageAsync(parent, fleetPackage, fleetPackageId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FleetPackage, OperationMetadata> UpdateFleetPackage(UpdateFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> UpdateFleetPackageAsync(UpdateFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> UpdateFleetPackageAsync(UpdateFleetPackageRequest request, st::CancellationToken cancellationToken) =>
            UpdateFleetPackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateFleetPackage</c>.</summary>
        public virtual lro::OperationsClient UpdateFleetPackageOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateFleetPackage</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<FleetPackage, OperationMetadata> PollOnceUpdateFleetPackage(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FleetPackage, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFleetPackageOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateFleetPackage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> PollOnceUpdateFleetPackageAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<FleetPackage, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateFleetPackageOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single FleetPackage.
        /// </summary>
        /// <param name="fleetPackage">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// FleetPackage resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<FleetPackage, OperationMetadata> UpdateFleetPackage(FleetPackage fleetPackage, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFleetPackage(new UpdateFleetPackageRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                FleetPackage = gax::GaxPreconditions.CheckNotNull(fleetPackage, nameof(fleetPackage)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FleetPackage.
        /// </summary>
        /// <param name="fleetPackage">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// FleetPackage resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> UpdateFleetPackageAsync(FleetPackage fleetPackage, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateFleetPackageAsync(new UpdateFleetPackageRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                FleetPackage = gax::GaxPreconditions.CheckNotNull(fleetPackage, nameof(fleetPackage)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single FleetPackage.
        /// </summary>
        /// <param name="fleetPackage">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// FleetPackage resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<FleetPackage, OperationMetadata>> UpdateFleetPackageAsync(FleetPackage fleetPackage, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateFleetPackageAsync(fleetPackage, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFleetPackage(DeleteFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetPackageAsync(DeleteFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetPackageAsync(DeleteFleetPackageRequest request, st::CancellationToken cancellationToken) =>
            DeleteFleetPackageAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteFleetPackage</c>.</summary>
        public virtual lro::OperationsClient DeleteFleetPackageOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteFleetPackage</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteFleetPackage(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFleetPackageOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteFleetPackage</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteFleetPackageAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteFleetPackageOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFleetPackage(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFleetPackage(new DeleteFleetPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetPackageAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFleetPackageAsync(new DeleteFleetPackageRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetPackageAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteFleetPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteFleetPackage(FleetPackageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFleetPackage(new DeleteFleetPackageRequest
            {
                FleetPackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetPackageAsync(FleetPackageName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteFleetPackageAsync(new DeleteFleetPackageRequest
            {
                FleetPackageName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetPackageAsync(FleetPackageName name, st::CancellationToken cancellationToken) =>
            DeleteFleetPackageAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReleasesRequest.
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
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleasesRequest request = new ListReleasesRequest
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
            return ListReleases(request, callSettings);
        }

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReleasesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleasesRequest request = new ListReleasesRequest
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
            return ListReleasesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReleasesRequest.
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
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(ResourceBundleName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleasesRequest request = new ListReleasesRequest
            {
                ParentAsResourceBundleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReleases(request, callSettings);
        }

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListReleasesRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(ResourceBundleName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListReleasesRequest request = new ListReleasesRequest
            {
                ParentAsResourceBundleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListReleasesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRelease(new GetReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseAsync(new GetReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(string name, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Release GetRelease(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRelease(new GetReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReleaseAsync(new GetReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Release> GetReleaseAsync(ReleaseName name, st::CancellationToken cancellationToken) =>
            GetReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Release, OperationMetadata> CreateRelease(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(CreateReleaseRequest request, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateRelease</c>.</summary>
        public virtual lro::OperationsClient CreateReleaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateRelease</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Release, OperationMetadata> PollOnceCreateRelease(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Release, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReleaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateRelease</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> PollOnceCreateReleaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Release, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateReleaseOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="release">
        /// Required. The resource being created
        /// </param>
        /// <param name="releaseId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// release_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Release, OperationMetadata> CreateRelease(string parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRelease(new CreateReleaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="release">
        /// Required. The resource being created
        /// </param>
        /// <param name="releaseId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// release_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(string parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseAsync(new CreateReleaseRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="release">
        /// Required. The resource being created
        /// </param>
        /// <param name="releaseId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// release_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(string parent, Release release, string releaseId, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(parent, release, releaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="release">
        /// Required. The resource being created
        /// </param>
        /// <param name="releaseId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// release_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Release, OperationMetadata> CreateRelease(ResourceBundleName parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateRelease(new CreateReleaseRequest
            {
                ParentAsResourceBundleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="release">
        /// Required. The resource being created
        /// </param>
        /// <param name="releaseId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// release_id from the method_signature of Create RPC
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(ResourceBundleName parent, Release release, string releaseId, gaxgrpc::CallSettings callSettings = null) =>
            CreateReleaseAsync(new CreateReleaseRequest
            {
                ParentAsResourceBundleName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                ReleaseId = gax::GaxPreconditions.CheckNotNullOrEmpty(releaseId, nameof(releaseId)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="release">
        /// Required. The resource being created
        /// </param>
        /// <param name="releaseId">
        /// Required. Id of the requesting object
        /// If auto-generating Id server-side, remove this field and
        /// release_id from the method_signature of Create RPC
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(ResourceBundleName parent, Release release, string releaseId, st::CancellationToken cancellationToken) =>
            CreateReleaseAsync(parent, release, releaseId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Release, OperationMetadata> UpdateRelease(UpdateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> UpdateReleaseAsync(UpdateReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> UpdateReleaseAsync(UpdateReleaseRequest request, st::CancellationToken cancellationToken) =>
            UpdateReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateRelease</c>.</summary>
        public virtual lro::OperationsClient UpdateReleaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateRelease</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Release, OperationMetadata> PollOnceUpdateRelease(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Release, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateReleaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateRelease</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> PollOnceUpdateReleaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Release, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateReleaseOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Release.
        /// </summary>
        /// <param name="release">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Release resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Release, OperationMetadata> UpdateRelease(Release release, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateRelease(new UpdateReleaseRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Release.
        /// </summary>
        /// <param name="release">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Release resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> UpdateReleaseAsync(Release release, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateReleaseAsync(new UpdateReleaseRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                Release = gax::GaxPreconditions.CheckNotNull(release, nameof(release)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Release.
        /// </summary>
        /// <param name="release">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Required. Field mask is used to specify the fields to be overwritten in the
        /// Release resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Release, OperationMetadata>> UpdateReleaseAsync(Release release, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateReleaseAsync(release, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRelease(DeleteReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReleaseAsync(DeleteReleaseRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReleaseAsync(DeleteReleaseRequest request, st::CancellationToken cancellationToken) =>
            DeleteReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteRelease</c>.</summary>
        public virtual lro::OperationsClient DeleteReleaseOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteRelease</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteRelease(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReleaseOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteRelease</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteReleaseAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteReleaseOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRelease(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRelease(new DeleteReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReleaseAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReleaseAsync(new DeleteReleaseRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReleaseAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteRelease(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteRelease(new DeleteReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReleaseAsync(ReleaseName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteReleaseAsync(new DeleteReleaseRequest
            {
                ReleaseName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReleaseAsync(ReleaseName name, st::CancellationToken cancellationToken) =>
            DeleteReleaseAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Variants in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Variant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVariantsResponse, Variant> ListVariants(ListVariantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Variants in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Variant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVariantsResponse, Variant> ListVariantsAsync(ListVariantsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Variants in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVariantsRequest.
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
        /// <returns>A pageable sequence of <see cref="Variant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVariantsResponse, Variant> ListVariants(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVariantsRequest request = new ListVariantsRequest
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
            return ListVariants(request, callSettings);
        }

        /// <summary>
        /// Lists Variants in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVariantsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Variant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVariantsResponse, Variant> ListVariantsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVariantsRequest request = new ListVariantsRequest
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
            return ListVariantsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Variants in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVariantsRequest.
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
        /// <returns>A pageable sequence of <see cref="Variant"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListVariantsResponse, Variant> ListVariants(ReleaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVariantsRequest request = new ListVariantsRequest
            {
                ParentAsReleaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVariants(request, callSettings);
        }

        /// <summary>
        /// Lists Variants in a given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListVariantsRequest.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Variant"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListVariantsResponse, Variant> ListVariantsAsync(ReleaseName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListVariantsRequest request = new ListVariantsRequest
            {
                ParentAsReleaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListVariantsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Variant GetVariant(GetVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Variant> GetVariantAsync(GetVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Variant> GetVariantAsync(GetVariantRequest request, st::CancellationToken cancellationToken) =>
            GetVariantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Variant GetVariant(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVariant(new GetVariantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Variant> GetVariantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetVariantAsync(new GetVariantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Variant> GetVariantAsync(string name, st::CancellationToken cancellationToken) =>
            GetVariantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Variant GetVariant(VariantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVariant(new GetVariantRequest
            {
                VariantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Variant> GetVariantAsync(VariantName name, gaxgrpc::CallSettings callSettings = null) =>
            GetVariantAsync(new GetVariantRequest
            {
                VariantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Variant> GetVariantAsync(VariantName name, st::CancellationToken cancellationToken) =>
            GetVariantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Variant, OperationMetadata> CreateVariant(CreateVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> CreateVariantAsync(CreateVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> CreateVariantAsync(CreateVariantRequest request, st::CancellationToken cancellationToken) =>
            CreateVariantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateVariant</c>.</summary>
        public virtual lro::OperationsClient CreateVariantOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateVariant</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Variant, OperationMetadata> PollOnceCreateVariant(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Variant, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVariantOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateVariant</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> PollOnceCreateVariantAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Variant, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateVariantOperationsClient, callSettings);

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="variant">
        /// Required. The resource being created
        /// </param>
        /// <param name="variantId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Variant, OperationMetadata> CreateVariant(string parent, Variant variant, string variantId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVariant(new CreateVariantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VariantId = gax::GaxPreconditions.CheckNotNullOrEmpty(variantId, nameof(variantId)),
                Variant = gax::GaxPreconditions.CheckNotNull(variant, nameof(variant)),
            }, callSettings);

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="variant">
        /// Required. The resource being created
        /// </param>
        /// <param name="variantId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> CreateVariantAsync(string parent, Variant variant, string variantId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVariantAsync(new CreateVariantRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                VariantId = gax::GaxPreconditions.CheckNotNullOrEmpty(variantId, nameof(variantId)),
                Variant = gax::GaxPreconditions.CheckNotNull(variant, nameof(variant)),
            }, callSettings);

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="variant">
        /// Required. The resource being created
        /// </param>
        /// <param name="variantId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> CreateVariantAsync(string parent, Variant variant, string variantId, st::CancellationToken cancellationToken) =>
            CreateVariantAsync(parent, variant, variantId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="variant">
        /// Required. The resource being created
        /// </param>
        /// <param name="variantId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Variant, OperationMetadata> CreateVariant(ReleaseName parent, Variant variant, string variantId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVariant(new CreateVariantRequest
            {
                ParentAsReleaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VariantId = gax::GaxPreconditions.CheckNotNullOrEmpty(variantId, nameof(variantId)),
                Variant = gax::GaxPreconditions.CheckNotNull(variant, nameof(variant)),
            }, callSettings);

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="variant">
        /// Required. The resource being created
        /// </param>
        /// <param name="variantId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> CreateVariantAsync(ReleaseName parent, Variant variant, string variantId, gaxgrpc::CallSettings callSettings = null) =>
            CreateVariantAsync(new CreateVariantRequest
            {
                ParentAsReleaseName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                VariantId = gax::GaxPreconditions.CheckNotNullOrEmpty(variantId, nameof(variantId)),
                Variant = gax::GaxPreconditions.CheckNotNull(variant, nameof(variant)),
            }, callSettings);

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="parent">
        /// Required. Value for parent.
        /// </param>
        /// <param name="variant">
        /// Required. The resource being created
        /// </param>
        /// <param name="variantId">
        /// Required. Id of the requesting object
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> CreateVariantAsync(ReleaseName parent, Variant variant, string variantId, st::CancellationToken cancellationToken) =>
            CreateVariantAsync(parent, variant, variantId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the parameters of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Variant, OperationMetadata> UpdateVariant(UpdateVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> UpdateVariantAsync(UpdateVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the parameters of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> UpdateVariantAsync(UpdateVariantRequest request, st::CancellationToken cancellationToken) =>
            UpdateVariantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateVariant</c>.</summary>
        public virtual lro::OperationsClient UpdateVariantOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateVariant</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Variant, OperationMetadata> PollOnceUpdateVariant(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Variant, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVariantOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateVariant</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> PollOnceUpdateVariantAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Variant, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateVariantOperationsClient, callSettings);

        /// <summary>
        /// Updates the parameters of a single Variant.
        /// </summary>
        /// <param name="variant">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Variant resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Variant, OperationMetadata> UpdateVariant(Variant variant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVariant(new UpdateVariantRequest
            {
                UpdateMask = updateMask,
                Variant = gax::GaxPreconditions.CheckNotNull(variant, nameof(variant)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Variant.
        /// </summary>
        /// <param name="variant">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Variant resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> UpdateVariantAsync(Variant variant, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateVariantAsync(new UpdateVariantRequest
            {
                UpdateMask = updateMask,
                Variant = gax::GaxPreconditions.CheckNotNull(variant, nameof(variant)),
            }, callSettings);

        /// <summary>
        /// Updates the parameters of a single Variant.
        /// </summary>
        /// <param name="variant">
        /// Required. The resource being updated
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask is used to specify the fields to be overwritten in the
        /// Variant resource by the update.
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Variant, OperationMetadata>> UpdateVariantAsync(Variant variant, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateVariantAsync(variant, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVariant(DeleteVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVariantAsync(DeleteVariantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVariantAsync(DeleteVariantRequest request, st::CancellationToken cancellationToken) =>
            DeleteVariantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteVariant</c>.</summary>
        public virtual lro::OperationsClient DeleteVariantOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteVariant</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteVariant(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVariantOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteVariant</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteVariantAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteVariantOperationsClient, callSettings);

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVariant(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVariant(new DeleteVariantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVariantAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVariantAsync(new DeleteVariantRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVariantAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteVariantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteVariant(VariantName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVariant(new DeleteVariantRequest
            {
                VariantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVariantAsync(VariantName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteVariantAsync(new DeleteVariantRequest
            {
                VariantName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVariantAsync(VariantName name, st::CancellationToken cancellationToken) =>
            DeleteVariantAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists Rollouts in a given project, location, and Fleet Package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Rollouts in a given project, location, and Fleet Package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists Rollouts in a given project, location, and Fleet Package.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRolloutsRequest
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
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutsRequest request = new ListRolloutsRequest
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
            return ListRollouts(request, callSettings);
        }

        /// <summary>
        /// Lists Rollouts in a given project, location, and Fleet Package.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRolloutsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutsRequest request = new ListRolloutsRequest
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
            return ListRolloutsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists Rollouts in a given project, location, and Fleet Package.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRolloutsRequest
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
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(FleetPackageName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                ParentAsFleetPackageName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRollouts(request, callSettings);
        }

        /// <summary>
        /// Lists Rollouts in a given project, location, and Fleet Package.
        /// </summary>
        /// <param name="parent">
        /// Required. Parent value for ListRolloutsRequest
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
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(FleetPackageName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRolloutsRequest request = new ListRolloutsRequest
            {
                ParentAsFleetPackageName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRolloutsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRollout(new GetRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutAsync(new GetRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Rollout GetRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRollout(new GetRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRolloutAsync(new GetRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Rollout> GetRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            GetRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> SuspendRollout(SuspendRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> SuspendRolloutAsync(SuspendRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> SuspendRolloutAsync(SuspendRolloutRequest request, st::CancellationToken cancellationToken) =>
            SuspendRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>SuspendRollout</c>.</summary>
        public virtual lro::OperationsClient SuspendRolloutOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>SuspendRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> PollOnceSuspendRollout(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuspendRolloutOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>SuspendRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> PollOnceSuspendRolloutAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), SuspendRolloutOperationsClient, callSettings);

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> SuspendRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            SuspendRollout(new SuspendRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> SuspendRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            SuspendRolloutAsync(new SuspendRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> SuspendRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            SuspendRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> SuspendRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            SuspendRollout(new SuspendRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> SuspendRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            SuspendRolloutAsync(new SuspendRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> SuspendRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            SuspendRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> ResumeRollout(ResumeRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> ResumeRolloutAsync(ResumeRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> ResumeRolloutAsync(ResumeRolloutRequest request, st::CancellationToken cancellationToken) =>
            ResumeRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ResumeRollout</c>.</summary>
        public virtual lro::OperationsClient ResumeRolloutOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ResumeRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> PollOnceResumeRollout(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeRolloutOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ResumeRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> PollOnceResumeRolloutAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ResumeRolloutOperationsClient, callSettings);

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> ResumeRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeRollout(new ResumeRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> ResumeRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeRolloutAsync(new ResumeRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> ResumeRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            ResumeRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> ResumeRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeRollout(new ResumeRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> ResumeRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            ResumeRolloutAsync(new ResumeRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> ResumeRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            ResumeRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> AbortRollout(AbortRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> AbortRolloutAsync(AbortRolloutRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> AbortRolloutAsync(AbortRolloutRequest request, st::CancellationToken cancellationToken) =>
            AbortRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>AbortRollout</c>.</summary>
        public virtual lro::OperationsClient AbortRolloutOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>AbortRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> PollOnceAbortRollout(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AbortRolloutOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>AbortRollout</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> PollOnceAbortRolloutAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Rollout, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), AbortRolloutOperationsClient, callSettings);

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> AbortRollout(string name, gaxgrpc::CallSettings callSettings = null) =>
            AbortRollout(new AbortRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> AbortRolloutAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            AbortRolloutAsync(new AbortRolloutRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> AbortRolloutAsync(string name, st::CancellationToken cancellationToken) =>
            AbortRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Rollout, OperationMetadata> AbortRollout(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            AbortRollout(new AbortRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> AbortRolloutAsync(RolloutName name, gaxgrpc::CallSettings callSettings = null) =>
            AbortRolloutAsync(new AbortRolloutRequest
            {
                RolloutName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="name">
        /// Required. Name of the Rollout.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Rollout, OperationMetadata>> AbortRolloutAsync(RolloutName name, st::CancellationToken cancellationToken) =>
            AbortRolloutAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConfigDelivery client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// ConfigDelivery service manages the deployment of kubernetes configuration to
    /// a fleet of kubernetes clusters.
    /// </remarks>
    public sealed partial class ConfigDeliveryClientImpl : ConfigDeliveryClient
    {
        private readonly gaxgrpc::ApiCall<ListResourceBundlesRequest, ListResourceBundlesResponse> _callListResourceBundles;

        private readonly gaxgrpc::ApiCall<GetResourceBundleRequest, ResourceBundle> _callGetResourceBundle;

        private readonly gaxgrpc::ApiCall<CreateResourceBundleRequest, lro::Operation> _callCreateResourceBundle;

        private readonly gaxgrpc::ApiCall<UpdateResourceBundleRequest, lro::Operation> _callUpdateResourceBundle;

        private readonly gaxgrpc::ApiCall<DeleteResourceBundleRequest, lro::Operation> _callDeleteResourceBundle;

        private readonly gaxgrpc::ApiCall<ListFleetPackagesRequest, ListFleetPackagesResponse> _callListFleetPackages;

        private readonly gaxgrpc::ApiCall<GetFleetPackageRequest, FleetPackage> _callGetFleetPackage;

        private readonly gaxgrpc::ApiCall<CreateFleetPackageRequest, lro::Operation> _callCreateFleetPackage;

        private readonly gaxgrpc::ApiCall<UpdateFleetPackageRequest, lro::Operation> _callUpdateFleetPackage;

        private readonly gaxgrpc::ApiCall<DeleteFleetPackageRequest, lro::Operation> _callDeleteFleetPackage;

        private readonly gaxgrpc::ApiCall<ListReleasesRequest, ListReleasesResponse> _callListReleases;

        private readonly gaxgrpc::ApiCall<GetReleaseRequest, Release> _callGetRelease;

        private readonly gaxgrpc::ApiCall<CreateReleaseRequest, lro::Operation> _callCreateRelease;

        private readonly gaxgrpc::ApiCall<UpdateReleaseRequest, lro::Operation> _callUpdateRelease;

        private readonly gaxgrpc::ApiCall<DeleteReleaseRequest, lro::Operation> _callDeleteRelease;

        private readonly gaxgrpc::ApiCall<ListVariantsRequest, ListVariantsResponse> _callListVariants;

        private readonly gaxgrpc::ApiCall<GetVariantRequest, Variant> _callGetVariant;

        private readonly gaxgrpc::ApiCall<CreateVariantRequest, lro::Operation> _callCreateVariant;

        private readonly gaxgrpc::ApiCall<UpdateVariantRequest, lro::Operation> _callUpdateVariant;

        private readonly gaxgrpc::ApiCall<DeleteVariantRequest, lro::Operation> _callDeleteVariant;

        private readonly gaxgrpc::ApiCall<ListRolloutsRequest, ListRolloutsResponse> _callListRollouts;

        private readonly gaxgrpc::ApiCall<GetRolloutRequest, Rollout> _callGetRollout;

        private readonly gaxgrpc::ApiCall<SuspendRolloutRequest, lro::Operation> _callSuspendRollout;

        private readonly gaxgrpc::ApiCall<ResumeRolloutRequest, lro::Operation> _callResumeRollout;

        private readonly gaxgrpc::ApiCall<AbortRolloutRequest, lro::Operation> _callAbortRollout;

        /// <summary>
        /// Constructs a client wrapper for the ConfigDelivery service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConfigDeliverySettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConfigDeliveryClientImpl(ConfigDelivery.ConfigDeliveryClient grpcClient, ConfigDeliverySettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConfigDeliverySettings effectiveSettings = settings ?? ConfigDeliverySettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateResourceBundleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateResourceBundleOperationsSettings, logger);
            UpdateResourceBundleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateResourceBundleOperationsSettings, logger);
            DeleteResourceBundleOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteResourceBundleOperationsSettings, logger);
            CreateFleetPackageOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateFleetPackageOperationsSettings, logger);
            UpdateFleetPackageOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateFleetPackageOperationsSettings, logger);
            DeleteFleetPackageOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteFleetPackageOperationsSettings, logger);
            CreateReleaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateReleaseOperationsSettings, logger);
            UpdateReleaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateReleaseOperationsSettings, logger);
            DeleteReleaseOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteReleaseOperationsSettings, logger);
            CreateVariantOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateVariantOperationsSettings, logger);
            UpdateVariantOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateVariantOperationsSettings, logger);
            DeleteVariantOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteVariantOperationsSettings, logger);
            SuspendRolloutOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.SuspendRolloutOperationsSettings, logger);
            ResumeRolloutOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ResumeRolloutOperationsSettings, logger);
            AbortRolloutOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.AbortRolloutOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListResourceBundles = clientHelper.BuildApiCall<ListResourceBundlesRequest, ListResourceBundlesResponse>("ListResourceBundles", grpcClient.ListResourceBundlesAsync, grpcClient.ListResourceBundles, effectiveSettings.ListResourceBundlesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListResourceBundles);
            Modify_ListResourceBundlesApiCall(ref _callListResourceBundles);
            _callGetResourceBundle = clientHelper.BuildApiCall<GetResourceBundleRequest, ResourceBundle>("GetResourceBundle", grpcClient.GetResourceBundleAsync, grpcClient.GetResourceBundle, effectiveSettings.GetResourceBundleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetResourceBundle);
            Modify_GetResourceBundleApiCall(ref _callGetResourceBundle);
            _callCreateResourceBundle = clientHelper.BuildApiCall<CreateResourceBundleRequest, lro::Operation>("CreateResourceBundle", grpcClient.CreateResourceBundleAsync, grpcClient.CreateResourceBundle, effectiveSettings.CreateResourceBundleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateResourceBundle);
            Modify_CreateResourceBundleApiCall(ref _callCreateResourceBundle);
            _callUpdateResourceBundle = clientHelper.BuildApiCall<UpdateResourceBundleRequest, lro::Operation>("UpdateResourceBundle", grpcClient.UpdateResourceBundleAsync, grpcClient.UpdateResourceBundle, effectiveSettings.UpdateResourceBundleSettings).WithGoogleRequestParam("resource_bundle.name", request => request.ResourceBundle?.Name);
            Modify_ApiCall(ref _callUpdateResourceBundle);
            Modify_UpdateResourceBundleApiCall(ref _callUpdateResourceBundle);
            _callDeleteResourceBundle = clientHelper.BuildApiCall<DeleteResourceBundleRequest, lro::Operation>("DeleteResourceBundle", grpcClient.DeleteResourceBundleAsync, grpcClient.DeleteResourceBundle, effectiveSettings.DeleteResourceBundleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteResourceBundle);
            Modify_DeleteResourceBundleApiCall(ref _callDeleteResourceBundle);
            _callListFleetPackages = clientHelper.BuildApiCall<ListFleetPackagesRequest, ListFleetPackagesResponse>("ListFleetPackages", grpcClient.ListFleetPackagesAsync, grpcClient.ListFleetPackages, effectiveSettings.ListFleetPackagesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListFleetPackages);
            Modify_ListFleetPackagesApiCall(ref _callListFleetPackages);
            _callGetFleetPackage = clientHelper.BuildApiCall<GetFleetPackageRequest, FleetPackage>("GetFleetPackage", grpcClient.GetFleetPackageAsync, grpcClient.GetFleetPackage, effectiveSettings.GetFleetPackageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetFleetPackage);
            Modify_GetFleetPackageApiCall(ref _callGetFleetPackage);
            _callCreateFleetPackage = clientHelper.BuildApiCall<CreateFleetPackageRequest, lro::Operation>("CreateFleetPackage", grpcClient.CreateFleetPackageAsync, grpcClient.CreateFleetPackage, effectiveSettings.CreateFleetPackageSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateFleetPackage);
            Modify_CreateFleetPackageApiCall(ref _callCreateFleetPackage);
            _callUpdateFleetPackage = clientHelper.BuildApiCall<UpdateFleetPackageRequest, lro::Operation>("UpdateFleetPackage", grpcClient.UpdateFleetPackageAsync, grpcClient.UpdateFleetPackage, effectiveSettings.UpdateFleetPackageSettings).WithGoogleRequestParam("fleet_package.name", request => request.FleetPackage?.Name);
            Modify_ApiCall(ref _callUpdateFleetPackage);
            Modify_UpdateFleetPackageApiCall(ref _callUpdateFleetPackage);
            _callDeleteFleetPackage = clientHelper.BuildApiCall<DeleteFleetPackageRequest, lro::Operation>("DeleteFleetPackage", grpcClient.DeleteFleetPackageAsync, grpcClient.DeleteFleetPackage, effectiveSettings.DeleteFleetPackageSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteFleetPackage);
            Modify_DeleteFleetPackageApiCall(ref _callDeleteFleetPackage);
            _callListReleases = clientHelper.BuildApiCall<ListReleasesRequest, ListReleasesResponse>("ListReleases", grpcClient.ListReleasesAsync, grpcClient.ListReleases, effectiveSettings.ListReleasesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReleases);
            Modify_ListReleasesApiCall(ref _callListReleases);
            _callGetRelease = clientHelper.BuildApiCall<GetReleaseRequest, Release>("GetRelease", grpcClient.GetReleaseAsync, grpcClient.GetRelease, effectiveSettings.GetReleaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRelease);
            Modify_GetReleaseApiCall(ref _callGetRelease);
            _callCreateRelease = clientHelper.BuildApiCall<CreateReleaseRequest, lro::Operation>("CreateRelease", grpcClient.CreateReleaseAsync, grpcClient.CreateRelease, effectiveSettings.CreateReleaseSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateRelease);
            Modify_CreateReleaseApiCall(ref _callCreateRelease);
            _callUpdateRelease = clientHelper.BuildApiCall<UpdateReleaseRequest, lro::Operation>("UpdateRelease", grpcClient.UpdateReleaseAsync, grpcClient.UpdateRelease, effectiveSettings.UpdateReleaseSettings).WithGoogleRequestParam("release.name", request => request.Release?.Name);
            Modify_ApiCall(ref _callUpdateRelease);
            Modify_UpdateReleaseApiCall(ref _callUpdateRelease);
            _callDeleteRelease = clientHelper.BuildApiCall<DeleteReleaseRequest, lro::Operation>("DeleteRelease", grpcClient.DeleteReleaseAsync, grpcClient.DeleteRelease, effectiveSettings.DeleteReleaseSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteRelease);
            Modify_DeleteReleaseApiCall(ref _callDeleteRelease);
            _callListVariants = clientHelper.BuildApiCall<ListVariantsRequest, ListVariantsResponse>("ListVariants", grpcClient.ListVariantsAsync, grpcClient.ListVariants, effectiveSettings.ListVariantsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListVariants);
            Modify_ListVariantsApiCall(ref _callListVariants);
            _callGetVariant = clientHelper.BuildApiCall<GetVariantRequest, Variant>("GetVariant", grpcClient.GetVariantAsync, grpcClient.GetVariant, effectiveSettings.GetVariantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetVariant);
            Modify_GetVariantApiCall(ref _callGetVariant);
            _callCreateVariant = clientHelper.BuildApiCall<CreateVariantRequest, lro::Operation>("CreateVariant", grpcClient.CreateVariantAsync, grpcClient.CreateVariant, effectiveSettings.CreateVariantSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateVariant);
            Modify_CreateVariantApiCall(ref _callCreateVariant);
            _callUpdateVariant = clientHelper.BuildApiCall<UpdateVariantRequest, lro::Operation>("UpdateVariant", grpcClient.UpdateVariantAsync, grpcClient.UpdateVariant, effectiveSettings.UpdateVariantSettings).WithGoogleRequestParam("variant.name", request => request.Variant?.Name);
            Modify_ApiCall(ref _callUpdateVariant);
            Modify_UpdateVariantApiCall(ref _callUpdateVariant);
            _callDeleteVariant = clientHelper.BuildApiCall<DeleteVariantRequest, lro::Operation>("DeleteVariant", grpcClient.DeleteVariantAsync, grpcClient.DeleteVariant, effectiveSettings.DeleteVariantSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteVariant);
            Modify_DeleteVariantApiCall(ref _callDeleteVariant);
            _callListRollouts = clientHelper.BuildApiCall<ListRolloutsRequest, ListRolloutsResponse>("ListRollouts", grpcClient.ListRolloutsAsync, grpcClient.ListRollouts, effectiveSettings.ListRolloutsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRollouts);
            Modify_ListRolloutsApiCall(ref _callListRollouts);
            _callGetRollout = clientHelper.BuildApiCall<GetRolloutRequest, Rollout>("GetRollout", grpcClient.GetRolloutAsync, grpcClient.GetRollout, effectiveSettings.GetRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRollout);
            Modify_GetRolloutApiCall(ref _callGetRollout);
            _callSuspendRollout = clientHelper.BuildApiCall<SuspendRolloutRequest, lro::Operation>("SuspendRollout", grpcClient.SuspendRolloutAsync, grpcClient.SuspendRollout, effectiveSettings.SuspendRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callSuspendRollout);
            Modify_SuspendRolloutApiCall(ref _callSuspendRollout);
            _callResumeRollout = clientHelper.BuildApiCall<ResumeRolloutRequest, lro::Operation>("ResumeRollout", grpcClient.ResumeRolloutAsync, grpcClient.ResumeRollout, effectiveSettings.ResumeRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callResumeRollout);
            Modify_ResumeRolloutApiCall(ref _callResumeRollout);
            _callAbortRollout = clientHelper.BuildApiCall<AbortRolloutRequest, lro::Operation>("AbortRollout", grpcClient.AbortRolloutAsync, grpcClient.AbortRollout, effectiveSettings.AbortRolloutSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callAbortRollout);
            Modify_AbortRolloutApiCall(ref _callAbortRollout);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListResourceBundlesApiCall(ref gaxgrpc::ApiCall<ListResourceBundlesRequest, ListResourceBundlesResponse> call);

        partial void Modify_GetResourceBundleApiCall(ref gaxgrpc::ApiCall<GetResourceBundleRequest, ResourceBundle> call);

        partial void Modify_CreateResourceBundleApiCall(ref gaxgrpc::ApiCall<CreateResourceBundleRequest, lro::Operation> call);

        partial void Modify_UpdateResourceBundleApiCall(ref gaxgrpc::ApiCall<UpdateResourceBundleRequest, lro::Operation> call);

        partial void Modify_DeleteResourceBundleApiCall(ref gaxgrpc::ApiCall<DeleteResourceBundleRequest, lro::Operation> call);

        partial void Modify_ListFleetPackagesApiCall(ref gaxgrpc::ApiCall<ListFleetPackagesRequest, ListFleetPackagesResponse> call);

        partial void Modify_GetFleetPackageApiCall(ref gaxgrpc::ApiCall<GetFleetPackageRequest, FleetPackage> call);

        partial void Modify_CreateFleetPackageApiCall(ref gaxgrpc::ApiCall<CreateFleetPackageRequest, lro::Operation> call);

        partial void Modify_UpdateFleetPackageApiCall(ref gaxgrpc::ApiCall<UpdateFleetPackageRequest, lro::Operation> call);

        partial void Modify_DeleteFleetPackageApiCall(ref gaxgrpc::ApiCall<DeleteFleetPackageRequest, lro::Operation> call);

        partial void Modify_ListReleasesApiCall(ref gaxgrpc::ApiCall<ListReleasesRequest, ListReleasesResponse> call);

        partial void Modify_GetReleaseApiCall(ref gaxgrpc::ApiCall<GetReleaseRequest, Release> call);

        partial void Modify_CreateReleaseApiCall(ref gaxgrpc::ApiCall<CreateReleaseRequest, lro::Operation> call);

        partial void Modify_UpdateReleaseApiCall(ref gaxgrpc::ApiCall<UpdateReleaseRequest, lro::Operation> call);

        partial void Modify_DeleteReleaseApiCall(ref gaxgrpc::ApiCall<DeleteReleaseRequest, lro::Operation> call);

        partial void Modify_ListVariantsApiCall(ref gaxgrpc::ApiCall<ListVariantsRequest, ListVariantsResponse> call);

        partial void Modify_GetVariantApiCall(ref gaxgrpc::ApiCall<GetVariantRequest, Variant> call);

        partial void Modify_CreateVariantApiCall(ref gaxgrpc::ApiCall<CreateVariantRequest, lro::Operation> call);

        partial void Modify_UpdateVariantApiCall(ref gaxgrpc::ApiCall<UpdateVariantRequest, lro::Operation> call);

        partial void Modify_DeleteVariantApiCall(ref gaxgrpc::ApiCall<DeleteVariantRequest, lro::Operation> call);

        partial void Modify_ListRolloutsApiCall(ref gaxgrpc::ApiCall<ListRolloutsRequest, ListRolloutsResponse> call);

        partial void Modify_GetRolloutApiCall(ref gaxgrpc::ApiCall<GetRolloutRequest, Rollout> call);

        partial void Modify_SuspendRolloutApiCall(ref gaxgrpc::ApiCall<SuspendRolloutRequest, lro::Operation> call);

        partial void Modify_ResumeRolloutApiCall(ref gaxgrpc::ApiCall<ResumeRolloutRequest, lro::Operation> call);

        partial void Modify_AbortRolloutApiCall(ref gaxgrpc::ApiCall<AbortRolloutRequest, lro::Operation> call);

        partial void OnConstruction(ConfigDelivery.ConfigDeliveryClient grpcClient, ConfigDeliverySettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConfigDelivery client</summary>
        public override ConfigDelivery.ConfigDeliveryClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListResourceBundlesRequest(ref ListResourceBundlesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetResourceBundleRequest(ref GetResourceBundleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateResourceBundleRequest(ref CreateResourceBundleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateResourceBundleRequest(ref UpdateResourceBundleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteResourceBundleRequest(ref DeleteResourceBundleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListFleetPackagesRequest(ref ListFleetPackagesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetFleetPackageRequest(ref GetFleetPackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateFleetPackageRequest(ref CreateFleetPackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateFleetPackageRequest(ref UpdateFleetPackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteFleetPackageRequest(ref DeleteFleetPackageRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReleasesRequest(ref ListReleasesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReleaseRequest(ref GetReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateReleaseRequest(ref CreateReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateReleaseRequest(ref UpdateReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteReleaseRequest(ref DeleteReleaseRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListVariantsRequest(ref ListVariantsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetVariantRequest(ref GetVariantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateVariantRequest(ref CreateVariantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateVariantRequest(ref UpdateVariantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteVariantRequest(ref DeleteVariantRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRolloutsRequest(ref ListRolloutsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRolloutRequest(ref GetRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuspendRolloutRequest(ref SuspendRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ResumeRolloutRequest(ref ResumeRolloutRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AbortRolloutRequest(ref AbortRolloutRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists ResourceBundles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ResourceBundle"/> resources.</returns>
        public override gax::PagedEnumerable<ListResourceBundlesResponse, ResourceBundle> ListResourceBundles(ListResourceBundlesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceBundlesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListResourceBundlesRequest, ListResourceBundlesResponse, ResourceBundle>(_callListResourceBundles, request, callSettings);
        }

        /// <summary>
        /// Lists ResourceBundles in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ResourceBundle"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListResourceBundlesResponse, ResourceBundle> ListResourceBundlesAsync(ListResourceBundlesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourceBundlesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListResourceBundlesRequest, ListResourceBundlesResponse, ResourceBundle>(_callListResourceBundles, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ResourceBundle GetResourceBundle(GetResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceBundleRequest(ref request, ref callSettings);
            return _callGetResourceBundle.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ResourceBundle> GetResourceBundleAsync(GetResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceBundleRequest(ref request, ref callSettings);
            return _callGetResourceBundle.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateResourceBundle</c>.</summary>
        public override lro::OperationsClient CreateResourceBundleOperationsClient { get; }

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ResourceBundle, OperationMetadata> CreateResourceBundle(CreateResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateResourceBundleRequest(ref request, ref callSettings);
            return new lro::Operation<ResourceBundle, OperationMetadata>(_callCreateResourceBundle.Sync(request, callSettings), CreateResourceBundleOperationsClient);
        }

        /// <summary>
        /// Creates a new ResourceBundle in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> CreateResourceBundleAsync(CreateResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateResourceBundleRequest(ref request, ref callSettings);
            return new lro::Operation<ResourceBundle, OperationMetadata>(await _callCreateResourceBundle.Async(request, callSettings).ConfigureAwait(false), CreateResourceBundleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateResourceBundle</c>.</summary>
        public override lro::OperationsClient UpdateResourceBundleOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<ResourceBundle, OperationMetadata> UpdateResourceBundle(UpdateResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateResourceBundleRequest(ref request, ref callSettings);
            return new lro::Operation<ResourceBundle, OperationMetadata>(_callUpdateResourceBundle.Sync(request, callSettings), UpdateResourceBundleOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<ResourceBundle, OperationMetadata>> UpdateResourceBundleAsync(UpdateResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateResourceBundleRequest(ref request, ref callSettings);
            return new lro::Operation<ResourceBundle, OperationMetadata>(await _callUpdateResourceBundle.Async(request, callSettings).ConfigureAwait(false), UpdateResourceBundleOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteResourceBundle</c>.</summary>
        public override lro::OperationsClient DeleteResourceBundleOperationsClient { get; }

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteResourceBundle(DeleteResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteResourceBundleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteResourceBundle.Sync(request, callSettings), DeleteResourceBundleOperationsClient);
        }

        /// <summary>
        /// Deletes a single ResourceBundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteResourceBundleAsync(DeleteResourceBundleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteResourceBundleRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteResourceBundle.Async(request, callSettings).ConfigureAwait(false), DeleteResourceBundleOperationsClient);
        }

        /// <summary>
        /// Lists FleetPackages in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="FleetPackage"/> resources.</returns>
        public override gax::PagedEnumerable<ListFleetPackagesResponse, FleetPackage> ListFleetPackages(ListFleetPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFleetPackagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListFleetPackagesRequest, ListFleetPackagesResponse, FleetPackage>(_callListFleetPackages, request, callSettings);
        }

        /// <summary>
        /// Lists FleetPackages in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="FleetPackage"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListFleetPackagesResponse, FleetPackage> ListFleetPackagesAsync(ListFleetPackagesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListFleetPackagesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListFleetPackagesRequest, ListFleetPackagesResponse, FleetPackage>(_callListFleetPackages, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FleetPackage GetFleetPackage(GetFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFleetPackageRequest(ref request, ref callSettings);
            return _callGetFleetPackage.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FleetPackage> GetFleetPackageAsync(GetFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFleetPackageRequest(ref request, ref callSettings);
            return _callGetFleetPackage.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateFleetPackage</c>.</summary>
        public override lro::OperationsClient CreateFleetPackageOperationsClient { get; }

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FleetPackage, OperationMetadata> CreateFleetPackage(CreateFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFleetPackageRequest(ref request, ref callSettings);
            return new lro::Operation<FleetPackage, OperationMetadata>(_callCreateFleetPackage.Sync(request, callSettings), CreateFleetPackageOperationsClient);
        }

        /// <summary>
        /// Creates a new FleetPackage in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FleetPackage, OperationMetadata>> CreateFleetPackageAsync(CreateFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateFleetPackageRequest(ref request, ref callSettings);
            return new lro::Operation<FleetPackage, OperationMetadata>(await _callCreateFleetPackage.Async(request, callSettings).ConfigureAwait(false), CreateFleetPackageOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateFleetPackage</c>.</summary>
        public override lro::OperationsClient UpdateFleetPackageOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<FleetPackage, OperationMetadata> UpdateFleetPackage(UpdateFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFleetPackageRequest(ref request, ref callSettings);
            return new lro::Operation<FleetPackage, OperationMetadata>(_callUpdateFleetPackage.Sync(request, callSettings), UpdateFleetPackageOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<FleetPackage, OperationMetadata>> UpdateFleetPackageAsync(UpdateFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateFleetPackageRequest(ref request, ref callSettings);
            return new lro::Operation<FleetPackage, OperationMetadata>(await _callUpdateFleetPackage.Async(request, callSettings).ConfigureAwait(false), UpdateFleetPackageOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteFleetPackage</c>.</summary>
        public override lro::OperationsClient DeleteFleetPackageOperationsClient { get; }

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteFleetPackage(DeleteFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFleetPackageRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteFleetPackage.Sync(request, callSettings), DeleteFleetPackageOperationsClient);
        }

        /// <summary>
        /// Deletes a single FleetPackage.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteFleetPackageAsync(DeleteFleetPackageRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteFleetPackageRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteFleetPackage.Async(request, callSettings).ConfigureAwait(false), DeleteFleetPackageOperationsClient);
        }

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Release"/> resources.</returns>
        public override gax::PagedEnumerable<ListReleasesResponse, Release> ListReleases(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReleasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReleasesRequest, ListReleasesResponse, Release>(_callListReleases, request, callSettings);
        }

        /// <summary>
        /// Lists Releases in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Release"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReleasesResponse, Release> ListReleasesAsync(ListReleasesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReleasesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReleasesRequest, ListReleasesResponse, Release>(_callListReleases, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Release GetRelease(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReleaseRequest(ref request, ref callSettings);
            return _callGetRelease.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Release> GetReleaseAsync(GetReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReleaseRequest(ref request, ref callSettings);
            return _callGetRelease.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateRelease</c>.</summary>
        public override lro::OperationsClient CreateReleaseOperationsClient { get; }

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Release, OperationMetadata> CreateRelease(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReleaseRequest(ref request, ref callSettings);
            return new lro::Operation<Release, OperationMetadata>(_callCreateRelease.Sync(request, callSettings), CreateReleaseOperationsClient);
        }

        /// <summary>
        /// Creates a new Release in a given project, location and resource bundle.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Release, OperationMetadata>> CreateReleaseAsync(CreateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateReleaseRequest(ref request, ref callSettings);
            return new lro::Operation<Release, OperationMetadata>(await _callCreateRelease.Async(request, callSettings).ConfigureAwait(false), CreateReleaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateRelease</c>.</summary>
        public override lro::OperationsClient UpdateReleaseOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Release, OperationMetadata> UpdateRelease(UpdateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReleaseRequest(ref request, ref callSettings);
            return new lro::Operation<Release, OperationMetadata>(_callUpdateRelease.Sync(request, callSettings), UpdateReleaseOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Release, OperationMetadata>> UpdateReleaseAsync(UpdateReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateReleaseRequest(ref request, ref callSettings);
            return new lro::Operation<Release, OperationMetadata>(await _callUpdateRelease.Async(request, callSettings).ConfigureAwait(false), UpdateReleaseOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteRelease</c>.</summary>
        public override lro::OperationsClient DeleteReleaseOperationsClient { get; }

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteRelease(DeleteReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReleaseRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteRelease.Sync(request, callSettings), DeleteReleaseOperationsClient);
        }

        /// <summary>
        /// Deletes a single Release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteReleaseAsync(DeleteReleaseRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteReleaseRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteRelease.Async(request, callSettings).ConfigureAwait(false), DeleteReleaseOperationsClient);
        }

        /// <summary>
        /// Lists Variants in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Variant"/> resources.</returns>
        public override gax::PagedEnumerable<ListVariantsResponse, Variant> ListVariants(ListVariantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVariantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListVariantsRequest, ListVariantsResponse, Variant>(_callListVariants, request, callSettings);
        }

        /// <summary>
        /// Lists Variants in a given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Variant"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListVariantsResponse, Variant> ListVariantsAsync(ListVariantsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListVariantsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListVariantsRequest, ListVariantsResponse, Variant>(_callListVariants, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Variant GetVariant(GetVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVariantRequest(ref request, ref callSettings);
            return _callGetVariant.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Variant> GetVariantAsync(GetVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetVariantRequest(ref request, ref callSettings);
            return _callGetVariant.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateVariant</c>.</summary>
        public override lro::OperationsClient CreateVariantOperationsClient { get; }

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Variant, OperationMetadata> CreateVariant(CreateVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVariantRequest(ref request, ref callSettings);
            return new lro::Operation<Variant, OperationMetadata>(_callCreateVariant.Sync(request, callSettings), CreateVariantOperationsClient);
        }

        /// <summary>
        /// Creates a new Variant in a given project, location, resource bundle, and
        /// release.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Variant, OperationMetadata>> CreateVariantAsync(CreateVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateVariantRequest(ref request, ref callSettings);
            return new lro::Operation<Variant, OperationMetadata>(await _callCreateVariant.Async(request, callSettings).ConfigureAwait(false), CreateVariantOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateVariant</c>.</summary>
        public override lro::OperationsClient UpdateVariantOperationsClient { get; }

        /// <summary>
        /// Updates the parameters of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Variant, OperationMetadata> UpdateVariant(UpdateVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVariantRequest(ref request, ref callSettings);
            return new lro::Operation<Variant, OperationMetadata>(_callUpdateVariant.Sync(request, callSettings), UpdateVariantOperationsClient);
        }

        /// <summary>
        /// Updates the parameters of a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Variant, OperationMetadata>> UpdateVariantAsync(UpdateVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateVariantRequest(ref request, ref callSettings);
            return new lro::Operation<Variant, OperationMetadata>(await _callUpdateVariant.Async(request, callSettings).ConfigureAwait(false), UpdateVariantOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteVariant</c>.</summary>
        public override lro::OperationsClient DeleteVariantOperationsClient { get; }

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteVariant(DeleteVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVariantRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteVariant.Sync(request, callSettings), DeleteVariantOperationsClient);
        }

        /// <summary>
        /// Deletes a single Variant.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteVariantAsync(DeleteVariantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteVariantRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteVariant.Async(request, callSettings).ConfigureAwait(false), DeleteVariantOperationsClient);
        }

        /// <summary>
        /// Lists Rollouts in a given project, location, and Fleet Package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Rollout"/> resources.</returns>
        public override gax::PagedEnumerable<ListRolloutsResponse, Rollout> ListRollouts(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRolloutsRequest, ListRolloutsResponse, Rollout>(_callListRollouts, request, callSettings);
        }

        /// <summary>
        /// Lists Rollouts in a given project, location, and Fleet Package.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Rollout"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRolloutsResponse, Rollout> ListRolloutsAsync(ListRolloutsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRolloutsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRolloutsRequest, ListRolloutsResponse, Rollout>(_callListRollouts, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Rollout GetRollout(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutRequest(ref request, ref callSettings);
            return _callGetRollout.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Rollout> GetRolloutAsync(GetRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRolloutRequest(ref request, ref callSettings);
            return _callGetRollout.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>SuspendRollout</c>.</summary>
        public override lro::OperationsClient SuspendRolloutOperationsClient { get; }

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Rollout, OperationMetadata> SuspendRollout(SuspendRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuspendRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(_callSuspendRollout.Sync(request, callSettings), SuspendRolloutOperationsClient);
        }

        /// <summary>
        /// Suspend a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Rollout, OperationMetadata>> SuspendRolloutAsync(SuspendRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuspendRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(await _callSuspendRollout.Async(request, callSettings).ConfigureAwait(false), SuspendRolloutOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ResumeRollout</c>.</summary>
        public override lro::OperationsClient ResumeRolloutOperationsClient { get; }

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Rollout, OperationMetadata> ResumeRollout(ResumeRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(_callResumeRollout.Sync(request, callSettings), ResumeRolloutOperationsClient);
        }

        /// <summary>
        /// Resume a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Rollout, OperationMetadata>> ResumeRolloutAsync(ResumeRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ResumeRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(await _callResumeRollout.Async(request, callSettings).ConfigureAwait(false), ResumeRolloutOperationsClient);
        }

        /// <summary>The long-running operations client for <c>AbortRollout</c>.</summary>
        public override lro::OperationsClient AbortRolloutOperationsClient { get; }

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Rollout, OperationMetadata> AbortRollout(AbortRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AbortRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(_callAbortRollout.Sync(request, callSettings), AbortRolloutOperationsClient);
        }

        /// <summary>
        /// Abort a Rollout.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Rollout, OperationMetadata>> AbortRolloutAsync(AbortRolloutRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AbortRolloutRequest(ref request, ref callSettings);
            return new lro::Operation<Rollout, OperationMetadata>(await _callAbortRollout.Async(request, callSettings).ConfigureAwait(false), AbortRolloutOperationsClient);
        }
    }

    public partial class ListResourceBundlesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListFleetPackagesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReleasesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListVariantsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRolloutsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListResourceBundlesResponse : gaxgrpc::IPageResponse<ResourceBundle>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ResourceBundle> GetEnumerator() => ResourceBundles.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListFleetPackagesResponse : gaxgrpc::IPageResponse<FleetPackage>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<FleetPackage> GetEnumerator() => FleetPackages.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReleasesResponse : gaxgrpc::IPageResponse<Release>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Release> GetEnumerator() => Releases.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListVariantsResponse : gaxgrpc::IPageResponse<Variant>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Variant> GetEnumerator() => Variants.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRolloutsResponse : gaxgrpc::IPageResponse<Rollout>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Rollout> GetEnumerator() => Rollouts.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ConfigDelivery
    {
        public partial class ConfigDeliveryClient
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

    public static partial class ConfigDelivery
    {
        public partial class ConfigDeliveryClient
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
