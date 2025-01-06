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

namespace Google.Cloud.Config.V1
{
    /// <summary>Settings for <see cref="ConfigClient"/> instances.</summary>
    public sealed partial class ConfigSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConfigSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConfigSettings"/>.</returns>
        public static ConfigSettings GetDefault() => new ConfigSettings();

        /// <summary>Constructs a new <see cref="ConfigSettings"/> object with default settings.</summary>
        public ConfigSettings()
        {
        }

        private ConfigSettings(ConfigSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListDeploymentsSettings = existing.ListDeploymentsSettings;
            GetDeploymentSettings = existing.GetDeploymentSettings;
            CreateDeploymentSettings = existing.CreateDeploymentSettings;
            CreateDeploymentOperationsSettings = existing.CreateDeploymentOperationsSettings.Clone();
            UpdateDeploymentSettings = existing.UpdateDeploymentSettings;
            UpdateDeploymentOperationsSettings = existing.UpdateDeploymentOperationsSettings.Clone();
            DeleteDeploymentSettings = existing.DeleteDeploymentSettings;
            DeleteDeploymentOperationsSettings = existing.DeleteDeploymentOperationsSettings.Clone();
            ListRevisionsSettings = existing.ListRevisionsSettings;
            GetRevisionSettings = existing.GetRevisionSettings;
            GetResourceSettings = existing.GetResourceSettings;
            ListResourcesSettings = existing.ListResourcesSettings;
            ExportDeploymentStatefileSettings = existing.ExportDeploymentStatefileSettings;
            ExportRevisionStatefileSettings = existing.ExportRevisionStatefileSettings;
            ImportStatefileSettings = existing.ImportStatefileSettings;
            DeleteStatefileSettings = existing.DeleteStatefileSettings;
            LockDeploymentSettings = existing.LockDeploymentSettings;
            LockDeploymentOperationsSettings = existing.LockDeploymentOperationsSettings.Clone();
            UnlockDeploymentSettings = existing.UnlockDeploymentSettings;
            UnlockDeploymentOperationsSettings = existing.UnlockDeploymentOperationsSettings.Clone();
            ExportLockInfoSettings = existing.ExportLockInfoSettings;
            CreatePreviewSettings = existing.CreatePreviewSettings;
            CreatePreviewOperationsSettings = existing.CreatePreviewOperationsSettings.Clone();
            GetPreviewSettings = existing.GetPreviewSettings;
            ListPreviewsSettings = existing.ListPreviewsSettings;
            DeletePreviewSettings = existing.DeletePreviewSettings;
            DeletePreviewOperationsSettings = existing.DeletePreviewOperationsSettings.Clone();
            ExportPreviewResultSettings = existing.ExportPreviewResultSettings;
            ListTerraformVersionsSettings = existing.ListTerraformVersionsSettings;
            GetTerraformVersionSettings = existing.GetTerraformVersionSettings;
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConfigSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.ListDeployments</c> and <c>ConfigClient.ListDeploymentsAsync</c>.
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
        public gaxgrpc::CallSettings ListDeploymentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.GetDeployment</c>
        ///  and <c>ConfigClient.GetDeploymentAsync</c>.
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
        public gaxgrpc::CallSettings GetDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.CreateDeployment</c> and <c>ConfigClient.CreateDeploymentAsync</c>.
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
        public gaxgrpc::CallSettings CreateDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigClient.CreateDeployment</c> and
        /// <c>ConfigClient.CreateDeploymentAsync</c>.
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
        public lro::OperationsSettings CreateDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.UpdateDeployment</c> and <c>ConfigClient.UpdateDeploymentAsync</c>.
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
        public gaxgrpc::CallSettings UpdateDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigClient.UpdateDeployment</c> and
        /// <c>ConfigClient.UpdateDeploymentAsync</c>.
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
        public lro::OperationsSettings UpdateDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.DeleteDeployment</c> and <c>ConfigClient.DeleteDeploymentAsync</c>.
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
        public gaxgrpc::CallSettings DeleteDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigClient.DeleteDeployment</c> and
        /// <c>ConfigClient.DeleteDeploymentAsync</c>.
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
        public lro::OperationsSettings DeleteDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.ListRevisions</c>
        ///  and <c>ConfigClient.ListRevisionsAsync</c>.
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
        public gaxgrpc::CallSettings ListRevisionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.GetRevision</c>
        ///  and <c>ConfigClient.GetRevisionAsync</c>.
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
        public gaxgrpc::CallSettings GetRevisionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.GetResource</c>
        ///  and <c>ConfigClient.GetResourceAsync</c>.
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
        public gaxgrpc::CallSettings GetResourceSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.ListResources</c>
        ///  and <c>ConfigClient.ListResourcesAsync</c>.
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
        public gaxgrpc::CallSettings ListResourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.ExportDeploymentStatefile</c> and <c>ConfigClient.ExportDeploymentStatefileAsync</c>.
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
        public gaxgrpc::CallSettings ExportDeploymentStatefileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.ExportRevisionStatefile</c> and <c>ConfigClient.ExportRevisionStatefileAsync</c>.
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
        public gaxgrpc::CallSettings ExportRevisionStatefileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.ImportStatefile</c> and <c>ConfigClient.ImportStatefileAsync</c>.
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
        public gaxgrpc::CallSettings ImportStatefileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.DeleteStatefile</c> and <c>ConfigClient.DeleteStatefileAsync</c>.
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
        public gaxgrpc::CallSettings DeleteStatefileSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.LockDeployment</c>
        ///  and <c>ConfigClient.LockDeploymentAsync</c>.
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
        public gaxgrpc::CallSettings LockDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigClient.LockDeployment</c> and
        /// <c>ConfigClient.LockDeploymentAsync</c>.
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
        public lro::OperationsSettings LockDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.UnlockDeployment</c> and <c>ConfigClient.UnlockDeploymentAsync</c>.
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
        public gaxgrpc::CallSettings UnlockDeploymentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigClient.UnlockDeployment</c> and
        /// <c>ConfigClient.UnlockDeploymentAsync</c>.
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
        public lro::OperationsSettings UnlockDeploymentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.ExportLockInfo</c>
        ///  and <c>ConfigClient.ExportLockInfoAsync</c>.
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
        public gaxgrpc::CallSettings ExportLockInfoSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.CreatePreview</c>
        ///  and <c>ConfigClient.CreatePreviewAsync</c>.
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
        public gaxgrpc::CallSettings CreatePreviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigClient.CreatePreview</c> and
        /// <c>ConfigClient.CreatePreviewAsync</c>.
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
        public lro::OperationsSettings CreatePreviewOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.GetPreview</c>
        /// and <c>ConfigClient.GetPreviewAsync</c>.
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
        public gaxgrpc::CallSettings GetPreviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.ListPreviews</c>
        ///  and <c>ConfigClient.ListPreviewsAsync</c>.
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
        public gaxgrpc::CallSettings ListPreviewsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>ConfigClient.DeletePreview</c>
        ///  and <c>ConfigClient.DeletePreviewAsync</c>.
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
        public gaxgrpc::CallSettings DeletePreviewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ConfigClient.DeletePreview</c> and
        /// <c>ConfigClient.DeletePreviewAsync</c>.
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
        public lro::OperationsSettings DeletePreviewOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.ExportPreviewResult</c> and <c>ConfigClient.ExportPreviewResultAsync</c>.
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
        public gaxgrpc::CallSettings ExportPreviewResultSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.ListTerraformVersions</c> and <c>ConfigClient.ListTerraformVersionsAsync</c>.
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
        public gaxgrpc::CallSettings ListTerraformVersionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConfigClient.GetTerraformVersion</c> and <c>ConfigClient.GetTerraformVersionAsync</c>.
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
        public gaxgrpc::CallSettings GetTerraformVersionSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 5, initialBackoff: sys::TimeSpan.FromMilliseconds(1000), maxBackoff: sys::TimeSpan.FromMilliseconds(10000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable)));

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConfigSettings"/> object.</returns>
        public ConfigSettings Clone() => new ConfigSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConfigClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ConfigClientBuilder : gaxgrpc::ClientBuilderBase<ConfigClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConfigSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConfigClientBuilder() : base(ConfigClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConfigClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConfigClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConfigClient Build()
        {
            ConfigClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConfigClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConfigClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConfigClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConfigClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ConfigClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConfigClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConfigClient.ChannelPool;
    }

    /// <summary>Config client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Infrastructure Manager is a managed service that automates the deployment and
    /// management of Google Cloud infrastructure resources.
    /// </remarks>
    public abstract partial class ConfigClient
    {
        /// <summary>
        /// The default endpoint for the Config service, which is a host of "config.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "config.googleapis.com:443";

        /// <summary>The default Config scopes.</summary>
        /// <remarks>
        /// The default Config scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(Config.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConfigClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ConfigClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConfigClient"/>.</returns>
        public static stt::Task<ConfigClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConfigClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConfigClient"/> using the default credentials, endpoint and settings. To
        /// specify custom credentials or other settings, use <see cref="ConfigClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConfigClient"/>.</returns>
        public static ConfigClient Create() => new ConfigClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConfigClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConfigSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConfigClient"/>.</returns>
        internal static ConfigClient Create(grpccore::CallInvoker callInvoker, ConfigSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            Config.ConfigClient grpcClient = new Config.ConfigClient(callInvoker);
            return new ConfigClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC Config client</summary>
        public virtual Config.ConfigClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Deployment][google.cloud.config.v1.Deployment]s in a given project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Deployment][google.cloud.config.v1.Deployment]s in a given project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Deployment][google.cloud.config.v1.Deployment]s in a given project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployments are listed. The
        /// parent value is in the format:
        /// 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists [Deployment][google.cloud.config.v1.Deployment]s in a given project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployments are listed. The
        /// parent value is in the format:
        /// 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Deployment][google.cloud.config.v1.Deployment]s in a given project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployments are listed. The
        /// parent value is in the format:
        /// 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeployments(request, callSettings);
        }

        /// <summary>
        /// Lists [Deployment][google.cloud.config.v1.Deployment]s in a given project
        /// and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployments are listed. The
        /// parent value is in the format:
        /// 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListDeploymentsRequest request = new ListDeploymentsRequest
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
            return ListDeploymentsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment. Format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment. Format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment. Format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment. Format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Deployment GetDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeployment(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment. Format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            GetDeploymentAsync(new GetDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment. Format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Deployment> GetDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            GetDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> CreateDeploymentAsync(CreateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateDeployment</c>.</summary>
        public virtual lro::OperationsClient CreateDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> PollOnceCreateDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> PollOnceCreateDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployment is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] resource to be
        /// created.
        /// </param>
        /// <param name="deploymentId">
        /// Required. The Deployment ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> CreateDeployment(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployment is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] resource to be
        /// created.
        /// </param>
        /// <param name="deploymentId">
        /// Required. The Deployment ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                DeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployment is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] resource to be
        /// created.
        /// </param>
        /// <param name="deploymentId">
        /// Required. The Deployment ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> CreateDeploymentAsync(string parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployment is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] resource to be
        /// created.
        /// </param>
        /// <param name="deploymentId">
        /// Required. The Deployment ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> CreateDeployment(gagr::LocationName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeployment(new CreateDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployment is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] resource to be
        /// created.
        /// </param>
        /// <param name="deploymentId">
        /// Required. The Deployment ID.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> CreateDeploymentAsync(gagr::LocationName parent, Deployment deployment, string deploymentId, gaxgrpc::CallSettings callSettings = null) =>
            CreateDeploymentAsync(new CreateDeploymentRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                DeploymentId = gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)),
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Deployment is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] resource to be
        /// created.
        /// </param>
        /// <param name="deploymentId">
        /// Required. The Deployment ID.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> CreateDeploymentAsync(gagr::LocationName parent, Deployment deployment, string deploymentId, st::CancellationToken cancellationToken) =>
            CreateDeploymentAsync(parent, deployment, deploymentId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> UpdateDeployment(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UpdateDeploymentAsync(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UpdateDeploymentAsync(UpdateDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UpdateDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateDeployment</c>.</summary>
        public virtual lro::OperationsClient UpdateDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> PollOnceUpdateDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> PollOnceUpdateDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Updates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] to update.
        /// 
        /// The deployment's `name` field is used to identify the resource to be
        /// updated. Format:
        /// `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask used to specify the fields to be overwritten in the
        /// Deployment resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> UpdateDeployment(Deployment deployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeployment(new UpdateDeploymentRequest
            {
                UpdateMask = updateMask,
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Updates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] to update.
        /// 
        /// The deployment's `name` field is used to identify the resource to be
        /// updated. Format:
        /// `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask used to specify the fields to be overwritten in the
        /// Deployment resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UpdateDeploymentAsync(Deployment deployment, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateDeploymentAsync(new UpdateDeploymentRequest
            {
                UpdateMask = updateMask,
                Deployment = gax::GaxPreconditions.CheckNotNull(deployment, nameof(deployment)),
            }, callSettings);

        /// <summary>
        /// Updates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="deployment">
        /// Required. [Deployment][google.cloud.config.v1.Deployment] to update.
        /// 
        /// The deployment's `name` field is used to identify the resource to be
        /// updated. Format:
        /// `projects/{project}/locations/{location}/deployments/{deployment}`
        /// </param>
        /// <param name="updateMask">
        /// Optional. Field mask used to specify the fields to be overwritten in the
        /// Deployment resource by the update.
        /// 
        /// The fields specified in the update_mask are relative to the resource, not
        /// the full request. A field will be overwritten if it is in the mask. If the
        /// user does not provide a mask then all fields will be overwritten.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UpdateDeploymentAsync(Deployment deployment, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateDeploymentAsync(deployment, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> DeleteDeployment(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> DeleteDeploymentAsync(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> DeleteDeploymentAsync(DeleteDeploymentRequest request, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteDeployment</c>.</summary>
        public virtual lro::OperationsClient DeleteDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> PollOnceDeleteDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> PollOnceDeleteDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> DeleteDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployment(new DeleteDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> DeleteDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentAsync(new DeleteDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> DeleteDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> DeleteDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeployment(new DeleteDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> DeleteDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteDeploymentAsync(new DeleteDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> DeleteDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Revision][google.cloud.config.v1.Revision]s of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRevisionsResponse, Revision> ListRevisions(ListRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Revision][google.cloud.config.v1.Revision]s of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRevisionsResponse, Revision> ListRevisionsAsync(ListRevisionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Revision][google.cloud.config.v1.Revision]s of a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Revisions are listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
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
        /// <returns>A pageable sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRevisionsResponse, Revision> ListRevisions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRevisionsRequest request = new ListRevisionsRequest
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
            return ListRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists [Revision][google.cloud.config.v1.Revision]s of a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Revisions are listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRevisionsResponse, Revision> ListRevisionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRevisionsRequest request = new ListRevisionsRequest
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
            return ListRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Revision][google.cloud.config.v1.Revision]s of a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Revisions are listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
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
        /// <returns>A pageable sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListRevisionsResponse, Revision> ListRevisions(DeploymentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRevisionsRequest request = new ListRevisionsRequest
            {
                ParentAsDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRevisions(request, callSettings);
        }

        /// <summary>
        /// Lists [Revision][google.cloud.config.v1.Revision]s of a deployment.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Revisions are listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Revision"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListRevisionsResponse, Revision> ListRevisionsAsync(DeploymentName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListRevisionsRequest request = new ListRevisionsRequest
            {
                ParentAsDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListRevisionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Revision GetRevision(GetRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(GetRevisionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(GetRevisionRequest request, st::CancellationToken cancellationToken) =>
            GetRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Revision GetRevision(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRevision(new GetRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetRevisionAsync(new GetRevisionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(string name, st::CancellationToken cancellationToken) =>
            GetRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Revision GetRevision(RevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRevision(new GetRevisionRequest
            {
                RevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(RevisionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetRevisionAsync(new GetRevisionRequest
            {
                RevisionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Revision in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Revision> GetRevisionAsync(RevisionName name, st::CancellationToken cancellationToken) =>
            GetRevisionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Resource GetResource(GetResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Resource> GetResourceAsync(GetResourceRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Resource> GetResourceAsync(GetResourceRequest request, st::CancellationToken cancellationToken) =>
            GetResourceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Resource in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}/resource/{resource}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Resource GetResource(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResource(new GetResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Resource in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}/resource/{resource}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Resource> GetResourceAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceAsync(new GetResourceRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Resource in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}/resource/{resource}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Resource> GetResourceAsync(string name, st::CancellationToken cancellationToken) =>
            GetResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Resource in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}/resource/{resource}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Resource GetResource(ResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResource(new GetResourceRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Resource in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}/resource/{resource}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Resource> GetResourceAsync(ResourceName name, gaxgrpc::CallSettings callSettings = null) =>
            GetResourceAsync(new GetResourceRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Resource in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}/resource/{resource}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Resource> GetResourceAsync(ResourceName name, st::CancellationToken cancellationToken) =>
            GetResourceAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Resources][google.cloud.config.v1.Resource] in a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Resource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourcesResponse, Resource> ListResources(ListResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Resources][google.cloud.config.v1.Resource] in a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Resource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourcesResponse, Resource> ListResourcesAsync(ListResourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Resources][google.cloud.config.v1.Resource] in a given revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Resources are listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
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
        /// <returns>A pageable sequence of <see cref="Resource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourcesResponse, Resource> ListResources(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourcesRequest request = new ListResourcesRequest
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
            return ListResources(request, callSettings);
        }

        /// <summary>
        /// Lists [Resources][google.cloud.config.v1.Resource] in a given revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Resources are listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Resource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourcesResponse, Resource> ListResourcesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourcesRequest request = new ListResourcesRequest
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
            return ListResourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Resources][google.cloud.config.v1.Resource] in a given revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Resources are listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
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
        /// <returns>A pageable sequence of <see cref="Resource"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListResourcesResponse, Resource> ListResources(RevisionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourcesRequest request = new ListResourcesRequest
            {
                ParentAsRevisionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResources(request, callSettings);
        }

        /// <summary>
        /// Lists [Resources][google.cloud.config.v1.Resource] in a given revision.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Resources are listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}/revisions/{revision}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Resource"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListResourcesResponse, Resource> ListResourcesAsync(RevisionName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListResourcesRequest request = new ListResourcesRequest
            {
                ParentAsRevisionName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListResourcesAsync(request, callSettings);
        }

        /// <summary>
        /// Exports Terraform state file from a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Statefile ExportDeploymentStatefile(ExportDeploymentStatefileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform state file from a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ExportDeploymentStatefileAsync(ExportDeploymentStatefileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform state file from a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ExportDeploymentStatefileAsync(ExportDeploymentStatefileRequest request, st::CancellationToken cancellationToken) =>
            ExportDeploymentStatefileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports Terraform state file from a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Statefile ExportRevisionStatefile(ExportRevisionStatefileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform state file from a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ExportRevisionStatefileAsync(ExportRevisionStatefileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports Terraform state file from a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ExportRevisionStatefileAsync(ExportRevisionStatefileRequest request, st::CancellationToken cancellationToken) =>
            ExportRevisionStatefileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Statefile ImportStatefile(ImportStatefileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ImportStatefileAsync(ImportStatefileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ImportStatefileAsync(ImportStatefileRequest request, st::CancellationToken cancellationToken) =>
            ImportStatefileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the statefile is listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to verify that the user who is importing
        /// the state file previously locked the Deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Statefile ImportStatefile(string parent, long lockId, gaxgrpc::CallSettings callSettings = null) =>
            ImportStatefile(new ImportStatefileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LockId = lockId,
            }, callSettings);

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the statefile is listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to verify that the user who is importing
        /// the state file previously locked the Deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ImportStatefileAsync(string parent, long lockId, gaxgrpc::CallSettings callSettings = null) =>
            ImportStatefileAsync(new ImportStatefileRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                LockId = lockId,
            }, callSettings);

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the statefile is listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to verify that the user who is importing
        /// the state file previously locked the Deployment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ImportStatefileAsync(string parent, long lockId, st::CancellationToken cancellationToken) =>
            ImportStatefileAsync(parent, lockId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the statefile is listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to verify that the user who is importing
        /// the state file previously locked the Deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Statefile ImportStatefile(DeploymentName parent, long lockId, gaxgrpc::CallSettings callSettings = null) =>
            ImportStatefile(new ImportStatefileRequest
            {
                ParentAsDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LockId = lockId,
            }, callSettings);

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the statefile is listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to verify that the user who is importing
        /// the state file previously locked the Deployment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ImportStatefileAsync(DeploymentName parent, long lockId, gaxgrpc::CallSettings callSettings = null) =>
            ImportStatefileAsync(new ImportStatefileRequest
            {
                ParentAsDeploymentName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                LockId = lockId,
            }, callSettings);

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the statefile is listed. The parent
        /// value is in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to verify that the user who is importing
        /// the state file previously locked the Deployment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Statefile> ImportStatefileAsync(DeploymentName parent, long lockId, st::CancellationToken cancellationToken) =>
            ImportStatefileAsync(parent, lockId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStatefile(DeleteStatefileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStatefileAsync(DeleteStatefileRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStatefileAsync(DeleteStatefileRequest request, st::CancellationToken cancellationToken) =>
            DeleteStatefileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStatefile(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStatefile(new DeleteStatefileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStatefileAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStatefileAsync(new DeleteStatefileRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStatefileAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteStatefileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void DeleteStatefile(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStatefile(new DeleteStatefileRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStatefileAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteStatefileAsync(new DeleteStatefileRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task DeleteStatefileAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            DeleteStatefileAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> LockDeployment(LockDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> LockDeploymentAsync(LockDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> LockDeploymentAsync(LockDeploymentRequest request, st::CancellationToken cancellationToken) =>
            LockDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>LockDeployment</c>.</summary>
        public virtual lro::OperationsClient LockDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>LockDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> PollOnceLockDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LockDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>LockDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> PollOnceLockDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), LockDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> LockDeployment(string name, gaxgrpc::CallSettings callSettings = null) =>
            LockDeployment(new LockDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> LockDeploymentAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            LockDeploymentAsync(new LockDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> LockDeploymentAsync(string name, st::CancellationToken cancellationToken) =>
            LockDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> LockDeployment(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            LockDeployment(new LockDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> LockDeploymentAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            LockDeploymentAsync(new LockDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> LockDeploymentAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            LockDeploymentAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> UnlockDeployment(UnlockDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UnlockDeploymentAsync(UnlockDeploymentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UnlockDeploymentAsync(UnlockDeploymentRequest request, st::CancellationToken cancellationToken) =>
            UnlockDeploymentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UnlockDeployment</c>.</summary>
        public virtual lro::OperationsClient UnlockDeploymentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UnlockDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> PollOnceUnlockDeployment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UnlockDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UnlockDeployment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> PollOnceUnlockDeploymentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Deployment, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UnlockDeploymentOperationsClient, callSettings);

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to be unlocked.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> UnlockDeployment(string name, long lockId, gaxgrpc::CallSettings callSettings = null) =>
            UnlockDeployment(new UnlockDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                LockId = lockId,
            }, callSettings);

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to be unlocked.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UnlockDeploymentAsync(string name, long lockId, gaxgrpc::CallSettings callSettings = null) =>
            UnlockDeploymentAsync(new UnlockDeploymentRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
                LockId = lockId,
            }, callSettings);

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to be unlocked.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UnlockDeploymentAsync(string name, long lockId, st::CancellationToken cancellationToken) =>
            UnlockDeploymentAsync(name, lockId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to be unlocked.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Deployment, OperationMetadata> UnlockDeployment(DeploymentName name, long lockId, gaxgrpc::CallSettings callSettings = null) =>
            UnlockDeployment(new UnlockDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                LockId = lockId,
            }, callSettings);

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to be unlocked.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UnlockDeploymentAsync(DeploymentName name, long lockId, gaxgrpc::CallSettings callSettings = null) =>
            UnlockDeploymentAsync(new UnlockDeploymentRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
                LockId = lockId,
            }, callSettings);

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="lockId">
        /// Required. Lock ID of the lock file to be unlocked.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Deployment, OperationMetadata>> UnlockDeploymentAsync(DeploymentName name, long lockId, st::CancellationToken cancellationToken) =>
            UnlockDeploymentAsync(name, lockId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LockInfo ExportLockInfo(ExportLockInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LockInfo> ExportLockInfoAsync(ExportLockInfoRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LockInfo> ExportLockInfoAsync(ExportLockInfoRequest request, st::CancellationToken cancellationToken) =>
            ExportLockInfoAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LockInfo ExportLockInfo(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportLockInfo(new ExportLockInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LockInfo> ExportLockInfoAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ExportLockInfoAsync(new ExportLockInfoRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LockInfo> ExportLockInfoAsync(string name, st::CancellationToken cancellationToken) =>
            ExportLockInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual LockInfo ExportLockInfo(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportLockInfo(new ExportLockInfoRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LockInfo> ExportLockInfoAsync(DeploymentName name, gaxgrpc::CallSettings callSettings = null) =>
            ExportLockInfoAsync(new ExportLockInfoRequest
            {
                DeploymentName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="name">
        /// Required. The name of the deployment in the format:
        /// 'projects/{project_id}/locations/{location}/deployments/{deployment}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<LockInfo> ExportLockInfoAsync(DeploymentName name, st::CancellationToken cancellationToken) =>
            ExportLockInfoAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Preview, OperationMetadata> CreatePreview(CreatePreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> CreatePreviewAsync(CreatePreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> CreatePreviewAsync(CreatePreviewRequest request, st::CancellationToken cancellationToken) =>
            CreatePreviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreatePreview</c>.</summary>
        public virtual lro::OperationsClient CreatePreviewOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreatePreview</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Preview, OperationMetadata> PollOnceCreatePreview(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Preview, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePreviewOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreatePreview</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> PollOnceCreatePreviewAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Preview, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreatePreviewOperationsClient, callSettings);

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Preview is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="preview">
        /// Required. [Preview][google.cloud.config.v1.Preview] resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Preview, OperationMetadata> CreatePreview(string parent, Preview preview, gaxgrpc::CallSettings callSettings = null) =>
            CreatePreview(new CreatePreviewRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Preview = gax::GaxPreconditions.CheckNotNull(preview, nameof(preview)),
            }, callSettings);

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Preview is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="preview">
        /// Required. [Preview][google.cloud.config.v1.Preview] resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> CreatePreviewAsync(string parent, Preview preview, gaxgrpc::CallSettings callSettings = null) =>
            CreatePreviewAsync(new CreatePreviewRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                Preview = gax::GaxPreconditions.CheckNotNull(preview, nameof(preview)),
            }, callSettings);

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Preview is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="preview">
        /// Required. [Preview][google.cloud.config.v1.Preview] resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> CreatePreviewAsync(string parent, Preview preview, st::CancellationToken cancellationToken) =>
            CreatePreviewAsync(parent, preview, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Preview is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="preview">
        /// Required. [Preview][google.cloud.config.v1.Preview] resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Preview, OperationMetadata> CreatePreview(gagr::LocationName parent, Preview preview, gaxgrpc::CallSettings callSettings = null) =>
            CreatePreview(new CreatePreviewRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Preview = gax::GaxPreconditions.CheckNotNull(preview, nameof(preview)),
            }, callSettings);

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Preview is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="preview">
        /// Required. [Preview][google.cloud.config.v1.Preview] resource to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> CreatePreviewAsync(gagr::LocationName parent, Preview preview, gaxgrpc::CallSettings callSettings = null) =>
            CreatePreviewAsync(new CreatePreviewRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                Preview = gax::GaxPreconditions.CheckNotNull(preview, nameof(preview)),
            }, callSettings);

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Preview is created. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
        /// </param>
        /// <param name="preview">
        /// Required. [Preview][google.cloud.config.v1.Preview] resource to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> CreatePreviewAsync(gagr::LocationName parent, Preview preview, st::CancellationToken cancellationToken) =>
            CreatePreviewAsync(parent, preview, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Preview GetPreview(GetPreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Preview> GetPreviewAsync(GetPreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Preview> GetPreviewAsync(GetPreviewRequest request, st::CancellationToken cancellationToken) =>
            GetPreviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the preview. Format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Preview GetPreview(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPreview(new GetPreviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the preview. Format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Preview> GetPreviewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetPreviewAsync(new GetPreviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the preview. Format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Preview> GetPreviewAsync(string name, st::CancellationToken cancellationToken) =>
            GetPreviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the preview. Format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Preview GetPreview(PreviewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPreview(new GetPreviewRequest
            {
                PreviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the preview. Format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Preview> GetPreviewAsync(PreviewName name, gaxgrpc::CallSettings callSettings = null) =>
            GetPreviewAsync(new GetPreviewRequest
            {
                PreviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the preview. Format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Preview> GetPreviewAsync(PreviewName name, st::CancellationToken cancellationToken) =>
            GetPreviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Preview][google.cloud.config.v1.Preview]s in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Preview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPreviewsResponse, Preview> ListPreviews(ListPreviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Preview][google.cloud.config.v1.Preview]s in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Preview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPreviewsResponse, Preview> ListPreviewsAsync(ListPreviewsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Preview][google.cloud.config.v1.Preview]s in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Previews are listed. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable sequence of <see cref="Preview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPreviewsResponse, Preview> ListPreviews(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPreviewsRequest request = new ListPreviewsRequest
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
            return ListPreviews(request, callSettings);
        }

        /// <summary>
        /// Lists [Preview][google.cloud.config.v1.Preview]s in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Previews are listed. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Preview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPreviewsResponse, Preview> ListPreviewsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPreviewsRequest request = new ListPreviewsRequest
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
            return ListPreviewsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Preview][google.cloud.config.v1.Preview]s in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Previews are listed. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable sequence of <see cref="Preview"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListPreviewsResponse, Preview> ListPreviews(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPreviewsRequest request = new ListPreviewsRequest
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
            return ListPreviews(request, callSettings);
        }

        /// <summary>
        /// Lists [Preview][google.cloud.config.v1.Preview]s in a given project and
        /// location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the Previews are listed. The parent
        /// value is in the format: 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Preview"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListPreviewsResponse, Preview> ListPreviewsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListPreviewsRequest request = new ListPreviewsRequest
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
            return ListPreviewsAsync(request, callSettings);
        }

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Preview, OperationMetadata> DeletePreview(DeletePreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> DeletePreviewAsync(DeletePreviewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> DeletePreviewAsync(DeletePreviewRequest request, st::CancellationToken cancellationToken) =>
            DeletePreviewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeletePreview</c>.</summary>
        public virtual lro::OperationsClient DeletePreviewOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeletePreview</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<Preview, OperationMetadata> PollOnceDeletePreview(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Preview, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePreviewOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeletePreview</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> PollOnceDeletePreviewAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<Preview, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeletePreviewOperationsClient, callSettings);

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Preview in the format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Preview, OperationMetadata> DeletePreview(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePreview(new DeletePreviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Preview in the format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> DeletePreviewAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePreviewAsync(new DeletePreviewRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Preview in the format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> DeletePreviewAsync(string name, st::CancellationToken cancellationToken) =>
            DeletePreviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Preview in the format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<Preview, OperationMetadata> DeletePreview(PreviewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePreview(new DeletePreviewRequest
            {
                PreviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Preview in the format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> DeletePreviewAsync(PreviewName name, gaxgrpc::CallSettings callSettings = null) =>
            DeletePreviewAsync(new DeletePreviewRequest
            {
                PreviewName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the Preview in the format:
        /// 'projects/{project_id}/locations/{location}/previews/{preview}'.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<Preview, OperationMetadata>> DeletePreviewAsync(PreviewName name, st::CancellationToken cancellationToken) =>
            DeletePreviewAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Export [Preview][google.cloud.config.v1.Preview] results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ExportPreviewResultResponse ExportPreviewResult(ExportPreviewResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export [Preview][google.cloud.config.v1.Preview] results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportPreviewResultResponse> ExportPreviewResultAsync(ExportPreviewResultRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Export [Preview][google.cloud.config.v1.Preview] results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ExportPreviewResultResponse> ExportPreviewResultAsync(ExportPreviewResultRequest request, st::CancellationToken cancellationToken) =>
            ExportPreviewResultAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [TerraformVersion][google.cloud.config.v1.TerraformVersion]s in a
        /// given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TerraformVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTerraformVersionsResponse, TerraformVersion> ListTerraformVersions(ListTerraformVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [TerraformVersion][google.cloud.config.v1.TerraformVersion]s in a
        /// given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TerraformVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTerraformVersionsResponse, TerraformVersion> ListTerraformVersionsAsync(ListTerraformVersionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [TerraformVersion][google.cloud.config.v1.TerraformVersion]s in a
        /// given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the TerraformVersions are listed. The
        /// parent value is in the format:
        /// 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable sequence of <see cref="TerraformVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTerraformVersionsResponse, TerraformVersion> ListTerraformVersions(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTerraformVersionsRequest request = new ListTerraformVersionsRequest
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
            return ListTerraformVersions(request, callSettings);
        }

        /// <summary>
        /// Lists [TerraformVersion][google.cloud.config.v1.TerraformVersion]s in a
        /// given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the TerraformVersions are listed. The
        /// parent value is in the format:
        /// 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TerraformVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTerraformVersionsResponse, TerraformVersion> ListTerraformVersionsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTerraformVersionsRequest request = new ListTerraformVersionsRequest
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
            return ListTerraformVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [TerraformVersion][google.cloud.config.v1.TerraformVersion]s in a
        /// given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the TerraformVersions are listed. The
        /// parent value is in the format:
        /// 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable sequence of <see cref="TerraformVersion"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListTerraformVersionsResponse, TerraformVersion> ListTerraformVersions(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTerraformVersionsRequest request = new ListTerraformVersionsRequest
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
            return ListTerraformVersions(request, callSettings);
        }

        /// <summary>
        /// Lists [TerraformVersion][google.cloud.config.v1.TerraformVersion]s in a
        /// given project and location.
        /// </summary>
        /// <param name="parent">
        /// Required. The parent in whose context the TerraformVersions are listed. The
        /// parent value is in the format:
        /// 'projects/{project_id}/locations/{location}'.
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
        /// <returns>A pageable asynchronous sequence of <see cref="TerraformVersion"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListTerraformVersionsResponse, TerraformVersion> ListTerraformVersionsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListTerraformVersionsRequest request = new ListTerraformVersionsRequest
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
            return ListTerraformVersionsAsync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TerraformVersion GetTerraformVersion(GetTerraformVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerraformVersion> GetTerraformVersionAsync(GetTerraformVersionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerraformVersion> GetTerraformVersionAsync(GetTerraformVersionRequest request, st::CancellationToken cancellationToken) =>
            GetTerraformVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TerraformVersion. Format:
        /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TerraformVersion GetTerraformVersion(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTerraformVersion(new GetTerraformVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TerraformVersion. Format:
        /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerraformVersion> GetTerraformVersionAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetTerraformVersionAsync(new GetTerraformVersionRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TerraformVersion. Format:
        /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerraformVersion> GetTerraformVersionAsync(string name, st::CancellationToken cancellationToken) =>
            GetTerraformVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TerraformVersion. Format:
        /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual TerraformVersion GetTerraformVersion(TerraformVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTerraformVersion(new GetTerraformVersionRequest
            {
                TerraformVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TerraformVersion. Format:
        /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerraformVersion> GetTerraformVersionAsync(TerraformVersionName name, gaxgrpc::CallSettings callSettings = null) =>
            GetTerraformVersionAsync(new GetTerraformVersionRequest
            {
                TerraformVersionName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="name">
        /// Required. The name of the TerraformVersion. Format:
        /// 'projects/{project_id}/locations/{location}/terraformVersions/{terraform_version}'
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<TerraformVersion> GetTerraformVersionAsync(TerraformVersionName name, st::CancellationToken cancellationToken) =>
            GetTerraformVersionAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>Config client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Infrastructure Manager is a managed service that automates the deployment and
    /// management of Google Cloud infrastructure resources.
    /// </remarks>
    public sealed partial class ConfigClientImpl : ConfigClient
    {
        private readonly gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> _callListDeployments;

        private readonly gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> _callGetDeployment;

        private readonly gaxgrpc::ApiCall<CreateDeploymentRequest, lro::Operation> _callCreateDeployment;

        private readonly gaxgrpc::ApiCall<UpdateDeploymentRequest, lro::Operation> _callUpdateDeployment;

        private readonly gaxgrpc::ApiCall<DeleteDeploymentRequest, lro::Operation> _callDeleteDeployment;

        private readonly gaxgrpc::ApiCall<ListRevisionsRequest, ListRevisionsResponse> _callListRevisions;

        private readonly gaxgrpc::ApiCall<GetRevisionRequest, Revision> _callGetRevision;

        private readonly gaxgrpc::ApiCall<GetResourceRequest, Resource> _callGetResource;

        private readonly gaxgrpc::ApiCall<ListResourcesRequest, ListResourcesResponse> _callListResources;

        private readonly gaxgrpc::ApiCall<ExportDeploymentStatefileRequest, Statefile> _callExportDeploymentStatefile;

        private readonly gaxgrpc::ApiCall<ExportRevisionStatefileRequest, Statefile> _callExportRevisionStatefile;

        private readonly gaxgrpc::ApiCall<ImportStatefileRequest, Statefile> _callImportStatefile;

        private readonly gaxgrpc::ApiCall<DeleteStatefileRequest, wkt::Empty> _callDeleteStatefile;

        private readonly gaxgrpc::ApiCall<LockDeploymentRequest, lro::Operation> _callLockDeployment;

        private readonly gaxgrpc::ApiCall<UnlockDeploymentRequest, lro::Operation> _callUnlockDeployment;

        private readonly gaxgrpc::ApiCall<ExportLockInfoRequest, LockInfo> _callExportLockInfo;

        private readonly gaxgrpc::ApiCall<CreatePreviewRequest, lro::Operation> _callCreatePreview;

        private readonly gaxgrpc::ApiCall<GetPreviewRequest, Preview> _callGetPreview;

        private readonly gaxgrpc::ApiCall<ListPreviewsRequest, ListPreviewsResponse> _callListPreviews;

        private readonly gaxgrpc::ApiCall<DeletePreviewRequest, lro::Operation> _callDeletePreview;

        private readonly gaxgrpc::ApiCall<ExportPreviewResultRequest, ExportPreviewResultResponse> _callExportPreviewResult;

        private readonly gaxgrpc::ApiCall<ListTerraformVersionsRequest, ListTerraformVersionsResponse> _callListTerraformVersions;

        private readonly gaxgrpc::ApiCall<GetTerraformVersionRequest, TerraformVersion> _callGetTerraformVersion;

        /// <summary>
        /// Constructs a client wrapper for the Config service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConfigSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConfigClientImpl(Config.ConfigClient grpcClient, ConfigSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConfigSettings effectiveSettings = settings ?? ConfigSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            CreateDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateDeploymentOperationsSettings, logger);
            UpdateDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateDeploymentOperationsSettings, logger);
            DeleteDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteDeploymentOperationsSettings, logger);
            LockDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.LockDeploymentOperationsSettings, logger);
            UnlockDeploymentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UnlockDeploymentOperationsSettings, logger);
            CreatePreviewOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreatePreviewOperationsSettings, logger);
            DeletePreviewOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeletePreviewOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
            _callListDeployments = clientHelper.BuildApiCall<ListDeploymentsRequest, ListDeploymentsResponse>("ListDeployments", grpcClient.ListDeploymentsAsync, grpcClient.ListDeployments, effectiveSettings.ListDeploymentsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListDeployments);
            Modify_ListDeploymentsApiCall(ref _callListDeployments);
            _callGetDeployment = clientHelper.BuildApiCall<GetDeploymentRequest, Deployment>("GetDeployment", grpcClient.GetDeploymentAsync, grpcClient.GetDeployment, effectiveSettings.GetDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetDeployment);
            Modify_GetDeploymentApiCall(ref _callGetDeployment);
            _callCreateDeployment = clientHelper.BuildApiCall<CreateDeploymentRequest, lro::Operation>("CreateDeployment", grpcClient.CreateDeploymentAsync, grpcClient.CreateDeployment, effectiveSettings.CreateDeploymentSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateDeployment);
            Modify_CreateDeploymentApiCall(ref _callCreateDeployment);
            _callUpdateDeployment = clientHelper.BuildApiCall<UpdateDeploymentRequest, lro::Operation>("UpdateDeployment", grpcClient.UpdateDeploymentAsync, grpcClient.UpdateDeployment, effectiveSettings.UpdateDeploymentSettings).WithGoogleRequestParam("deployment.name", request => request.Deployment?.Name);
            Modify_ApiCall(ref _callUpdateDeployment);
            Modify_UpdateDeploymentApiCall(ref _callUpdateDeployment);
            _callDeleteDeployment = clientHelper.BuildApiCall<DeleteDeploymentRequest, lro::Operation>("DeleteDeployment", grpcClient.DeleteDeploymentAsync, grpcClient.DeleteDeployment, effectiveSettings.DeleteDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteDeployment);
            Modify_DeleteDeploymentApiCall(ref _callDeleteDeployment);
            _callListRevisions = clientHelper.BuildApiCall<ListRevisionsRequest, ListRevisionsResponse>("ListRevisions", grpcClient.ListRevisionsAsync, grpcClient.ListRevisions, effectiveSettings.ListRevisionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListRevisions);
            Modify_ListRevisionsApiCall(ref _callListRevisions);
            _callGetRevision = clientHelper.BuildApiCall<GetRevisionRequest, Revision>("GetRevision", grpcClient.GetRevisionAsync, grpcClient.GetRevision, effectiveSettings.GetRevisionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetRevision);
            Modify_GetRevisionApiCall(ref _callGetRevision);
            _callGetResource = clientHelper.BuildApiCall<GetResourceRequest, Resource>("GetResource", grpcClient.GetResourceAsync, grpcClient.GetResource, effectiveSettings.GetResourceSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetResource);
            Modify_GetResourceApiCall(ref _callGetResource);
            _callListResources = clientHelper.BuildApiCall<ListResourcesRequest, ListResourcesResponse>("ListResources", grpcClient.ListResourcesAsync, grpcClient.ListResources, effectiveSettings.ListResourcesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListResources);
            Modify_ListResourcesApiCall(ref _callListResources);
            _callExportDeploymentStatefile = clientHelper.BuildApiCall<ExportDeploymentStatefileRequest, Statefile>("ExportDeploymentStatefile", grpcClient.ExportDeploymentStatefileAsync, grpcClient.ExportDeploymentStatefile, effectiveSettings.ExportDeploymentStatefileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportDeploymentStatefile);
            Modify_ExportDeploymentStatefileApiCall(ref _callExportDeploymentStatefile);
            _callExportRevisionStatefile = clientHelper.BuildApiCall<ExportRevisionStatefileRequest, Statefile>("ExportRevisionStatefile", grpcClient.ExportRevisionStatefileAsync, grpcClient.ExportRevisionStatefile, effectiveSettings.ExportRevisionStatefileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportRevisionStatefile);
            Modify_ExportRevisionStatefileApiCall(ref _callExportRevisionStatefile);
            _callImportStatefile = clientHelper.BuildApiCall<ImportStatefileRequest, Statefile>("ImportStatefile", grpcClient.ImportStatefileAsync, grpcClient.ImportStatefile, effectiveSettings.ImportStatefileSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callImportStatefile);
            Modify_ImportStatefileApiCall(ref _callImportStatefile);
            _callDeleteStatefile = clientHelper.BuildApiCall<DeleteStatefileRequest, wkt::Empty>("DeleteStatefile", grpcClient.DeleteStatefileAsync, grpcClient.DeleteStatefile, effectiveSettings.DeleteStatefileSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteStatefile);
            Modify_DeleteStatefileApiCall(ref _callDeleteStatefile);
            _callLockDeployment = clientHelper.BuildApiCall<LockDeploymentRequest, lro::Operation>("LockDeployment", grpcClient.LockDeploymentAsync, grpcClient.LockDeployment, effectiveSettings.LockDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callLockDeployment);
            Modify_LockDeploymentApiCall(ref _callLockDeployment);
            _callUnlockDeployment = clientHelper.BuildApiCall<UnlockDeploymentRequest, lro::Operation>("UnlockDeployment", grpcClient.UnlockDeploymentAsync, grpcClient.UnlockDeployment, effectiveSettings.UnlockDeploymentSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUnlockDeployment);
            Modify_UnlockDeploymentApiCall(ref _callUnlockDeployment);
            _callExportLockInfo = clientHelper.BuildApiCall<ExportLockInfoRequest, LockInfo>("ExportLockInfo", grpcClient.ExportLockInfoAsync, grpcClient.ExportLockInfo, effectiveSettings.ExportLockInfoSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callExportLockInfo);
            Modify_ExportLockInfoApiCall(ref _callExportLockInfo);
            _callCreatePreview = clientHelper.BuildApiCall<CreatePreviewRequest, lro::Operation>("CreatePreview", grpcClient.CreatePreviewAsync, grpcClient.CreatePreview, effectiveSettings.CreatePreviewSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreatePreview);
            Modify_CreatePreviewApiCall(ref _callCreatePreview);
            _callGetPreview = clientHelper.BuildApiCall<GetPreviewRequest, Preview>("GetPreview", grpcClient.GetPreviewAsync, grpcClient.GetPreview, effectiveSettings.GetPreviewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetPreview);
            Modify_GetPreviewApiCall(ref _callGetPreview);
            _callListPreviews = clientHelper.BuildApiCall<ListPreviewsRequest, ListPreviewsResponse>("ListPreviews", grpcClient.ListPreviewsAsync, grpcClient.ListPreviews, effectiveSettings.ListPreviewsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListPreviews);
            Modify_ListPreviewsApiCall(ref _callListPreviews);
            _callDeletePreview = clientHelper.BuildApiCall<DeletePreviewRequest, lro::Operation>("DeletePreview", grpcClient.DeletePreviewAsync, grpcClient.DeletePreview, effectiveSettings.DeletePreviewSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeletePreview);
            Modify_DeletePreviewApiCall(ref _callDeletePreview);
            _callExportPreviewResult = clientHelper.BuildApiCall<ExportPreviewResultRequest, ExportPreviewResultResponse>("ExportPreviewResult", grpcClient.ExportPreviewResultAsync, grpcClient.ExportPreviewResult, effectiveSettings.ExportPreviewResultSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callExportPreviewResult);
            Modify_ExportPreviewResultApiCall(ref _callExportPreviewResult);
            _callListTerraformVersions = clientHelper.BuildApiCall<ListTerraformVersionsRequest, ListTerraformVersionsResponse>("ListTerraformVersions", grpcClient.ListTerraformVersionsAsync, grpcClient.ListTerraformVersions, effectiveSettings.ListTerraformVersionsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListTerraformVersions);
            Modify_ListTerraformVersionsApiCall(ref _callListTerraformVersions);
            _callGetTerraformVersion = clientHelper.BuildApiCall<GetTerraformVersionRequest, TerraformVersion>("GetTerraformVersion", grpcClient.GetTerraformVersionAsync, grpcClient.GetTerraformVersion, effectiveSettings.GetTerraformVersionSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetTerraformVersion);
            Modify_GetTerraformVersionApiCall(ref _callGetTerraformVersion);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListDeploymentsApiCall(ref gaxgrpc::ApiCall<ListDeploymentsRequest, ListDeploymentsResponse> call);

        partial void Modify_GetDeploymentApiCall(ref gaxgrpc::ApiCall<GetDeploymentRequest, Deployment> call);

        partial void Modify_CreateDeploymentApiCall(ref gaxgrpc::ApiCall<CreateDeploymentRequest, lro::Operation> call);

        partial void Modify_UpdateDeploymentApiCall(ref gaxgrpc::ApiCall<UpdateDeploymentRequest, lro::Operation> call);

        partial void Modify_DeleteDeploymentApiCall(ref gaxgrpc::ApiCall<DeleteDeploymentRequest, lro::Operation> call);

        partial void Modify_ListRevisionsApiCall(ref gaxgrpc::ApiCall<ListRevisionsRequest, ListRevisionsResponse> call);

        partial void Modify_GetRevisionApiCall(ref gaxgrpc::ApiCall<GetRevisionRequest, Revision> call);

        partial void Modify_GetResourceApiCall(ref gaxgrpc::ApiCall<GetResourceRequest, Resource> call);

        partial void Modify_ListResourcesApiCall(ref gaxgrpc::ApiCall<ListResourcesRequest, ListResourcesResponse> call);

        partial void Modify_ExportDeploymentStatefileApiCall(ref gaxgrpc::ApiCall<ExportDeploymentStatefileRequest, Statefile> call);

        partial void Modify_ExportRevisionStatefileApiCall(ref gaxgrpc::ApiCall<ExportRevisionStatefileRequest, Statefile> call);

        partial void Modify_ImportStatefileApiCall(ref gaxgrpc::ApiCall<ImportStatefileRequest, Statefile> call);

        partial void Modify_DeleteStatefileApiCall(ref gaxgrpc::ApiCall<DeleteStatefileRequest, wkt::Empty> call);

        partial void Modify_LockDeploymentApiCall(ref gaxgrpc::ApiCall<LockDeploymentRequest, lro::Operation> call);

        partial void Modify_UnlockDeploymentApiCall(ref gaxgrpc::ApiCall<UnlockDeploymentRequest, lro::Operation> call);

        partial void Modify_ExportLockInfoApiCall(ref gaxgrpc::ApiCall<ExportLockInfoRequest, LockInfo> call);

        partial void Modify_CreatePreviewApiCall(ref gaxgrpc::ApiCall<CreatePreviewRequest, lro::Operation> call);

        partial void Modify_GetPreviewApiCall(ref gaxgrpc::ApiCall<GetPreviewRequest, Preview> call);

        partial void Modify_ListPreviewsApiCall(ref gaxgrpc::ApiCall<ListPreviewsRequest, ListPreviewsResponse> call);

        partial void Modify_DeletePreviewApiCall(ref gaxgrpc::ApiCall<DeletePreviewRequest, lro::Operation> call);

        partial void Modify_ExportPreviewResultApiCall(ref gaxgrpc::ApiCall<ExportPreviewResultRequest, ExportPreviewResultResponse> call);

        partial void Modify_ListTerraformVersionsApiCall(ref gaxgrpc::ApiCall<ListTerraformVersionsRequest, ListTerraformVersionsResponse> call);

        partial void Modify_GetTerraformVersionApiCall(ref gaxgrpc::ApiCall<GetTerraformVersionRequest, TerraformVersion> call);

        partial void OnConstruction(Config.ConfigClient grpcClient, ConfigSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC Config client</summary>
        public override Config.ConfigClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

        partial void Modify_ListDeploymentsRequest(ref ListDeploymentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetDeploymentRequest(ref GetDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateDeploymentRequest(ref CreateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateDeploymentRequest(ref UpdateDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteDeploymentRequest(ref DeleteDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListRevisionsRequest(ref ListRevisionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetRevisionRequest(ref GetRevisionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetResourceRequest(ref GetResourceRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListResourcesRequest(ref ListResourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportDeploymentStatefileRequest(ref ExportDeploymentStatefileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportRevisionStatefileRequest(ref ExportRevisionStatefileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ImportStatefileRequest(ref ImportStatefileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteStatefileRequest(ref DeleteStatefileRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_LockDeploymentRequest(ref LockDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UnlockDeploymentRequest(ref UnlockDeploymentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportLockInfoRequest(ref ExportLockInfoRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreatePreviewRequest(ref CreatePreviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetPreviewRequest(ref GetPreviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPreviewsRequest(ref ListPreviewsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeletePreviewRequest(ref DeletePreviewRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ExportPreviewResultRequest(ref ExportPreviewResultRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListTerraformVersionsRequest(ref ListTerraformVersionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetTerraformVersionRequest(ref GetTerraformVersionRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Lists [Deployment][google.cloud.config.v1.Deployment]s in a given project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedEnumerable<ListDeploymentsResponse, Deployment> ListDeployments(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// Lists [Deployment][google.cloud.config.v1.Deployment]s in a given project
        /// and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Deployment"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListDeploymentsResponse, Deployment> ListDeploymentsAsync(ListDeploymentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListDeploymentsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListDeploymentsRequest, ListDeploymentsResponse, Deployment>(_callListDeployments, request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Deployment GetDeployment(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Deployment> GetDeploymentAsync(GetDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDeploymentRequest(ref request, ref callSettings);
            return _callGetDeployment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateDeployment</c>.</summary>
        public override lro::OperationsClient CreateDeploymentOperationsClient { get; }

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Deployment, OperationMetadata> CreateDeployment(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(_callCreateDeployment.Sync(request, callSettings), CreateDeploymentOperationsClient);
        }

        /// <summary>
        /// Creates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Deployment, OperationMetadata>> CreateDeploymentAsync(CreateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(await _callCreateDeployment.Async(request, callSettings).ConfigureAwait(false), CreateDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateDeployment</c>.</summary>
        public override lro::OperationsClient UpdateDeploymentOperationsClient { get; }

        /// <summary>
        /// Updates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Deployment, OperationMetadata> UpdateDeployment(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(_callUpdateDeployment.Sync(request, callSettings), UpdateDeploymentOperationsClient);
        }

        /// <summary>
        /// Updates a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Deployment, OperationMetadata>> UpdateDeploymentAsync(UpdateDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(await _callUpdateDeployment.Async(request, callSettings).ConfigureAwait(false), UpdateDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteDeployment</c>.</summary>
        public override lro::OperationsClient DeleteDeploymentOperationsClient { get; }

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Deployment, OperationMetadata> DeleteDeployment(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(_callDeleteDeployment.Sync(request, callSettings), DeleteDeploymentOperationsClient);
        }

        /// <summary>
        /// Deletes a [Deployment][google.cloud.config.v1.Deployment].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Deployment, OperationMetadata>> DeleteDeploymentAsync(DeleteDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(await _callDeleteDeployment.Async(request, callSettings).ConfigureAwait(false), DeleteDeploymentOperationsClient);
        }

        /// <summary>
        /// Lists [Revision][google.cloud.config.v1.Revision]s of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Revision"/> resources.</returns>
        public override gax::PagedEnumerable<ListRevisionsResponse, Revision> ListRevisions(ListRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListRevisionsRequest, ListRevisionsResponse, Revision>(_callListRevisions, request, callSettings);
        }

        /// <summary>
        /// Lists [Revision][google.cloud.config.v1.Revision]s of a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Revision"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListRevisionsResponse, Revision> ListRevisionsAsync(ListRevisionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListRevisionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListRevisionsRequest, ListRevisionsResponse, Revision>(_callListRevisions, request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Revision GetRevision(GetRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRevisionRequest(ref request, ref callSettings);
            return _callGetRevision.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Revision][google.cloud.config.v1.Revision].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Revision> GetRevisionAsync(GetRevisionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRevisionRequest(ref request, ref callSettings);
            return _callGetRevision.Async(request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Resource GetResource(GetResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceRequest(ref request, ref callSettings);
            return _callGetResource.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Resource][google.cloud.config.v1.Resource] deployed
        /// by Infra Manager.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Resource> GetResourceAsync(GetResourceRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetResourceRequest(ref request, ref callSettings);
            return _callGetResource.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [Resources][google.cloud.config.v1.Resource] in a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Resource"/> resources.</returns>
        public override gax::PagedEnumerable<ListResourcesResponse, Resource> ListResources(ListResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListResourcesRequest, ListResourcesResponse, Resource>(_callListResources, request, callSettings);
        }

        /// <summary>
        /// Lists [Resources][google.cloud.config.v1.Resource] in a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Resource"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListResourcesResponse, Resource> ListResourcesAsync(ListResourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListResourcesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListResourcesRequest, ListResourcesResponse, Resource>(_callListResources, request, callSettings);
        }

        /// <summary>
        /// Exports Terraform state file from a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Statefile ExportDeploymentStatefile(ExportDeploymentStatefileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDeploymentStatefileRequest(ref request, ref callSettings);
            return _callExportDeploymentStatefile.Sync(request, callSettings);
        }

        /// <summary>
        /// Exports Terraform state file from a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Statefile> ExportDeploymentStatefileAsync(ExportDeploymentStatefileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportDeploymentStatefileRequest(ref request, ref callSettings);
            return _callExportDeploymentStatefile.Async(request, callSettings);
        }

        /// <summary>
        /// Exports Terraform state file from a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Statefile ExportRevisionStatefile(ExportRevisionStatefileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportRevisionStatefileRequest(ref request, ref callSettings);
            return _callExportRevisionStatefile.Sync(request, callSettings);
        }

        /// <summary>
        /// Exports Terraform state file from a given revision.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Statefile> ExportRevisionStatefileAsync(ExportRevisionStatefileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportRevisionStatefileRequest(ref request, ref callSettings);
            return _callExportRevisionStatefile.Async(request, callSettings);
        }

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Statefile ImportStatefile(ImportStatefileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportStatefileRequest(ref request, ref callSettings);
            return _callImportStatefile.Sync(request, callSettings);
        }

        /// <summary>
        /// Imports Terraform state file in a given deployment. The state file does not
        /// take effect until the Deployment has been unlocked.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Statefile> ImportStatefileAsync(ImportStatefileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ImportStatefileRequest(ref request, ref callSettings);
            return _callImportStatefile.Async(request, callSettings);
        }

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void DeleteStatefile(DeleteStatefileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStatefileRequest(ref request, ref callSettings);
            _callDeleteStatefile.Sync(request, callSettings);
        }

        /// <summary>
        /// Deletes Terraform state file in a given deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task DeleteStatefileAsync(DeleteStatefileRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteStatefileRequest(ref request, ref callSettings);
            return _callDeleteStatefile.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>LockDeployment</c>.</summary>
        public override lro::OperationsClient LockDeploymentOperationsClient { get; }

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Deployment, OperationMetadata> LockDeployment(LockDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LockDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(_callLockDeployment.Sync(request, callSettings), LockDeploymentOperationsClient);
        }

        /// <summary>
        /// Locks a deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Deployment, OperationMetadata>> LockDeploymentAsync(LockDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_LockDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(await _callLockDeployment.Async(request, callSettings).ConfigureAwait(false), LockDeploymentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UnlockDeployment</c>.</summary>
        public override lro::OperationsClient UnlockDeploymentOperationsClient { get; }

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Deployment, OperationMetadata> UnlockDeployment(UnlockDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnlockDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(_callUnlockDeployment.Sync(request, callSettings), UnlockDeploymentOperationsClient);
        }

        /// <summary>
        /// Unlocks a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Deployment, OperationMetadata>> UnlockDeploymentAsync(UnlockDeploymentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UnlockDeploymentRequest(ref request, ref callSettings);
            return new lro::Operation<Deployment, OperationMetadata>(await _callUnlockDeployment.Async(request, callSettings).ConfigureAwait(false), UnlockDeploymentOperationsClient);
        }

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override LockInfo ExportLockInfo(ExportLockInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportLockInfoRequest(ref request, ref callSettings);
            return _callExportLockInfo.Sync(request, callSettings);
        }

        /// <summary>
        /// Exports the lock info on a locked deployment.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<LockInfo> ExportLockInfoAsync(ExportLockInfoRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportLockInfoRequest(ref request, ref callSettings);
            return _callExportLockInfo.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreatePreview</c>.</summary>
        public override lro::OperationsClient CreatePreviewOperationsClient { get; }

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Preview, OperationMetadata> CreatePreview(CreatePreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePreviewRequest(ref request, ref callSettings);
            return new lro::Operation<Preview, OperationMetadata>(_callCreatePreview.Sync(request, callSettings), CreatePreviewOperationsClient);
        }

        /// <summary>
        /// Creates a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Preview, OperationMetadata>> CreatePreviewAsync(CreatePreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreatePreviewRequest(ref request, ref callSettings);
            return new lro::Operation<Preview, OperationMetadata>(await _callCreatePreview.Async(request, callSettings).ConfigureAwait(false), CreatePreviewOperationsClient);
        }

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Preview GetPreview(GetPreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPreviewRequest(ref request, ref callSettings);
            return _callGetPreview.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Preview> GetPreviewAsync(GetPreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetPreviewRequest(ref request, ref callSettings);
            return _callGetPreview.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [Preview][google.cloud.config.v1.Preview]s in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Preview"/> resources.</returns>
        public override gax::PagedEnumerable<ListPreviewsResponse, Preview> ListPreviews(ListPreviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPreviewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListPreviewsRequest, ListPreviewsResponse, Preview>(_callListPreviews, request, callSettings);
        }

        /// <summary>
        /// Lists [Preview][google.cloud.config.v1.Preview]s in a given project and
        /// location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Preview"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListPreviewsResponse, Preview> ListPreviewsAsync(ListPreviewsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPreviewsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListPreviewsRequest, ListPreviewsResponse, Preview>(_callListPreviews, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeletePreview</c>.</summary>
        public override lro::OperationsClient DeletePreviewOperationsClient { get; }

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<Preview, OperationMetadata> DeletePreview(DeletePreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePreviewRequest(ref request, ref callSettings);
            return new lro::Operation<Preview, OperationMetadata>(_callDeletePreview.Sync(request, callSettings), DeletePreviewOperationsClient);
        }

        /// <summary>
        /// Deletes a [Preview][google.cloud.config.v1.Preview].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<Preview, OperationMetadata>> DeletePreviewAsync(DeletePreviewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeletePreviewRequest(ref request, ref callSettings);
            return new lro::Operation<Preview, OperationMetadata>(await _callDeletePreview.Async(request, callSettings).ConfigureAwait(false), DeletePreviewOperationsClient);
        }

        /// <summary>
        /// Export [Preview][google.cloud.config.v1.Preview] results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ExportPreviewResultResponse ExportPreviewResult(ExportPreviewResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportPreviewResultRequest(ref request, ref callSettings);
            return _callExportPreviewResult.Sync(request, callSettings);
        }

        /// <summary>
        /// Export [Preview][google.cloud.config.v1.Preview] results.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ExportPreviewResultResponse> ExportPreviewResultAsync(ExportPreviewResultRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ExportPreviewResultRequest(ref request, ref callSettings);
            return _callExportPreviewResult.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [TerraformVersion][google.cloud.config.v1.TerraformVersion]s in a
        /// given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="TerraformVersion"/> resources.</returns>
        public override gax::PagedEnumerable<ListTerraformVersionsResponse, TerraformVersion> ListTerraformVersions(ListTerraformVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTerraformVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListTerraformVersionsRequest, ListTerraformVersionsResponse, TerraformVersion>(_callListTerraformVersions, request, callSettings);
        }

        /// <summary>
        /// Lists [TerraformVersion][google.cloud.config.v1.TerraformVersion]s in a
        /// given project and location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="TerraformVersion"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListTerraformVersionsResponse, TerraformVersion> ListTerraformVersionsAsync(ListTerraformVersionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListTerraformVersionsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListTerraformVersionsRequest, ListTerraformVersionsResponse, TerraformVersion>(_callListTerraformVersions, request, callSettings);
        }

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override TerraformVersion GetTerraformVersion(GetTerraformVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTerraformVersionRequest(ref request, ref callSettings);
            return _callGetTerraformVersion.Sync(request, callSettings);
        }

        /// <summary>
        /// Gets details about a
        /// [TerraformVersion][google.cloud.config.v1.TerraformVersion].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<TerraformVersion> GetTerraformVersionAsync(GetTerraformVersionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetTerraformVersionRequest(ref request, ref callSettings);
            return _callGetTerraformVersion.Async(request, callSettings);
        }
    }

    public partial class ListDeploymentsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListRevisionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListResourcesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListPreviewsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListTerraformVersionsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListDeploymentsResponse : gaxgrpc::IPageResponse<Deployment>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Deployment> GetEnumerator() => Deployments.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListRevisionsResponse : gaxgrpc::IPageResponse<Revision>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Revision> GetEnumerator() => Revisions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListResourcesResponse : gaxgrpc::IPageResponse<Resource>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Resource> GetEnumerator() => Resources.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListPreviewsResponse : gaxgrpc::IPageResponse<Preview>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Preview> GetEnumerator() => Previews.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListTerraformVersionsResponse : gaxgrpc::IPageResponse<TerraformVersion>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<TerraformVersion> GetEnumerator() => TerraformVersions.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class Config
    {
        public partial class ConfigClient
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

    public static partial class Config
    {
        public partial class ConfigClient
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
