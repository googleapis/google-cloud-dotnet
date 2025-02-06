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
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Cloud.SecurityCenterManagement.V1
{
    /// <summary>Settings for <see cref="SecurityCenterManagementClient"/> instances.</summary>
    public sealed partial class SecurityCenterManagementSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SecurityCenterManagementSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SecurityCenterManagementSettings"/>.</returns>
        public static SecurityCenterManagementSettings GetDefault() => new SecurityCenterManagementSettings();

        /// <summary>
        /// Constructs a new <see cref="SecurityCenterManagementSettings"/> object with default settings.
        /// </summary>
        public SecurityCenterManagementSettings()
        {
        }

        private SecurityCenterManagementSettings(SecurityCenterManagementSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListEffectiveSecurityHealthAnalyticsCustomModulesSettings = existing.ListEffectiveSecurityHealthAnalyticsCustomModulesSettings;
            GetEffectiveSecurityHealthAnalyticsCustomModuleSettings = existing.GetEffectiveSecurityHealthAnalyticsCustomModuleSettings;
            ListSecurityHealthAnalyticsCustomModulesSettings = existing.ListSecurityHealthAnalyticsCustomModulesSettings;
            ListDescendantSecurityHealthAnalyticsCustomModulesSettings = existing.ListDescendantSecurityHealthAnalyticsCustomModulesSettings;
            GetSecurityHealthAnalyticsCustomModuleSettings = existing.GetSecurityHealthAnalyticsCustomModuleSettings;
            CreateSecurityHealthAnalyticsCustomModuleSettings = existing.CreateSecurityHealthAnalyticsCustomModuleSettings;
            UpdateSecurityHealthAnalyticsCustomModuleSettings = existing.UpdateSecurityHealthAnalyticsCustomModuleSettings;
            DeleteSecurityHealthAnalyticsCustomModuleSettings = existing.DeleteSecurityHealthAnalyticsCustomModuleSettings;
            SimulateSecurityHealthAnalyticsCustomModuleSettings = existing.SimulateSecurityHealthAnalyticsCustomModuleSettings;
            ListEffectiveEventThreatDetectionCustomModulesSettings = existing.ListEffectiveEventThreatDetectionCustomModulesSettings;
            GetEffectiveEventThreatDetectionCustomModuleSettings = existing.GetEffectiveEventThreatDetectionCustomModuleSettings;
            ListEventThreatDetectionCustomModulesSettings = existing.ListEventThreatDetectionCustomModulesSettings;
            ListDescendantEventThreatDetectionCustomModulesSettings = existing.ListDescendantEventThreatDetectionCustomModulesSettings;
            GetEventThreatDetectionCustomModuleSettings = existing.GetEventThreatDetectionCustomModuleSettings;
            CreateEventThreatDetectionCustomModuleSettings = existing.CreateEventThreatDetectionCustomModuleSettings;
            UpdateEventThreatDetectionCustomModuleSettings = existing.UpdateEventThreatDetectionCustomModuleSettings;
            DeleteEventThreatDetectionCustomModuleSettings = existing.DeleteEventThreatDetectionCustomModuleSettings;
            ValidateEventThreatDetectionCustomModuleSettings = existing.ValidateEventThreatDetectionCustomModuleSettings;
            GetSecurityCenterServiceSettings = existing.GetSecurityCenterServiceSettings;
            ListSecurityCenterServicesSettings = existing.ListSecurityCenterServicesSettings;
            UpdateSecurityCenterServiceSettings = existing.UpdateSecurityCenterServiceSettings;
            LocationsSettings = existing.LocationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SecurityCenterManagementSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModules</c> and
        /// <c>SecurityCenterManagementClient.ListEffectiveSecurityHealthAnalyticsCustomModulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEffectiveSecurityHealthAnalyticsCustomModulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.GetEffectiveSecurityHealthAnalyticsCustomModule</c> and
        /// <c>SecurityCenterManagementClient.GetEffectiveSecurityHealthAnalyticsCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEffectiveSecurityHealthAnalyticsCustomModuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.ListSecurityHealthAnalyticsCustomModules</c> and
        /// <c>SecurityCenterManagementClient.ListSecurityHealthAnalyticsCustomModulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSecurityHealthAnalyticsCustomModulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModules</c> and
        /// <c>SecurityCenterManagementClient.ListDescendantSecurityHealthAnalyticsCustomModulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDescendantSecurityHealthAnalyticsCustomModulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.GetSecurityHealthAnalyticsCustomModule</c> and
        /// <c>SecurityCenterManagementClient.GetSecurityHealthAnalyticsCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSecurityHealthAnalyticsCustomModuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModule</c> and
        /// <c>SecurityCenterManagementClient.CreateSecurityHealthAnalyticsCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateSecurityHealthAnalyticsCustomModuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.UpdateSecurityHealthAnalyticsCustomModule</c> and
        /// <c>SecurityCenterManagementClient.UpdateSecurityHealthAnalyticsCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSecurityHealthAnalyticsCustomModuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModule</c> and
        /// <c>SecurityCenterManagementClient.DeleteSecurityHealthAnalyticsCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteSecurityHealthAnalyticsCustomModuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.SimulateSecurityHealthAnalyticsCustomModule</c> and
        /// <c>SecurityCenterManagementClient.SimulateSecurityHealthAnalyticsCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SimulateSecurityHealthAnalyticsCustomModuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModules</c> and
        /// <c>SecurityCenterManagementClient.ListEffectiveEventThreatDetectionCustomModulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEffectiveEventThreatDetectionCustomModulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.GetEffectiveEventThreatDetectionCustomModule</c> and
        /// <c>SecurityCenterManagementClient.GetEffectiveEventThreatDetectionCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEffectiveEventThreatDetectionCustomModuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.ListEventThreatDetectionCustomModules</c> and
        /// <c>SecurityCenterManagementClient.ListEventThreatDetectionCustomModulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListEventThreatDetectionCustomModulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.ListDescendantEventThreatDetectionCustomModules</c> and
        /// <c>SecurityCenterManagementClient.ListDescendantEventThreatDetectionCustomModulesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListDescendantEventThreatDetectionCustomModulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.GetEventThreatDetectionCustomModule</c> and
        /// <c>SecurityCenterManagementClient.GetEventThreatDetectionCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetEventThreatDetectionCustomModuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.CreateEventThreatDetectionCustomModule</c> and
        /// <c>SecurityCenterManagementClient.CreateEventThreatDetectionCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateEventThreatDetectionCustomModuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.UpdateEventThreatDetectionCustomModule</c> and
        /// <c>SecurityCenterManagementClient.UpdateEventThreatDetectionCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateEventThreatDetectionCustomModuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.DeleteEventThreatDetectionCustomModule</c> and
        /// <c>SecurityCenterManagementClient.DeleteEventThreatDetectionCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DeleteEventThreatDetectionCustomModuleSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.ValidateEventThreatDetectionCustomModule</c> and
        /// <c>SecurityCenterManagementClient.ValidateEventThreatDetectionCustomModuleAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: 5</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ValidateEventThreatDetectionCustomModuleSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.GetSecurityCenterService</c> and
        /// <c>SecurityCenterManagementClient.GetSecurityCenterServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSecurityCenterServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.ListSecurityCenterServices</c> and
        /// <c>SecurityCenterManagementClient.ListSecurityCenterServicesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListSecurityCenterServicesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SecurityCenterManagementClient.UpdateSecurityCenterService</c> and
        /// <c>SecurityCenterManagementClient.UpdateSecurityCenterServiceAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateSecurityCenterServiceSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SecurityCenterManagementSettings"/> object.</returns>
        public SecurityCenterManagementSettings Clone() => new SecurityCenterManagementSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SecurityCenterManagementClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SecurityCenterManagementClientBuilder : gaxgrpc::ClientBuilderBase<SecurityCenterManagementClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SecurityCenterManagementSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SecurityCenterManagementClientBuilder() : base(SecurityCenterManagementClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SecurityCenterManagementClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SecurityCenterManagementClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SecurityCenterManagementClient Build()
        {
            SecurityCenterManagementClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SecurityCenterManagementClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SecurityCenterManagementClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SecurityCenterManagementClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SecurityCenterManagementClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SecurityCenterManagementClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SecurityCenterManagementClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SecurityCenterManagementClient.ChannelPool;
    }

    /// <summary>SecurityCenterManagement client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public abstract partial class SecurityCenterManagementClient
    {
        /// <summary>
        /// The default endpoint for the SecurityCenterManagement service, which is a host of
        /// "securitycentermanagement.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "securitycentermanagement.googleapis.com:443";

        /// <summary>The default SecurityCenterManagement scopes.</summary>
        /// <remarks>
        /// The default SecurityCenterManagement scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SecurityCenterManagement.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SecurityCenterManagementClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SecurityCenterManagementClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SecurityCenterManagementClient"/>.</returns>
        public static stt::Task<SecurityCenterManagementClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SecurityCenterManagementClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SecurityCenterManagementClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SecurityCenterManagementClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SecurityCenterManagementClient"/>.</returns>
        public static SecurityCenterManagementClient Create() => new SecurityCenterManagementClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SecurityCenterManagementClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SecurityCenterManagementSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SecurityCenterManagementClient"/>.</returns>
        internal static SecurityCenterManagementClient Create(grpccore::CallInvoker callInvoker, SecurityCenterManagementSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SecurityCenterManagement.SecurityCenterManagementClient grpcClient = new SecurityCenterManagement.SecurityCenterManagementClient(callInvoker);
            return new SecurityCenterManagementClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SecurityCenterManagement client</summary>
        public virtual SecurityCenterManagement.SecurityCenterManagementClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModules(ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
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
            return ListEffectiveSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
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
            return ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModules(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEffectiveSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModules(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
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
            return ListEffectiveSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
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
            return ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModules(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEffectiveSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request = new ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EffectiveSecurityHealthAnalyticsCustomModule GetEffectiveSecurityHealthAnalyticsCustomModule(GetEffectiveSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveSecurityHealthAnalyticsCustomModule> GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(GetEffectiveSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveSecurityHealthAnalyticsCustomModule> GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(GetEffectiveSecurityHealthAnalyticsCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the custom module, specified in one of
        /// the following formats:
        /// 
        /// * `organizations/organization/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/folder/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/project/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EffectiveSecurityHealthAnalyticsCustomModule GetEffectiveSecurityHealthAnalyticsCustomModule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveSecurityHealthAnalyticsCustomModule(new GetEffectiveSecurityHealthAnalyticsCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the custom module, specified in one of
        /// the following formats:
        /// 
        /// * `organizations/organization/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/folder/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/project/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveSecurityHealthAnalyticsCustomModule> GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(new GetEffectiveSecurityHealthAnalyticsCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the custom module, specified in one of
        /// the following formats:
        /// 
        /// * `organizations/organization/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/folder/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/project/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveSecurityHealthAnalyticsCustomModule> GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the custom module, specified in one of
        /// the following formats:
        /// 
        /// * `organizations/organization/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/folder/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/project/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EffectiveSecurityHealthAnalyticsCustomModule GetEffectiveSecurityHealthAnalyticsCustomModule(EffectiveSecurityHealthAnalyticsCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveSecurityHealthAnalyticsCustomModule(new GetEffectiveSecurityHealthAnalyticsCustomModuleRequest
            {
                EffectiveSecurityHealthAnalyticsCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the custom module, specified in one of
        /// the following formats:
        /// 
        /// * `organizations/organization/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/folder/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/project/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveSecurityHealthAnalyticsCustomModule> GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(EffectiveSecurityHealthAnalyticsCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(new GetEffectiveSecurityHealthAnalyticsCustomModuleRequest
            {
                EffectiveSecurityHealthAnalyticsCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. The full resource name of the custom module, specified in one of
        /// the following formats:
        /// 
        /// * `organizations/organization/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/folder/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/project/{location}/effectiveSecurityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveSecurityHealthAnalyticsCustomModule> GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(EffectiveSecurityHealthAnalyticsCustomModuleName name, st::CancellationToken cancellationToken) =>
            GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModules(ListSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModulesAsync(ListSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
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
            return ListSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
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
            return ListSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModules(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModulesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModules(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
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
            return ListSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModulesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
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
            return ListSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModules(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModulesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityHealthAnalyticsCustomModulesRequest request = new ListSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModules(ListDescendantSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModulesAsync(ListDescendantSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
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
            return ListDescendantSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
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
            return ListDescendantSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModules(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDescendantSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModulesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDescendantSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModules(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
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
            return ListDescendantSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModulesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
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
            return ListDescendantSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModules(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDescendantSecurityHealthAnalyticsCustomModules(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project in which to
        /// list custom modules, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModulesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantSecurityHealthAnalyticsCustomModulesRequest request = new ListDescendantSecurityHealthAnalyticsCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDescendantSecurityHealthAnalyticsCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule GetSecurityHealthAnalyticsCustomModule(GetSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> GetSecurityHealthAnalyticsCustomModuleAsync(GetSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> GetSecurityHealthAnalyticsCustomModuleAsync(GetSecurityHealthAnalyticsCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            GetSecurityHealthAnalyticsCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule GetSecurityHealthAnalyticsCustomModule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityHealthAnalyticsCustomModule(new GetSecurityHealthAnalyticsCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> GetSecurityHealthAnalyticsCustomModuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityHealthAnalyticsCustomModuleAsync(new GetSecurityHealthAnalyticsCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> GetSecurityHealthAnalyticsCustomModuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetSecurityHealthAnalyticsCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule GetSecurityHealthAnalyticsCustomModule(SecurityHealthAnalyticsCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityHealthAnalyticsCustomModule(new GetSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> GetSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityHealthAnalyticsCustomModuleAsync(new GetSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="name">
        /// Required. Name of the resource, in the format
        /// `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> GetSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModuleName name, st::CancellationToken cancellationToken) =>
            GetSecurityHealthAnalyticsCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule CreateSecurityHealthAnalyticsCustomModule(CreateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(CreateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(CreateSecurityHealthAnalyticsCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule CreateSecurityHealthAnalyticsCustomModule(string parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityHealthAnalyticsCustomModule(new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(string parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(string parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, st::CancellationToken cancellationToken) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(parent, securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule CreateSecurityHealthAnalyticsCustomModule(OrganizationLocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityHealthAnalyticsCustomModule(new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(OrganizationLocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(OrganizationLocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, st::CancellationToken cancellationToken) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(parent, securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule CreateSecurityHealthAnalyticsCustomModule(gagr::LocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityHealthAnalyticsCustomModule(new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(gagr::LocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(gagr::LocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, st::CancellationToken cancellationToken) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(parent, securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule CreateSecurityHealthAnalyticsCustomModule(FolderLocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityHealthAnalyticsCustomModule(new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(FolderLocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(new CreateSecurityHealthAnalyticsCustomModuleRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of the parent organization, folder, or project of the
        /// module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(FolderLocationName parent, SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, st::CancellationToken cancellationToken) =>
            CreateSecurityHealthAnalyticsCustomModuleAsync(parent, securityHealthAnalyticsCustomModule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// under the given name based on the given update mask. Updating the
        /// enablement state is supported on both resident and inherited modules
        /// (though resident modules cannot have an enablement state of "inherited").
        /// Updating the display name and custom configuration of a module is supported
        /// on resident modules only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule UpdateSecurityHealthAnalyticsCustomModule(UpdateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// under the given name based on the given update mask. Updating the
        /// enablement state is supported on both resident and inherited modules
        /// (though resident modules cannot have an enablement state of "inherited").
        /// Updating the display name and custom configuration of a module is supported
        /// on resident modules only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> UpdateSecurityHealthAnalyticsCustomModuleAsync(UpdateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// under the given name based on the given update mask. Updating the
        /// enablement state is supported on both resident and inherited modules
        /// (though resident modules cannot have an enablement state of "inherited").
        /// Updating the display name and custom configuration of a module is supported
        /// on resident modules only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> UpdateSecurityHealthAnalyticsCustomModuleAsync(UpdateSecurityHealthAnalyticsCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateSecurityHealthAnalyticsCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// under the given name based on the given update mask. Updating the
        /// enablement state is supported on both resident and inherited modules
        /// (though resident modules cannot have an enablement state of "inherited").
        /// Updating the display name and custom configuration of a module is supported
        /// on resident modules only.
        /// </summary>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. The following values are valid:
        /// 
        /// * `custom_config`
        /// * `enablement_state`
        /// 
        /// If you omit this field or set it to the wildcard value `*`, then all
        /// eligible fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityHealthAnalyticsCustomModule UpdateSecurityHealthAnalyticsCustomModule(SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityHealthAnalyticsCustomModule(new UpdateSecurityHealthAnalyticsCustomModuleRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Updates the
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// under the given name based on the given update mask. Updating the
        /// enablement state is supported on both resident and inherited modules
        /// (though resident modules cannot have an enablement state of "inherited").
        /// Updating the display name and custom configuration of a module is supported
        /// on resident modules only.
        /// </summary>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. The following values are valid:
        /// 
        /// * `custom_config`
        /// * `enablement_state`
        /// 
        /// If you omit this field or set it to the wildcard value `*`, then all
        /// eligible fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> UpdateSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityHealthAnalyticsCustomModuleAsync(new UpdateSecurityHealthAnalyticsCustomModuleRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                SecurityHealthAnalyticsCustomModule = gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModule, nameof(securityHealthAnalyticsCustomModule)),
            }, callSettings);

        /// <summary>
        /// Updates the
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// under the given name based on the given update mask. Updating the
        /// enablement state is supported on both resident and inherited modules
        /// (though resident modules cannot have an enablement state of "inherited").
        /// Updating the display name and custom configuration of a module is supported
        /// on resident modules only.
        /// </summary>
        /// <param name="securityHealthAnalyticsCustomModule">
        /// Required. The resource being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. The following values are valid:
        /// 
        /// * `custom_config`
        /// * `enablement_state`
        /// 
        /// If you omit this field or set it to the wildcard value `*`, then all
        /// eligible fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityHealthAnalyticsCustomModule> UpdateSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModule securityHealthAnalyticsCustomModule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSecurityHealthAnalyticsCustomModuleAsync(securityHealthAnalyticsCustomModule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecurityHealthAnalyticsCustomModule(DeleteSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecurityHealthAnalyticsCustomModuleAsync(DeleteSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecurityHealthAnalyticsCustomModuleAsync(DeleteSecurityHealthAnalyticsCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteSecurityHealthAnalyticsCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SHA custom module, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecurityHealthAnalyticsCustomModule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityHealthAnalyticsCustomModule(new DeleteSecurityHealthAnalyticsCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SHA custom module, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecurityHealthAnalyticsCustomModuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityHealthAnalyticsCustomModuleAsync(new DeleteSecurityHealthAnalyticsCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SHA custom module, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecurityHealthAnalyticsCustomModuleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteSecurityHealthAnalyticsCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SHA custom module, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteSecurityHealthAnalyticsCustomModule(SecurityHealthAnalyticsCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityHealthAnalyticsCustomModule(new DeleteSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SHA custom module, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteSecurityHealthAnalyticsCustomModuleAsync(new DeleteSecurityHealthAnalyticsCustomModuleRequest
            {
                SecurityHealthAnalyticsCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the SHA custom module, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteSecurityHealthAnalyticsCustomModuleAsync(SecurityHealthAnalyticsCustomModuleName name, st::CancellationToken cancellationToken) =>
            DeleteSecurityHealthAnalyticsCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Simulates the result of using a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// to check a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SimulateSecurityHealthAnalyticsCustomModuleResponse SimulateSecurityHealthAnalyticsCustomModule(SimulateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Simulates the result of using a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// to check a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SimulateSecurityHealthAnalyticsCustomModuleResponse> SimulateSecurityHealthAnalyticsCustomModuleAsync(SimulateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Simulates the result of using a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// to check a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SimulateSecurityHealthAnalyticsCustomModuleResponse> SimulateSecurityHealthAnalyticsCustomModuleAsync(SimulateSecurityHealthAnalyticsCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            SimulateSecurityHealthAnalyticsCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Simulates the result of using a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// to check a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the organization, project, or
        /// folder. For more information about relative resource names, see [AIP-122:
        /// Resource names](https://google.aip.dev/122). Example:
        /// `organizations/{organization_id}`.
        /// </param>
        /// <param name="customConfig">
        /// Required. The custom configuration that you need to test.
        /// </param>
        /// <param name="resource">
        /// Required. Resource data to simulate custom module against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SimulateSecurityHealthAnalyticsCustomModuleResponse SimulateSecurityHealthAnalyticsCustomModule(string parent, CustomConfig customConfig, SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource resource, gaxgrpc::CallSettings callSettings = null) =>
            SimulateSecurityHealthAnalyticsCustomModule(new SimulateSecurityHealthAnalyticsCustomModuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomConfig = gax::GaxPreconditions.CheckNotNull(customConfig, nameof(customConfig)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Simulates the result of using a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// to check a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the organization, project, or
        /// folder. For more information about relative resource names, see [AIP-122:
        /// Resource names](https://google.aip.dev/122). Example:
        /// `organizations/{organization_id}`.
        /// </param>
        /// <param name="customConfig">
        /// Required. The custom configuration that you need to test.
        /// </param>
        /// <param name="resource">
        /// Required. Resource data to simulate custom module against.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SimulateSecurityHealthAnalyticsCustomModuleResponse> SimulateSecurityHealthAnalyticsCustomModuleAsync(string parent, CustomConfig customConfig, SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource resource, gaxgrpc::CallSettings callSettings = null) =>
            SimulateSecurityHealthAnalyticsCustomModuleAsync(new SimulateSecurityHealthAnalyticsCustomModuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CustomConfig = gax::GaxPreconditions.CheckNotNull(customConfig, nameof(customConfig)),
                Resource = gax::GaxPreconditions.CheckNotNull(resource, nameof(resource)),
            }, callSettings);

        /// <summary>
        /// Simulates the result of using a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// to check a resource.
        /// </summary>
        /// <param name="parent">
        /// Required. The relative resource name of the organization, project, or
        /// folder. For more information about relative resource names, see [AIP-122:
        /// Resource names](https://google.aip.dev/122). Example:
        /// `organizations/{organization_id}`.
        /// </param>
        /// <param name="customConfig">
        /// Required. The custom configuration that you need to test.
        /// </param>
        /// <param name="resource">
        /// Required. Resource data to simulate custom module against.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SimulateSecurityHealthAnalyticsCustomModuleResponse> SimulateSecurityHealthAnalyticsCustomModuleAsync(string parent, CustomConfig customConfig, SimulateSecurityHealthAnalyticsCustomModuleRequest.Types.SimulatedResource resource, st::CancellationToken cancellationToken) =>
            SimulateSecurityHealthAnalyticsCustomModuleAsync(parent, customConfig, resource, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModules(ListEffectiveEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModulesAsync(ListEffectiveEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
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
            return ListEffectiveEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
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
            return ListEffectiveEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModules(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEffectiveEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModulesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEffectiveEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModules(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
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
            return ListEffectiveEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModulesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
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
            return ListEffectiveEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModules(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEffectiveEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list effective custom modules, in one of the
        /// following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModulesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEffectiveEventThreatDetectionCustomModulesRequest request = new ListEffectiveEventThreatDetectionCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEffectiveEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EffectiveEventThreatDetectionCustomModule GetEffectiveEventThreatDetectionCustomModule(GetEffectiveEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveEventThreatDetectionCustomModule> GetEffectiveEventThreatDetectionCustomModuleAsync(GetEffectiveEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveEventThreatDetectionCustomModule> GetEffectiveEventThreatDetectionCustomModuleAsync(GetEffectiveEventThreatDetectionCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            GetEffectiveEventThreatDetectionCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EffectiveEventThreatDetectionCustomModule GetEffectiveEventThreatDetectionCustomModule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveEventThreatDetectionCustomModule(new GetEffectiveEventThreatDetectionCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveEventThreatDetectionCustomModule> GetEffectiveEventThreatDetectionCustomModuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveEventThreatDetectionCustomModuleAsync(new GetEffectiveEventThreatDetectionCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveEventThreatDetectionCustomModule> GetEffectiveEventThreatDetectionCustomModuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetEffectiveEventThreatDetectionCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EffectiveEventThreatDetectionCustomModule GetEffectiveEventThreatDetectionCustomModule(EffectiveEventThreatDetectionCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveEventThreatDetectionCustomModule(new GetEffectiveEventThreatDetectionCustomModuleRequest
            {
                EffectiveEventThreatDetectionCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveEventThreatDetectionCustomModule> GetEffectiveEventThreatDetectionCustomModuleAsync(EffectiveEventThreatDetectionCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEffectiveEventThreatDetectionCustomModuleAsync(new GetEffectiveEventThreatDetectionCustomModuleRequest
            {
                EffectiveEventThreatDetectionCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EffectiveEventThreatDetectionCustomModule> GetEffectiveEventThreatDetectionCustomModuleAsync(EffectiveEventThreatDetectionCustomModuleName name, st::CancellationToken cancellationToken) =>
            GetEffectiveEventThreatDetectionCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModules(ListEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModulesAsync(ListEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
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
            return ListEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
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
            return ListEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModules(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModulesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModules(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
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
            return ListEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModulesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
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
            return ListEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModules(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModulesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListEventThreatDetectionCustomModulesRequest request = new ListEventThreatDetectionCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModules(ListDescendantEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModulesAsync(ListDescendantEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModules(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
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
            return ListDescendantEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModulesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
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
            return ListDescendantEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModules(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDescendantEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModulesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDescendantEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModules(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
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
            return ListDescendantEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModulesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
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
            return ListDescendantEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModules(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDescendantEventThreatDetectionCustomModules(request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent to list custom modules, in one of the following
        /// formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public virtual gax::PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModulesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDescendantEventThreatDetectionCustomModulesRequest request = new ListDescendantEventThreatDetectionCustomModulesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListDescendantEventThreatDetectionCustomModulesAsync(request, callSettings);
        }

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule GetEventThreatDetectionCustomModule(GetEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> GetEventThreatDetectionCustomModuleAsync(GetEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> GetEventThreatDetectionCustomModuleAsync(GetEventThreatDetectionCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            GetEventThreatDetectionCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule GetEventThreatDetectionCustomModule(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEventThreatDetectionCustomModule(new GetEventThreatDetectionCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> GetEventThreatDetectionCustomModuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetEventThreatDetectionCustomModuleAsync(new GetEventThreatDetectionCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> GetEventThreatDetectionCustomModuleAsync(string name, st::CancellationToken cancellationToken) =>
            GetEventThreatDetectionCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule GetEventThreatDetectionCustomModule(EventThreatDetectionCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEventThreatDetectionCustomModule(new GetEventThreatDetectionCustomModuleRequest
            {
                EventThreatDetectionCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> GetEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            GetEventThreatDetectionCustomModuleAsync(new GetEventThreatDetectionCustomModuleRequest
            {
                EventThreatDetectionCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> GetEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModuleName name, st::CancellationToken cancellationToken) =>
            GetEventThreatDetectionCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule CreateEventThreatDetectionCustomModule(CreateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(CreateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(CreateEventThreatDetectionCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            CreateEventThreatDetectionCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule CreateEventThreatDetectionCustomModule(string parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventThreatDetectionCustomModule(new CreateEventThreatDetectionCustomModuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(string parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventThreatDetectionCustomModuleAsync(new CreateEventThreatDetectionCustomModuleRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(string parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, st::CancellationToken cancellationToken) =>
            CreateEventThreatDetectionCustomModuleAsync(parent, eventThreatDetectionCustomModule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule CreateEventThreatDetectionCustomModule(OrganizationLocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventThreatDetectionCustomModule(new CreateEventThreatDetectionCustomModuleRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(OrganizationLocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventThreatDetectionCustomModuleAsync(new CreateEventThreatDetectionCustomModuleRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(OrganizationLocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, st::CancellationToken cancellationToken) =>
            CreateEventThreatDetectionCustomModuleAsync(parent, eventThreatDetectionCustomModule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule CreateEventThreatDetectionCustomModule(gagr::LocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventThreatDetectionCustomModule(new CreateEventThreatDetectionCustomModuleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(gagr::LocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventThreatDetectionCustomModuleAsync(new CreateEventThreatDetectionCustomModuleRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(gagr::LocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, st::CancellationToken cancellationToken) =>
            CreateEventThreatDetectionCustomModuleAsync(parent, eventThreatDetectionCustomModule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule CreateEventThreatDetectionCustomModule(FolderLocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventThreatDetectionCustomModule(new CreateEventThreatDetectionCustomModuleRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(FolderLocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, gaxgrpc::CallSettings callSettings = null) =>
            CreateEventThreatDetectionCustomModuleAsync(new CreateEventThreatDetectionCustomModuleRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="parent">
        /// Required. Name of parent for the module, in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
        /// </param>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module to create. The
        /// [EventThreatDetectionCustomModule.name][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule.name]
        /// field is ignored; Security Command Center generates the name.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(FolderLocationName parent, EventThreatDetectionCustomModule eventThreatDetectionCustomModule, st::CancellationToken cancellationToken) =>
            CreateEventThreatDetectionCustomModuleAsync(parent, eventThreatDetectionCustomModule, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Event Threat Detection custom module with the given name based
        /// on the given update mask. Updating the enablement state is supported for
        /// both resident and inherited modules (though resident modules cannot have an
        /// enablement state of "inherited"). Updating the display name or
        /// configuration of a module is supported for resident modules only. The type
        /// of a module cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule UpdateEventThreatDetectionCustomModule(UpdateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Event Threat Detection custom module with the given name based
        /// on the given update mask. Updating the enablement state is supported for
        /// both resident and inherited modules (though resident modules cannot have an
        /// enablement state of "inherited"). Updating the display name or
        /// configuration of a module is supported for resident modules only. The type
        /// of a module cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> UpdateEventThreatDetectionCustomModuleAsync(UpdateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates the Event Threat Detection custom module with the given name based
        /// on the given update mask. Updating the enablement state is supported for
        /// both resident and inherited modules (though resident modules cannot have an
        /// enablement state of "inherited"). Updating the display name or
        /// configuration of a module is supported for resident modules only. The type
        /// of a module cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> UpdateEventThreatDetectionCustomModuleAsync(UpdateEventThreatDetectionCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            UpdateEventThreatDetectionCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates the Event Threat Detection custom module with the given name based
        /// on the given update mask. Updating the enablement state is supported for
        /// both resident and inherited modules (though resident modules cannot have an
        /// enablement state of "inherited"). Updating the display name or
        /// configuration of a module is supported for resident modules only. The type
        /// of a module cannot be changed.
        /// </summary>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. If omitted, then all fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EventThreatDetectionCustomModule UpdateEventThreatDetectionCustomModule(EventThreatDetectionCustomModule eventThreatDetectionCustomModule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEventThreatDetectionCustomModule(new UpdateEventThreatDetectionCustomModuleRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Updates the Event Threat Detection custom module with the given name based
        /// on the given update mask. Updating the enablement state is supported for
        /// both resident and inherited modules (though resident modules cannot have an
        /// enablement state of "inherited"). Updating the display name or
        /// configuration of a module is supported for resident modules only. The type
        /// of a module cannot be changed.
        /// </summary>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. If omitted, then all fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> UpdateEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModule eventThreatDetectionCustomModule, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateEventThreatDetectionCustomModuleAsync(new UpdateEventThreatDetectionCustomModuleRequest
            {
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
                EventThreatDetectionCustomModule = gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModule, nameof(eventThreatDetectionCustomModule)),
            }, callSettings);

        /// <summary>
        /// Updates the Event Threat Detection custom module with the given name based
        /// on the given update mask. Updating the enablement state is supported for
        /// both resident and inherited modules (though resident modules cannot have an
        /// enablement state of "inherited"). Updating the display name or
        /// configuration of a module is supported for resident modules only. The type
        /// of a module cannot be changed.
        /// </summary>
        /// <param name="eventThreatDetectionCustomModule">
        /// Required. The module being updated.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. If omitted, then all fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EventThreatDetectionCustomModule> UpdateEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModule eventThreatDetectionCustomModule, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateEventThreatDetectionCustomModuleAsync(eventThreatDetectionCustomModule, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEventThreatDetectionCustomModule(DeleteEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventThreatDetectionCustomModuleAsync(DeleteEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventThreatDetectionCustomModuleAsync(DeleteEventThreatDetectionCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            DeleteEventThreatDetectionCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEventThreatDetectionCustomModule(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEventThreatDetectionCustomModule(new DeleteEventThreatDetectionCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventThreatDetectionCustomModuleAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEventThreatDetectionCustomModuleAsync(new DeleteEventThreatDetectionCustomModuleRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventThreatDetectionCustomModuleAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteEventThreatDetectionCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteEventThreatDetectionCustomModule(EventThreatDetectionCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEventThreatDetectionCustomModule(new DeleteEventThreatDetectionCustomModuleRequest
            {
                EventThreatDetectionCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModuleName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteEventThreatDetectionCustomModuleAsync(new DeleteEventThreatDetectionCustomModuleRequest
            {
                EventThreatDetectionCustomModuleName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name of the Event Threat Detection custom module, in
        /// one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// * `projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{custom_module}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteEventThreatDetectionCustomModuleAsync(EventThreatDetectionCustomModuleName name, st::CancellationToken cancellationToken) =>
            DeleteEventThreatDetectionCustomModuleAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Validates the given Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ValidateEventThreatDetectionCustomModuleResponse ValidateEventThreatDetectionCustomModule(ValidateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates the given Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateEventThreatDetectionCustomModuleResponse> ValidateEventThreatDetectionCustomModuleAsync(ValidateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Validates the given Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ValidateEventThreatDetectionCustomModuleResponse> ValidateEventThreatDetectionCustomModuleAsync(ValidateEventThreatDetectionCustomModuleRequest request, st::CancellationToken cancellationToken) =>
            ValidateEventThreatDetectionCustomModuleAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityCenterService GetSecurityCenterService(GetSecurityCenterServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> GetSecurityCenterServiceAsync(GetSecurityCenterServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> GetSecurityCenterServiceAsync(GetSecurityCenterServiceRequest request, st::CancellationToken cancellationToken) =>
            GetSecurityCenterServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="name">
        /// Required. The Security Command Center service to retrieve, in one of the
        /// following formats:
        /// 
        /// * organizations/{organization}/locations/{location}/securityCenterServices/{service}
        /// * folders/{folder}/locations/{location}/securityCenterServices/{service}
        /// * projects/{project}/locations/{location}/securityCenterServices/{service}
        /// 
        /// The following values are valid for `{service}`:
        /// 
        /// * `container-threat-detection`
        /// * `event-threat-detection`
        /// * `security-health-analytics`
        /// * `vm-threat-detection`
        /// * `web-security-scanner`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityCenterService GetSecurityCenterService(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityCenterService(new GetSecurityCenterServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="name">
        /// Required. The Security Command Center service to retrieve, in one of the
        /// following formats:
        /// 
        /// * organizations/{organization}/locations/{location}/securityCenterServices/{service}
        /// * folders/{folder}/locations/{location}/securityCenterServices/{service}
        /// * projects/{project}/locations/{location}/securityCenterServices/{service}
        /// 
        /// The following values are valid for `{service}`:
        /// 
        /// * `container-threat-detection`
        /// * `event-threat-detection`
        /// * `security-health-analytics`
        /// * `vm-threat-detection`
        /// * `web-security-scanner`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> GetSecurityCenterServiceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityCenterServiceAsync(new GetSecurityCenterServiceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="name">
        /// Required. The Security Command Center service to retrieve, in one of the
        /// following formats:
        /// 
        /// * organizations/{organization}/locations/{location}/securityCenterServices/{service}
        /// * folders/{folder}/locations/{location}/securityCenterServices/{service}
        /// * projects/{project}/locations/{location}/securityCenterServices/{service}
        /// 
        /// The following values are valid for `{service}`:
        /// 
        /// * `container-threat-detection`
        /// * `event-threat-detection`
        /// * `security-health-analytics`
        /// * `vm-threat-detection`
        /// * `web-security-scanner`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> GetSecurityCenterServiceAsync(string name, st::CancellationToken cancellationToken) =>
            GetSecurityCenterServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="name">
        /// Required. The Security Command Center service to retrieve, in one of the
        /// following formats:
        /// 
        /// * organizations/{organization}/locations/{location}/securityCenterServices/{service}
        /// * folders/{folder}/locations/{location}/securityCenterServices/{service}
        /// * projects/{project}/locations/{location}/securityCenterServices/{service}
        /// 
        /// The following values are valid for `{service}`:
        /// 
        /// * `container-threat-detection`
        /// * `event-threat-detection`
        /// * `security-health-analytics`
        /// * `vm-threat-detection`
        /// * `web-security-scanner`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityCenterService GetSecurityCenterService(SecurityCenterServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityCenterService(new GetSecurityCenterServiceRequest
            {
                SecurityCenterServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="name">
        /// Required. The Security Command Center service to retrieve, in one of the
        /// following formats:
        /// 
        /// * organizations/{organization}/locations/{location}/securityCenterServices/{service}
        /// * folders/{folder}/locations/{location}/securityCenterServices/{service}
        /// * projects/{project}/locations/{location}/securityCenterServices/{service}
        /// 
        /// The following values are valid for `{service}`:
        /// 
        /// * `container-threat-detection`
        /// * `event-threat-detection`
        /// * `security-health-analytics`
        /// * `vm-threat-detection`
        /// * `web-security-scanner`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> GetSecurityCenterServiceAsync(SecurityCenterServiceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetSecurityCenterServiceAsync(new GetSecurityCenterServiceRequest
            {
                SecurityCenterServiceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="name">
        /// Required. The Security Command Center service to retrieve, in one of the
        /// following formats:
        /// 
        /// * organizations/{organization}/locations/{location}/securityCenterServices/{service}
        /// * folders/{folder}/locations/{location}/securityCenterServices/{service}
        /// * projects/{project}/locations/{location}/securityCenterServices/{service}
        /// 
        /// The following values are valid for `{service}`:
        /// 
        /// * `container-threat-detection`
        /// * `event-threat-detection`
        /// * `security-health-analytics`
        /// * `vm-threat-detection`
        /// * `web-security-scanner`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> GetSecurityCenterServiceAsync(SecurityCenterServiceName name, st::CancellationToken cancellationToken) =>
            GetSecurityCenterServiceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServices(ListSecurityCenterServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServicesAsync(ListSecurityCenterServicesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to list Security Command Center services,
        /// in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServices(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
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
            return ListSecurityCenterServices(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to list Security Command Center services,
        /// in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServicesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
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
            return ListSecurityCenterServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to list Security Command Center services,
        /// in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServices(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
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
            return ListSecurityCenterServices(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to list Security Command Center services,
        /// in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServicesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
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
            return ListSecurityCenterServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to list Security Command Center services,
        /// in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServices(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityCenterServices(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to list Security Command Center services,
        /// in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServicesAsync(FolderLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
            {
                ParentAsFolderLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityCenterServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to list Security Command Center services,
        /// in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServices(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityCenterServices(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="parent">
        /// Required. The name of the parent to list Security Command Center services,
        /// in one of the following formats:
        /// 
        /// * `organizations/{organization}/locations/{location}`
        /// * `folders/{folder}/locations/{location}`
        /// * `projects/{project}/locations/{location}`
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
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServicesAsync(OrganizationLocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListSecurityCenterServicesRequest request = new ListSecurityCenterServicesRequest
            {
                ParentAsOrganizationLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListSecurityCenterServicesAsync(request, callSettings);
        }

        /// <summary>
        /// Updates a Security Command Center service using the given update mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityCenterService UpdateSecurityCenterService(UpdateSecurityCenterServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Security Command Center service using the given update mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> UpdateSecurityCenterServiceAsync(UpdateSecurityCenterServiceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a Security Command Center service using the given update mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> UpdateSecurityCenterServiceAsync(UpdateSecurityCenterServiceRequest request, st::CancellationToken cancellationToken) =>
            UpdateSecurityCenterServiceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a Security Command Center service using the given update mask.
        /// </summary>
        /// <param name="securityCenterService">
        /// Required. The updated service.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. Accepts the following values:
        /// 
        /// * `intended_enablement_state`
        /// * `modules`
        /// 
        /// If omitted, then all eligible fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SecurityCenterService UpdateSecurityCenterService(SecurityCenterService securityCenterService, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityCenterService(new UpdateSecurityCenterServiceRequest
            {
                SecurityCenterService = gax::GaxPreconditions.CheckNotNull(securityCenterService, nameof(securityCenterService)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Security Command Center service using the given update mask.
        /// </summary>
        /// <param name="securityCenterService">
        /// Required. The updated service.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. Accepts the following values:
        /// 
        /// * `intended_enablement_state`
        /// * `modules`
        /// 
        /// If omitted, then all eligible fields are updated.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> UpdateSecurityCenterServiceAsync(SecurityCenterService securityCenterService, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateSecurityCenterServiceAsync(new UpdateSecurityCenterServiceRequest
            {
                SecurityCenterService = gax::GaxPreconditions.CheckNotNull(securityCenterService, nameof(securityCenterService)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Updates a Security Command Center service using the given update mask.
        /// </summary>
        /// <param name="securityCenterService">
        /// Required. The updated service.
        /// </param>
        /// <param name="updateMask">
        /// Required. The fields to update. Accepts the following values:
        /// 
        /// * `intended_enablement_state`
        /// * `modules`
        /// 
        /// If omitted, then all eligible fields are updated.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SecurityCenterService> UpdateSecurityCenterServiceAsync(SecurityCenterService securityCenterService, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateSecurityCenterServiceAsync(securityCenterService, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SecurityCenterManagement client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service describing handlers for resources
    /// </remarks>
    public sealed partial class SecurityCenterManagementClientImpl : SecurityCenterManagementClient
    {
        private readonly gaxgrpc::ApiCall<ListEffectiveSecurityHealthAnalyticsCustomModulesRequest, ListEffectiveSecurityHealthAnalyticsCustomModulesResponse> _callListEffectiveSecurityHealthAnalyticsCustomModules;

        private readonly gaxgrpc::ApiCall<GetEffectiveSecurityHealthAnalyticsCustomModuleRequest, EffectiveSecurityHealthAnalyticsCustomModule> _callGetEffectiveSecurityHealthAnalyticsCustomModule;

        private readonly gaxgrpc::ApiCall<ListSecurityHealthAnalyticsCustomModulesRequest, ListSecurityHealthAnalyticsCustomModulesResponse> _callListSecurityHealthAnalyticsCustomModules;

        private readonly gaxgrpc::ApiCall<ListDescendantSecurityHealthAnalyticsCustomModulesRequest, ListDescendantSecurityHealthAnalyticsCustomModulesResponse> _callListDescendantSecurityHealthAnalyticsCustomModules;

        private readonly gaxgrpc::ApiCall<GetSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule> _callGetSecurityHealthAnalyticsCustomModule;

        private readonly gaxgrpc::ApiCall<CreateSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule> _callCreateSecurityHealthAnalyticsCustomModule;

        private readonly gaxgrpc::ApiCall<UpdateSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule> _callUpdateSecurityHealthAnalyticsCustomModule;

        private readonly gaxgrpc::ApiCall<DeleteSecurityHealthAnalyticsCustomModuleRequest, wkt::Empty> _callDeleteSecurityHealthAnalyticsCustomModule;

        private readonly gaxgrpc::ApiCall<SimulateSecurityHealthAnalyticsCustomModuleRequest, SimulateSecurityHealthAnalyticsCustomModuleResponse> _callSimulateSecurityHealthAnalyticsCustomModule;

        private readonly gaxgrpc::ApiCall<ListEffectiveEventThreatDetectionCustomModulesRequest, ListEffectiveEventThreatDetectionCustomModulesResponse> _callListEffectiveEventThreatDetectionCustomModules;

        private readonly gaxgrpc::ApiCall<GetEffectiveEventThreatDetectionCustomModuleRequest, EffectiveEventThreatDetectionCustomModule> _callGetEffectiveEventThreatDetectionCustomModule;

        private readonly gaxgrpc::ApiCall<ListEventThreatDetectionCustomModulesRequest, ListEventThreatDetectionCustomModulesResponse> _callListEventThreatDetectionCustomModules;

        private readonly gaxgrpc::ApiCall<ListDescendantEventThreatDetectionCustomModulesRequest, ListDescendantEventThreatDetectionCustomModulesResponse> _callListDescendantEventThreatDetectionCustomModules;

        private readonly gaxgrpc::ApiCall<GetEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule> _callGetEventThreatDetectionCustomModule;

        private readonly gaxgrpc::ApiCall<CreateEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule> _callCreateEventThreatDetectionCustomModule;

        private readonly gaxgrpc::ApiCall<UpdateEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule> _callUpdateEventThreatDetectionCustomModule;

        private readonly gaxgrpc::ApiCall<DeleteEventThreatDetectionCustomModuleRequest, wkt::Empty> _callDeleteEventThreatDetectionCustomModule;

        private readonly gaxgrpc::ApiCall<ValidateEventThreatDetectionCustomModuleRequest, ValidateEventThreatDetectionCustomModuleResponse> _callValidateEventThreatDetectionCustomModule;

        private readonly gaxgrpc::ApiCall<GetSecurityCenterServiceRequest, SecurityCenterService> _callGetSecurityCenterService;

        private readonly gaxgrpc::ApiCall<ListSecurityCenterServicesRequest, ListSecurityCenterServicesResponse> _callListSecurityCenterServices;

        private readonly gaxgrpc::ApiCall<UpdateSecurityCenterServiceRequest, SecurityCenterService> _callUpdateSecurityCenterService;

        /// <summary>
        /// Constructs a client wrapper for the SecurityCenterManagement service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SecurityCenterManagementSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SecurityCenterManagementClientImpl(SecurityCenterManagement.SecurityCenterManagementClient grpcClient, SecurityCenterManagementSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SecurityCenterManagementSettings effectiveSettings = settings ?? SecurityCenterManagementSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            _callListEffectiveSecurityHealthAnalyticsCustomModules = clientHelper.BuildApiCall<ListEffectiveSecurityHealthAnalyticsCustomModulesRequest, ListEffectiveSecurityHealthAnalyticsCustomModulesResponse>("ListEffectiveSecurityHealthAnalyticsCustomModules", grpcClient.ListEffectiveSecurityHealthAnalyticsCustomModulesAsync, grpcClient.ListEffectiveSecurityHealthAnalyticsCustomModules, effectiveSettings.ListEffectiveSecurityHealthAnalyticsCustomModulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEffectiveSecurityHealthAnalyticsCustomModules);
            Modify_ListEffectiveSecurityHealthAnalyticsCustomModulesApiCall(ref _callListEffectiveSecurityHealthAnalyticsCustomModules);
            _callGetEffectiveSecurityHealthAnalyticsCustomModule = clientHelper.BuildApiCall<GetEffectiveSecurityHealthAnalyticsCustomModuleRequest, EffectiveSecurityHealthAnalyticsCustomModule>("GetEffectiveSecurityHealthAnalyticsCustomModule", grpcClient.GetEffectiveSecurityHealthAnalyticsCustomModuleAsync, grpcClient.GetEffectiveSecurityHealthAnalyticsCustomModule, effectiveSettings.GetEffectiveSecurityHealthAnalyticsCustomModuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEffectiveSecurityHealthAnalyticsCustomModule);
            Modify_GetEffectiveSecurityHealthAnalyticsCustomModuleApiCall(ref _callGetEffectiveSecurityHealthAnalyticsCustomModule);
            _callListSecurityHealthAnalyticsCustomModules = clientHelper.BuildApiCall<ListSecurityHealthAnalyticsCustomModulesRequest, ListSecurityHealthAnalyticsCustomModulesResponse>("ListSecurityHealthAnalyticsCustomModules", grpcClient.ListSecurityHealthAnalyticsCustomModulesAsync, grpcClient.ListSecurityHealthAnalyticsCustomModules, effectiveSettings.ListSecurityHealthAnalyticsCustomModulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSecurityHealthAnalyticsCustomModules);
            Modify_ListSecurityHealthAnalyticsCustomModulesApiCall(ref _callListSecurityHealthAnalyticsCustomModules);
            _callListDescendantSecurityHealthAnalyticsCustomModules = clientHelper.BuildApiCall<ListDescendantSecurityHealthAnalyticsCustomModulesRequest, ListDescendantSecurityHealthAnalyticsCustomModulesResponse>("ListDescendantSecurityHealthAnalyticsCustomModules", grpcClient.ListDescendantSecurityHealthAnalyticsCustomModulesAsync, grpcClient.ListDescendantSecurityHealthAnalyticsCustomModules, effectiveSettings.ListDescendantSecurityHealthAnalyticsCustomModulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDescendantSecurityHealthAnalyticsCustomModules);
            Modify_ListDescendantSecurityHealthAnalyticsCustomModulesApiCall(ref _callListDescendantSecurityHealthAnalyticsCustomModules);
            _callGetSecurityHealthAnalyticsCustomModule = clientHelper.BuildApiCall<GetSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule>("GetSecurityHealthAnalyticsCustomModule", grpcClient.GetSecurityHealthAnalyticsCustomModuleAsync, grpcClient.GetSecurityHealthAnalyticsCustomModule, effectiveSettings.GetSecurityHealthAnalyticsCustomModuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSecurityHealthAnalyticsCustomModule);
            Modify_GetSecurityHealthAnalyticsCustomModuleApiCall(ref _callGetSecurityHealthAnalyticsCustomModule);
            _callCreateSecurityHealthAnalyticsCustomModule = clientHelper.BuildApiCall<CreateSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule>("CreateSecurityHealthAnalyticsCustomModule", grpcClient.CreateSecurityHealthAnalyticsCustomModuleAsync, grpcClient.CreateSecurityHealthAnalyticsCustomModule, effectiveSettings.CreateSecurityHealthAnalyticsCustomModuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateSecurityHealthAnalyticsCustomModule);
            Modify_CreateSecurityHealthAnalyticsCustomModuleApiCall(ref _callCreateSecurityHealthAnalyticsCustomModule);
            _callUpdateSecurityHealthAnalyticsCustomModule = clientHelper.BuildApiCall<UpdateSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule>("UpdateSecurityHealthAnalyticsCustomModule", grpcClient.UpdateSecurityHealthAnalyticsCustomModuleAsync, grpcClient.UpdateSecurityHealthAnalyticsCustomModule, effectiveSettings.UpdateSecurityHealthAnalyticsCustomModuleSettings).WithGoogleRequestParam("security_health_analytics_custom_module.name", request => request.SecurityHealthAnalyticsCustomModule?.Name);
            Modify_ApiCall(ref _callUpdateSecurityHealthAnalyticsCustomModule);
            Modify_UpdateSecurityHealthAnalyticsCustomModuleApiCall(ref _callUpdateSecurityHealthAnalyticsCustomModule);
            _callDeleteSecurityHealthAnalyticsCustomModule = clientHelper.BuildApiCall<DeleteSecurityHealthAnalyticsCustomModuleRequest, wkt::Empty>("DeleteSecurityHealthAnalyticsCustomModule", grpcClient.DeleteSecurityHealthAnalyticsCustomModuleAsync, grpcClient.DeleteSecurityHealthAnalyticsCustomModule, effectiveSettings.DeleteSecurityHealthAnalyticsCustomModuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteSecurityHealthAnalyticsCustomModule);
            Modify_DeleteSecurityHealthAnalyticsCustomModuleApiCall(ref _callDeleteSecurityHealthAnalyticsCustomModule);
            _callSimulateSecurityHealthAnalyticsCustomModule = clientHelper.BuildApiCall<SimulateSecurityHealthAnalyticsCustomModuleRequest, SimulateSecurityHealthAnalyticsCustomModuleResponse>("SimulateSecurityHealthAnalyticsCustomModule", grpcClient.SimulateSecurityHealthAnalyticsCustomModuleAsync, grpcClient.SimulateSecurityHealthAnalyticsCustomModule, effectiveSettings.SimulateSecurityHealthAnalyticsCustomModuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callSimulateSecurityHealthAnalyticsCustomModule);
            Modify_SimulateSecurityHealthAnalyticsCustomModuleApiCall(ref _callSimulateSecurityHealthAnalyticsCustomModule);
            _callListEffectiveEventThreatDetectionCustomModules = clientHelper.BuildApiCall<ListEffectiveEventThreatDetectionCustomModulesRequest, ListEffectiveEventThreatDetectionCustomModulesResponse>("ListEffectiveEventThreatDetectionCustomModules", grpcClient.ListEffectiveEventThreatDetectionCustomModulesAsync, grpcClient.ListEffectiveEventThreatDetectionCustomModules, effectiveSettings.ListEffectiveEventThreatDetectionCustomModulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEffectiveEventThreatDetectionCustomModules);
            Modify_ListEffectiveEventThreatDetectionCustomModulesApiCall(ref _callListEffectiveEventThreatDetectionCustomModules);
            _callGetEffectiveEventThreatDetectionCustomModule = clientHelper.BuildApiCall<GetEffectiveEventThreatDetectionCustomModuleRequest, EffectiveEventThreatDetectionCustomModule>("GetEffectiveEventThreatDetectionCustomModule", grpcClient.GetEffectiveEventThreatDetectionCustomModuleAsync, grpcClient.GetEffectiveEventThreatDetectionCustomModule, effectiveSettings.GetEffectiveEventThreatDetectionCustomModuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEffectiveEventThreatDetectionCustomModule);
            Modify_GetEffectiveEventThreatDetectionCustomModuleApiCall(ref _callGetEffectiveEventThreatDetectionCustomModule);
            _callListEventThreatDetectionCustomModules = clientHelper.BuildApiCall<ListEventThreatDetectionCustomModulesRequest, ListEventThreatDetectionCustomModulesResponse>("ListEventThreatDetectionCustomModules", grpcClient.ListEventThreatDetectionCustomModulesAsync, grpcClient.ListEventThreatDetectionCustomModules, effectiveSettings.ListEventThreatDetectionCustomModulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListEventThreatDetectionCustomModules);
            Modify_ListEventThreatDetectionCustomModulesApiCall(ref _callListEventThreatDetectionCustomModules);
            _callListDescendantEventThreatDetectionCustomModules = clientHelper.BuildApiCall<ListDescendantEventThreatDetectionCustomModulesRequest, ListDescendantEventThreatDetectionCustomModulesResponse>("ListDescendantEventThreatDetectionCustomModules", grpcClient.ListDescendantEventThreatDetectionCustomModulesAsync, grpcClient.ListDescendantEventThreatDetectionCustomModules, effectiveSettings.ListDescendantEventThreatDetectionCustomModulesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDescendantEventThreatDetectionCustomModules);
            Modify_ListDescendantEventThreatDetectionCustomModulesApiCall(ref _callListDescendantEventThreatDetectionCustomModules);
            _callGetEventThreatDetectionCustomModule = clientHelper.BuildApiCall<GetEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule>("GetEventThreatDetectionCustomModule", grpcClient.GetEventThreatDetectionCustomModuleAsync, grpcClient.GetEventThreatDetectionCustomModule, effectiveSettings.GetEventThreatDetectionCustomModuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetEventThreatDetectionCustomModule);
            Modify_GetEventThreatDetectionCustomModuleApiCall(ref _callGetEventThreatDetectionCustomModule);
            _callCreateEventThreatDetectionCustomModule = clientHelper.BuildApiCall<CreateEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule>("CreateEventThreatDetectionCustomModule", grpcClient.CreateEventThreatDetectionCustomModuleAsync, grpcClient.CreateEventThreatDetectionCustomModule, effectiveSettings.CreateEventThreatDetectionCustomModuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateEventThreatDetectionCustomModule);
            Modify_CreateEventThreatDetectionCustomModuleApiCall(ref _callCreateEventThreatDetectionCustomModule);
            _callUpdateEventThreatDetectionCustomModule = clientHelper.BuildApiCall<UpdateEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule>("UpdateEventThreatDetectionCustomModule", grpcClient.UpdateEventThreatDetectionCustomModuleAsync, grpcClient.UpdateEventThreatDetectionCustomModule, effectiveSettings.UpdateEventThreatDetectionCustomModuleSettings).WithGoogleRequestParam("event_threat_detection_custom_module.name", request => request.EventThreatDetectionCustomModule?.Name);
            Modify_ApiCall(ref _callUpdateEventThreatDetectionCustomModule);
            Modify_UpdateEventThreatDetectionCustomModuleApiCall(ref _callUpdateEventThreatDetectionCustomModule);
            _callDeleteEventThreatDetectionCustomModule = clientHelper.BuildApiCall<DeleteEventThreatDetectionCustomModuleRequest, wkt::Empty>("DeleteEventThreatDetectionCustomModule", grpcClient.DeleteEventThreatDetectionCustomModuleAsync, grpcClient.DeleteEventThreatDetectionCustomModule, effectiveSettings.DeleteEventThreatDetectionCustomModuleSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteEventThreatDetectionCustomModule);
            Modify_DeleteEventThreatDetectionCustomModuleApiCall(ref _callDeleteEventThreatDetectionCustomModule);
            _callValidateEventThreatDetectionCustomModule = clientHelper.BuildApiCall<ValidateEventThreatDetectionCustomModuleRequest, ValidateEventThreatDetectionCustomModuleResponse>("ValidateEventThreatDetectionCustomModule", grpcClient.ValidateEventThreatDetectionCustomModuleAsync, grpcClient.ValidateEventThreatDetectionCustomModule, effectiveSettings.ValidateEventThreatDetectionCustomModuleSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callValidateEventThreatDetectionCustomModule);
            Modify_ValidateEventThreatDetectionCustomModuleApiCall(ref _callValidateEventThreatDetectionCustomModule);
            _callGetSecurityCenterService = clientHelper.BuildApiCall<GetSecurityCenterServiceRequest, SecurityCenterService>("GetSecurityCenterService", grpcClient.GetSecurityCenterServiceAsync, grpcClient.GetSecurityCenterService, effectiveSettings.GetSecurityCenterServiceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetSecurityCenterService);
            Modify_GetSecurityCenterServiceApiCall(ref _callGetSecurityCenterService);
            _callListSecurityCenterServices = clientHelper.BuildApiCall<ListSecurityCenterServicesRequest, ListSecurityCenterServicesResponse>("ListSecurityCenterServices", grpcClient.ListSecurityCenterServicesAsync, grpcClient.ListSecurityCenterServices, effectiveSettings.ListSecurityCenterServicesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListSecurityCenterServices);
            Modify_ListSecurityCenterServicesApiCall(ref _callListSecurityCenterServices);
            _callUpdateSecurityCenterService = clientHelper.BuildApiCall<UpdateSecurityCenterServiceRequest, SecurityCenterService>("UpdateSecurityCenterService", grpcClient.UpdateSecurityCenterServiceAsync, grpcClient.UpdateSecurityCenterService, effectiveSettings.UpdateSecurityCenterServiceSettings).WithGoogleRequestParam("security_center_service.name", request => request.SecurityCenterService?.Name);
            Modify_ApiCall(ref _callUpdateSecurityCenterService);
            Modify_UpdateSecurityCenterServiceApiCall(ref _callUpdateSecurityCenterService);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListEffectiveSecurityHealthAnalyticsCustomModulesApiCall(ref gaxgrpc::ApiCall<ListEffectiveSecurityHealthAnalyticsCustomModulesRequest, ListEffectiveSecurityHealthAnalyticsCustomModulesResponse> call);

        partial void Modify_GetEffectiveSecurityHealthAnalyticsCustomModuleApiCall(ref gaxgrpc::ApiCall<GetEffectiveSecurityHealthAnalyticsCustomModuleRequest, EffectiveSecurityHealthAnalyticsCustomModule> call);

        partial void Modify_ListSecurityHealthAnalyticsCustomModulesApiCall(ref gaxgrpc::ApiCall<ListSecurityHealthAnalyticsCustomModulesRequest, ListSecurityHealthAnalyticsCustomModulesResponse> call);

        partial void Modify_ListDescendantSecurityHealthAnalyticsCustomModulesApiCall(ref gaxgrpc::ApiCall<ListDescendantSecurityHealthAnalyticsCustomModulesRequest, ListDescendantSecurityHealthAnalyticsCustomModulesResponse> call);

        partial void Modify_GetSecurityHealthAnalyticsCustomModuleApiCall(ref gaxgrpc::ApiCall<GetSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule> call);

        partial void Modify_CreateSecurityHealthAnalyticsCustomModuleApiCall(ref gaxgrpc::ApiCall<CreateSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule> call);

        partial void Modify_UpdateSecurityHealthAnalyticsCustomModuleApiCall(ref gaxgrpc::ApiCall<UpdateSecurityHealthAnalyticsCustomModuleRequest, SecurityHealthAnalyticsCustomModule> call);

        partial void Modify_DeleteSecurityHealthAnalyticsCustomModuleApiCall(ref gaxgrpc::ApiCall<DeleteSecurityHealthAnalyticsCustomModuleRequest, wkt::Empty> call);

        partial void Modify_SimulateSecurityHealthAnalyticsCustomModuleApiCall(ref gaxgrpc::ApiCall<SimulateSecurityHealthAnalyticsCustomModuleRequest, SimulateSecurityHealthAnalyticsCustomModuleResponse> call);

        partial void Modify_ListEffectiveEventThreatDetectionCustomModulesApiCall(ref gaxgrpc::ApiCall<ListEffectiveEventThreatDetectionCustomModulesRequest, ListEffectiveEventThreatDetectionCustomModulesResponse> call);

        partial void Modify_GetEffectiveEventThreatDetectionCustomModuleApiCall(ref gaxgrpc::ApiCall<GetEffectiveEventThreatDetectionCustomModuleRequest, EffectiveEventThreatDetectionCustomModule> call);

        partial void Modify_ListEventThreatDetectionCustomModulesApiCall(ref gaxgrpc::ApiCall<ListEventThreatDetectionCustomModulesRequest, ListEventThreatDetectionCustomModulesResponse> call);

        partial void Modify_ListDescendantEventThreatDetectionCustomModulesApiCall(ref gaxgrpc::ApiCall<ListDescendantEventThreatDetectionCustomModulesRequest, ListDescendantEventThreatDetectionCustomModulesResponse> call);

        partial void Modify_GetEventThreatDetectionCustomModuleApiCall(ref gaxgrpc::ApiCall<GetEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule> call);

        partial void Modify_CreateEventThreatDetectionCustomModuleApiCall(ref gaxgrpc::ApiCall<CreateEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule> call);

        partial void Modify_UpdateEventThreatDetectionCustomModuleApiCall(ref gaxgrpc::ApiCall<UpdateEventThreatDetectionCustomModuleRequest, EventThreatDetectionCustomModule> call);

        partial void Modify_DeleteEventThreatDetectionCustomModuleApiCall(ref gaxgrpc::ApiCall<DeleteEventThreatDetectionCustomModuleRequest, wkt::Empty> call);

        partial void Modify_ValidateEventThreatDetectionCustomModuleApiCall(ref gaxgrpc::ApiCall<ValidateEventThreatDetectionCustomModuleRequest, ValidateEventThreatDetectionCustomModuleResponse> call);

        partial void Modify_GetSecurityCenterServiceApiCall(ref gaxgrpc::ApiCall<GetSecurityCenterServiceRequest, SecurityCenterService> call);

        partial void Modify_ListSecurityCenterServicesApiCall(ref gaxgrpc::ApiCall<ListSecurityCenterServicesRequest, ListSecurityCenterServicesResponse> call);

        partial void Modify_UpdateSecurityCenterServiceApiCall(ref gaxgrpc::ApiCall<UpdateSecurityCenterServiceRequest, SecurityCenterService> call);

        partial void OnConstruction(SecurityCenterManagement.SecurityCenterManagementClient grpcClient, SecurityCenterManagementSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SecurityCenterManagement client</summary>
        public override SecurityCenterManagement.SecurityCenterManagementClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        partial void Modify_ListEffectiveSecurityHealthAnalyticsCustomModulesRequest(ref ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEffectiveSecurityHealthAnalyticsCustomModuleRequest(ref GetEffectiveSecurityHealthAnalyticsCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSecurityHealthAnalyticsCustomModulesRequest(ref ListSecurityHealthAnalyticsCustomModulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDescendantSecurityHealthAnalyticsCustomModulesRequest(ref ListDescendantSecurityHealthAnalyticsCustomModulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSecurityHealthAnalyticsCustomModuleRequest(ref GetSecurityHealthAnalyticsCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateSecurityHealthAnalyticsCustomModuleRequest(ref CreateSecurityHealthAnalyticsCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSecurityHealthAnalyticsCustomModuleRequest(ref UpdateSecurityHealthAnalyticsCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteSecurityHealthAnalyticsCustomModuleRequest(ref DeleteSecurityHealthAnalyticsCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SimulateSecurityHealthAnalyticsCustomModuleRequest(ref SimulateSecurityHealthAnalyticsCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEffectiveEventThreatDetectionCustomModulesRequest(ref ListEffectiveEventThreatDetectionCustomModulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEffectiveEventThreatDetectionCustomModuleRequest(ref GetEffectiveEventThreatDetectionCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListEventThreatDetectionCustomModulesRequest(ref ListEventThreatDetectionCustomModulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListDescendantEventThreatDetectionCustomModulesRequest(ref ListDescendantEventThreatDetectionCustomModulesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetEventThreatDetectionCustomModuleRequest(ref GetEventThreatDetectionCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateEventThreatDetectionCustomModuleRequest(ref CreateEventThreatDetectionCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateEventThreatDetectionCustomModuleRequest(ref UpdateEventThreatDetectionCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteEventThreatDetectionCustomModuleRequest(ref DeleteEventThreatDetectionCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ValidateEventThreatDetectionCustomModuleRequest(ref ValidateEventThreatDetectionCustomModuleRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetSecurityCenterServiceRequest(ref GetSecurityCenterServiceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListSecurityCenterServicesRequest(ref ListSecurityCenterServicesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateSecurityCenterServiceRequest(ref UpdateSecurityCenterServiceRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public override gax::PagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModules(ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEffectiveSecurityHealthAnalyticsCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesRequest, ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule>(_callListEffectiveSecurityHealthAnalyticsCustomModules, request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EffectiveSecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule> ListEffectiveSecurityHealthAnalyticsCustomModulesAsync(ListEffectiveSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEffectiveSecurityHealthAnalyticsCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEffectiveSecurityHealthAnalyticsCustomModulesRequest, ListEffectiveSecurityHealthAnalyticsCustomModulesResponse, EffectiveSecurityHealthAnalyticsCustomModule>(_callListEffectiveSecurityHealthAnalyticsCustomModules, request, callSettings);
        }

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EffectiveSecurityHealthAnalyticsCustomModule GetEffectiveSecurityHealthAnalyticsCustomModule(GetEffectiveSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEffectiveSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callGetEffectiveSecurityHealthAnalyticsCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details of a single
        /// [EffectiveSecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.EffectiveSecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EffectiveSecurityHealthAnalyticsCustomModule> GetEffectiveSecurityHealthAnalyticsCustomModuleAsync(GetEffectiveSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEffectiveSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callGetEffectiveSecurityHealthAnalyticsCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public override gax::PagedEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModules(ListSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecurityHealthAnalyticsCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSecurityHealthAnalyticsCustomModulesRequest, ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule>(_callListSecurityHealthAnalyticsCustomModules, request, callSettings);
        }

        /// <summary>
        /// Returns a list of all
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources for the given parent. This includes resident modules defined at
        /// the scope of the parent, and inherited modules, inherited from ancestor
        /// organizations, folders, and projects (no descendants).
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListSecurityHealthAnalyticsCustomModulesAsync(ListSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecurityHealthAnalyticsCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSecurityHealthAnalyticsCustomModulesRequest, ListSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule>(_callListSecurityHealthAnalyticsCustomModules, request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.</returns>
        public override gax::PagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModules(ListDescendantSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDescendantSecurityHealthAnalyticsCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesRequest, ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule>(_callListDescendantSecurityHealthAnalyticsCustomModules, request, callSettings);
        }

        /// <summary>
        /// Returns a list of all resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// resources under the given organization, folder, or project and all of its
        /// descendants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="SecurityHealthAnalyticsCustomModule"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule> ListDescendantSecurityHealthAnalyticsCustomModulesAsync(ListDescendantSecurityHealthAnalyticsCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDescendantSecurityHealthAnalyticsCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDescendantSecurityHealthAnalyticsCustomModulesRequest, ListDescendantSecurityHealthAnalyticsCustomModulesResponse, SecurityHealthAnalyticsCustomModule>(_callListDescendantSecurityHealthAnalyticsCustomModules, request, callSettings);
        }

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityHealthAnalyticsCustomModule GetSecurityHealthAnalyticsCustomModule(GetSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callGetSecurityHealthAnalyticsCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Retrieves a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityHealthAnalyticsCustomModule> GetSecurityHealthAnalyticsCustomModuleAsync(GetSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callGetSecurityHealthAnalyticsCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityHealthAnalyticsCustomModule CreateSecurityHealthAnalyticsCustomModule(CreateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callCreateSecurityHealthAnalyticsCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a resident
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// at the scope of the given organization, folder, or project, and also
        /// creates inherited `SecurityHealthAnalyticsCustomModule` resources for all
        /// folders and projects that are descendants of the given parent. These
        /// modules are enabled by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityHealthAnalyticsCustomModule> CreateSecurityHealthAnalyticsCustomModuleAsync(CreateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callCreateSecurityHealthAnalyticsCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// under the given name based on the given update mask. Updating the
        /// enablement state is supported on both resident and inherited modules
        /// (though resident modules cannot have an enablement state of "inherited").
        /// Updating the display name and custom configuration of a module is supported
        /// on resident modules only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityHealthAnalyticsCustomModule UpdateSecurityHealthAnalyticsCustomModule(UpdateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callUpdateSecurityHealthAnalyticsCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// under the given name based on the given update mask. Updating the
        /// enablement state is supported on both resident and inherited modules
        /// (though resident modules cannot have an enablement state of "inherited").
        /// Updating the display name and custom configuration of a module is supported
        /// on resident modules only.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityHealthAnalyticsCustomModule> UpdateSecurityHealthAnalyticsCustomModuleAsync(UpdateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callUpdateSecurityHealthAnalyticsCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteSecurityHealthAnalyticsCustomModule(DeleteSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            _callDeleteSecurityHealthAnalyticsCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// and all of its descendants in the resource hierarchy. This method is only
        /// supported for resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteSecurityHealthAnalyticsCustomModuleAsync(DeleteSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callDeleteSecurityHealthAnalyticsCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Simulates the result of using a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// to check a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SimulateSecurityHealthAnalyticsCustomModuleResponse SimulateSecurityHealthAnalyticsCustomModule(SimulateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SimulateSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callSimulateSecurityHealthAnalyticsCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Simulates the result of using a
        /// [SecurityHealthAnalyticsCustomModule][google.cloud.securitycentermanagement.v1.SecurityHealthAnalyticsCustomModule]
        /// to check a resource.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SimulateSecurityHealthAnalyticsCustomModuleResponse> SimulateSecurityHealthAnalyticsCustomModuleAsync(SimulateSecurityHealthAnalyticsCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SimulateSecurityHealthAnalyticsCustomModuleRequest(ref request, ref callSettings);
            return _callSimulateSecurityHealthAnalyticsCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.</returns>
        public override gax::PagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModules(ListEffectiveEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEffectiveEventThreatDetectionCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEffectiveEventThreatDetectionCustomModulesRequest, ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule>(_callListEffectiveEventThreatDetectionCustomModules, request, callSettings);
        }

        /// <summary>
        /// Lists all effective Event Threat Detection custom modules for the
        /// given parent. This includes resident modules defined at the scope of the
        /// parent along with modules inherited from its ancestors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EffectiveEventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule> ListEffectiveEventThreatDetectionCustomModulesAsync(ListEffectiveEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEffectiveEventThreatDetectionCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEffectiveEventThreatDetectionCustomModulesRequest, ListEffectiveEventThreatDetectionCustomModulesResponse, EffectiveEventThreatDetectionCustomModule>(_callListEffectiveEventThreatDetectionCustomModules, request, callSettings);
        }

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EffectiveEventThreatDetectionCustomModule GetEffectiveEventThreatDetectionCustomModule(GetEffectiveEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEffectiveEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callGetEffectiveEventThreatDetectionCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets the effective Event Threat Detection custom module at the given level.
        /// 
        /// The difference between an
        /// [EffectiveEventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EffectiveEventThreatDetectionCustomModule]
        /// and an
        /// [EventThreatDetectionCustomModule][google.cloud.securitycentermanagement.v1.EventThreatDetectionCustomModule]
        /// is that the fields for an `EffectiveEventThreatDetectionCustomModule` are
        /// computed from ancestors if needed. For example, the enablement state for an
        /// `EventThreatDetectionCustomModule` can be `ENABLED`, `DISABLED`, or
        /// `INHERITED`. In contrast, the enablement state for an
        /// `EffectiveEventThreatDetectionCustomModule` is always computed as `ENABLED`
        /// or `DISABLED`.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EffectiveEventThreatDetectionCustomModule> GetEffectiveEventThreatDetectionCustomModuleAsync(GetEffectiveEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEffectiveEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callGetEffectiveEventThreatDetectionCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public override gax::PagedEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModules(ListEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventThreatDetectionCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListEventThreatDetectionCustomModulesRequest, ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule>(_callListEventThreatDetectionCustomModules, request, callSettings);
        }

        /// <summary>
        /// Lists all Event Threat Detection custom modules for the given organization,
        /// folder, or project. This includes resident modules defined at the scope of
        /// the parent along with modules inherited from ancestors.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListEventThreatDetectionCustomModulesAsync(ListEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListEventThreatDetectionCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListEventThreatDetectionCustomModulesRequest, ListEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule>(_callListEventThreatDetectionCustomModules, request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="EventThreatDetectionCustomModule"/> resources.</returns>
        public override gax::PagedEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModules(ListDescendantEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDescendantEventThreatDetectionCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDescendantEventThreatDetectionCustomModulesRequest, ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule>(_callListDescendantEventThreatDetectionCustomModules, request, callSettings);
        }

        /// <summary>
        /// Lists all resident Event Threat Detection custom modules for the given
        /// organization, folder, or project and its descendants.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>
        /// A pageable asynchronous sequence of <see cref="EventThreatDetectionCustomModule"/> resources.
        /// </returns>
        public override gax::PagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule> ListDescendantEventThreatDetectionCustomModulesAsync(ListDescendantEventThreatDetectionCustomModulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDescendantEventThreatDetectionCustomModulesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDescendantEventThreatDetectionCustomModulesRequest, ListDescendantEventThreatDetectionCustomModulesResponse, EventThreatDetectionCustomModule>(_callListDescendantEventThreatDetectionCustomModules, request, callSettings);
        }

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EventThreatDetectionCustomModule GetEventThreatDetectionCustomModule(GetEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callGetEventThreatDetectionCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets an Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EventThreatDetectionCustomModule> GetEventThreatDetectionCustomModuleAsync(GetEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callGetEventThreatDetectionCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EventThreatDetectionCustomModule CreateEventThreatDetectionCustomModule(CreateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callCreateEventThreatDetectionCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a resident Event Threat Detection custom module at the scope of the
        /// given organization, folder, or project, and creates inherited custom
        /// modules for all descendants of the given parent. These modules are enabled
        /// by default.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EventThreatDetectionCustomModule> CreateEventThreatDetectionCustomModuleAsync(CreateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callCreateEventThreatDetectionCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Updates the Event Threat Detection custom module with the given name based
        /// on the given update mask. Updating the enablement state is supported for
        /// both resident and inherited modules (though resident modules cannot have an
        /// enablement state of "inherited"). Updating the display name or
        /// configuration of a module is supported for resident modules only. The type
        /// of a module cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EventThreatDetectionCustomModule UpdateEventThreatDetectionCustomModule(UpdateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callUpdateEventThreatDetectionCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates the Event Threat Detection custom module with the given name based
        /// on the given update mask. Updating the enablement state is supported for
        /// both resident and inherited modules (though resident modules cannot have an
        /// enablement state of "inherited"). Updating the display name or
        /// configuration of a module is supported for resident modules only. The type
        /// of a module cannot be changed.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EventThreatDetectionCustomModule> UpdateEventThreatDetectionCustomModuleAsync(UpdateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callUpdateEventThreatDetectionCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteEventThreatDetectionCustomModule(DeleteEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            _callDeleteEventThreatDetectionCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes the specified Event Threat Detection custom module and all of its
        /// descendants in the resource hierarchy. This method is only supported for
        /// resident custom modules.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteEventThreatDetectionCustomModuleAsync(DeleteEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callDeleteEventThreatDetectionCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Validates the given Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ValidateEventThreatDetectionCustomModuleResponse ValidateEventThreatDetectionCustomModule(ValidateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callValidateEventThreatDetectionCustomModule.Sync(request, callSettings);
        }

        /// <summary>
        /// Validates the given Event Threat Detection custom module.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ValidateEventThreatDetectionCustomModuleResponse> ValidateEventThreatDetectionCustomModuleAsync(ValidateEventThreatDetectionCustomModuleRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ValidateEventThreatDetectionCustomModuleRequest(ref request, ref callSettings);
            return _callValidateEventThreatDetectionCustomModule.Async(request, callSettings);
        }

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityCenterService GetSecurityCenterService(GetSecurityCenterServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecurityCenterServiceRequest(ref request, ref callSettings);
            return _callGetSecurityCenterService.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets service settings for the specified Security Command Center service.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityCenterService> GetSecurityCenterServiceAsync(GetSecurityCenterServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSecurityCenterServiceRequest(ref request, ref callSettings);
            return _callGetSecurityCenterService.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public override gax::PagedEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServices(ListSecurityCenterServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecurityCenterServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListSecurityCenterServicesRequest, ListSecurityCenterServicesResponse, SecurityCenterService>(_callListSecurityCenterServices, request, callSettings);
        }

        /// <summary>
        /// Returns a list of all Security Command Center services for the given
        /// parent.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="SecurityCenterService"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListSecurityCenterServicesResponse, SecurityCenterService> ListSecurityCenterServicesAsync(ListSecurityCenterServicesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListSecurityCenterServicesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListSecurityCenterServicesRequest, ListSecurityCenterServicesResponse, SecurityCenterService>(_callListSecurityCenterServices, request, callSettings);
        }

        /// <summary>
        /// Updates a Security Command Center service using the given update mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SecurityCenterService UpdateSecurityCenterService(UpdateSecurityCenterServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityCenterServiceRequest(ref request, ref callSettings);
            return _callUpdateSecurityCenterService.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates a Security Command Center service using the given update mask.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SecurityCenterService> UpdateSecurityCenterServiceAsync(UpdateSecurityCenterServiceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateSecurityCenterServiceRequest(ref request, ref callSettings);
            return _callUpdateSecurityCenterService.Async(request, callSettings);
        }
    }

    public partial class ListEffectiveSecurityHealthAnalyticsCustomModulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSecurityHealthAnalyticsCustomModulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDescendantSecurityHealthAnalyticsCustomModulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEffectiveEventThreatDetectionCustomModulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEventThreatDetectionCustomModulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDescendantEventThreatDetectionCustomModulesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListSecurityCenterServicesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListEffectiveSecurityHealthAnalyticsCustomModulesResponse : gaxgrpc::IPageResponse<EffectiveSecurityHealthAnalyticsCustomModule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EffectiveSecurityHealthAnalyticsCustomModule> GetEnumerator() =>
            EffectiveSecurityHealthAnalyticsCustomModules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSecurityHealthAnalyticsCustomModulesResponse : gaxgrpc::IPageResponse<SecurityHealthAnalyticsCustomModule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SecurityHealthAnalyticsCustomModule> GetEnumerator() =>
            SecurityHealthAnalyticsCustomModules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDescendantSecurityHealthAnalyticsCustomModulesResponse : gaxgrpc::IPageResponse<SecurityHealthAnalyticsCustomModule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SecurityHealthAnalyticsCustomModule> GetEnumerator() =>
            SecurityHealthAnalyticsCustomModules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEffectiveEventThreatDetectionCustomModulesResponse : gaxgrpc::IPageResponse<EffectiveEventThreatDetectionCustomModule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EffectiveEventThreatDetectionCustomModule> GetEnumerator() =>
            EffectiveEventThreatDetectionCustomModules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListEventThreatDetectionCustomModulesResponse : gaxgrpc::IPageResponse<EventThreatDetectionCustomModule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EventThreatDetectionCustomModule> GetEnumerator() =>
            EventThreatDetectionCustomModules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListDescendantEventThreatDetectionCustomModulesResponse : gaxgrpc::IPageResponse<EventThreatDetectionCustomModule>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<EventThreatDetectionCustomModule> GetEnumerator() =>
            EventThreatDetectionCustomModules.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListSecurityCenterServicesResponse : gaxgrpc::IPageResponse<SecurityCenterService>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<SecurityCenterService> GetEnumerator() => SecurityCenterServices.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class SecurityCenterManagement
    {
        public partial class SecurityCenterManagementClient
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
