// Copyright 2022 Google LLC
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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Cloud.Security.PrivateCA.V1Beta1
{
    /// <summary>Settings for <see cref="CertificateAuthorityServiceClient"/> instances.</summary>
    public sealed partial class CertificateAuthorityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CertificateAuthorityServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CertificateAuthorityServiceSettings"/>.</returns>
        public static CertificateAuthorityServiceSettings GetDefault() => new CertificateAuthorityServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CertificateAuthorityServiceSettings"/> object with default settings.
        /// </summary>
        public CertificateAuthorityServiceSettings()
        {
        }

        private CertificateAuthorityServiceSettings(CertificateAuthorityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateCertificateSettings = existing.CreateCertificateSettings;
            GetCertificateSettings = existing.GetCertificateSettings;
            ListCertificatesSettings = existing.ListCertificatesSettings;
            RevokeCertificateSettings = existing.RevokeCertificateSettings;
            UpdateCertificateSettings = existing.UpdateCertificateSettings;
            ActivateCertificateAuthoritySettings = existing.ActivateCertificateAuthoritySettings;
            ActivateCertificateAuthorityOperationsSettings = existing.ActivateCertificateAuthorityOperationsSettings.Clone();
            CreateCertificateAuthoritySettings = existing.CreateCertificateAuthoritySettings;
            CreateCertificateAuthorityOperationsSettings = existing.CreateCertificateAuthorityOperationsSettings.Clone();
            DisableCertificateAuthoritySettings = existing.DisableCertificateAuthoritySettings;
            DisableCertificateAuthorityOperationsSettings = existing.DisableCertificateAuthorityOperationsSettings.Clone();
            EnableCertificateAuthoritySettings = existing.EnableCertificateAuthoritySettings;
            EnableCertificateAuthorityOperationsSettings = existing.EnableCertificateAuthorityOperationsSettings.Clone();
            FetchCertificateAuthorityCsrSettings = existing.FetchCertificateAuthorityCsrSettings;
            GetCertificateAuthoritySettings = existing.GetCertificateAuthoritySettings;
            ListCertificateAuthoritiesSettings = existing.ListCertificateAuthoritiesSettings;
            RestoreCertificateAuthoritySettings = existing.RestoreCertificateAuthoritySettings;
            RestoreCertificateAuthorityOperationsSettings = existing.RestoreCertificateAuthorityOperationsSettings.Clone();
            ScheduleDeleteCertificateAuthoritySettings = existing.ScheduleDeleteCertificateAuthoritySettings;
            ScheduleDeleteCertificateAuthorityOperationsSettings = existing.ScheduleDeleteCertificateAuthorityOperationsSettings.Clone();
            UpdateCertificateAuthoritySettings = existing.UpdateCertificateAuthoritySettings;
            UpdateCertificateAuthorityOperationsSettings = existing.UpdateCertificateAuthorityOperationsSettings.Clone();
            GetCertificateRevocationListSettings = existing.GetCertificateRevocationListSettings;
            ListCertificateRevocationListsSettings = existing.ListCertificateRevocationListsSettings;
            UpdateCertificateRevocationListSettings = existing.UpdateCertificateRevocationListSettings;
            UpdateCertificateRevocationListOperationsSettings = existing.UpdateCertificateRevocationListOperationsSettings.Clone();
            GetReusableConfigSettings = existing.GetReusableConfigSettings;
            ListReusableConfigsSettings = existing.ListReusableConfigsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CertificateAuthorityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.CreateCertificate</c> and
        /// <c>CertificateAuthorityServiceClient.CreateCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.GetCertificate</c> and
        /// <c>CertificateAuthorityServiceClient.GetCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.ListCertificates</c> and
        /// <c>CertificateAuthorityServiceClient.ListCertificatesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCertificatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.RevokeCertificate</c> and
        /// <c>CertificateAuthorityServiceClient.RevokeCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RevokeCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.UpdateCertificate</c> and
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCertificateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.ActivateCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.ActivateCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ActivateCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CertificateAuthorityServiceClient.ActivateCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.ActivateCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings ActivateCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.CreateCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.CreateCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.CreateCertificateAuthority</c>
        ///  and <c>CertificateAuthorityServiceClient.CreateCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings CreateCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.DisableCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.DisableCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings DisableCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CertificateAuthorityServiceClient.DisableCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.DisableCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings DisableCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.EnableCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.EnableCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings EnableCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.EnableCertificateAuthority</c>
        ///  and <c>CertificateAuthorityServiceClient.EnableCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings EnableCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.FetchCertificateAuthorityCsr</c> and
        /// <c>CertificateAuthorityServiceClient.FetchCertificateAuthorityCsrAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings FetchCertificateAuthorityCsrSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.GetCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.GetCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.ListCertificateAuthorities</c> and
        /// <c>CertificateAuthorityServiceClient.ListCertificateAuthoritiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCertificateAuthoritiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.RestoreCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.RestoreCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RestoreCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CertificateAuthorityServiceClient.RestoreCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.RestoreCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings RestoreCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.ScheduleDeleteCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.ScheduleDeleteCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ScheduleDeleteCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CertificateAuthorityServiceClient.ScheduleDeleteCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.ScheduleDeleteCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings ScheduleDeleteCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateAuthorityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.UpdateCertificateAuthority</c>
        ///  and <c>CertificateAuthorityServiceClient.UpdateCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings UpdateCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.GetCertificateRevocationList</c> and
        /// <c>CertificateAuthorityServiceClient.GetCertificateRevocationListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCertificateRevocationListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.ListCertificateRevocationLists</c> and
        /// <c>CertificateAuthorityServiceClient.ListCertificateRevocationListsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListCertificateRevocationListsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateRevocationList</c> and
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateRevocationListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UpdateCertificateRevocationListSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateRevocationList</c> and
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateRevocationListAsync</c>.
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
        public lro::OperationsSettings UpdateCertificateRevocationListOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.GetReusableConfig</c> and
        /// <c>CertificateAuthorityServiceClient.GetReusableConfigAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetReusableConfigSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.ListReusableConfigs</c> and
        /// <c>CertificateAuthorityServiceClient.ListReusableConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unknown"/>,
        /// <see cref="grpccore::StatusCode.Unavailable"/>, <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 60 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListReusableConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CertificateAuthorityServiceSettings"/> object.</returns>
        public CertificateAuthorityServiceSettings Clone() => new CertificateAuthorityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CertificateAuthorityServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class CertificateAuthorityServiceClientBuilder : gaxgrpc::ClientBuilderBase<CertificateAuthorityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CertificateAuthorityServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CertificateAuthorityServiceClientBuilder() : base(CertificateAuthorityServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CertificateAuthorityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CertificateAuthorityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CertificateAuthorityServiceClient Build()
        {
            CertificateAuthorityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CertificateAuthorityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CertificateAuthorityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CertificateAuthorityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CertificateAuthorityServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<CertificateAuthorityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CertificateAuthorityServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CertificateAuthorityServiceClient.ChannelPool;
    }

    /// <summary>CertificateAuthorityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// [Certificate Authority Service][google.cloud.security.privateca.v1beta1.CertificateAuthorityService] manages private
    /// certificate authorities and issued certificates.
    /// </remarks>
    public abstract partial class CertificateAuthorityServiceClient
    {
        /// <summary>
        /// The default endpoint for the CertificateAuthorityService service, which is a host of
        /// "privateca.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "privateca.googleapis.com:443";

        /// <summary>The default CertificateAuthorityService scopes.</summary>
        /// <remarks>
        /// The default CertificateAuthorityService scopes are:
        /// <list type="bullet">
        /// <item><description>https://www.googleapis.com/auth/cloud-platform</description></item>
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/cloud-platform",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CertificateAuthorityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CertificateAuthorityServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CertificateAuthorityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CertificateAuthorityServiceClient"/>.</returns>
        public static stt::Task<CertificateAuthorityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CertificateAuthorityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CertificateAuthorityServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CertificateAuthorityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CertificateAuthorityServiceClient"/>.</returns>
        public static CertificateAuthorityServiceClient Create() => new CertificateAuthorityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CertificateAuthorityServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CertificateAuthorityServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CertificateAuthorityServiceClient"/>.</returns>
        internal static CertificateAuthorityServiceClient Create(grpccore::CallInvoker callInvoker, CertificateAuthorityServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CertificateAuthorityService.CertificateAuthorityServiceClient grpcClient = new CertificateAuthorityService.CertificateAuthorityServiceClient(callInvoker);
            return new CertificateAuthorityServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CertificateAuthorityService client</summary>
        public virtual CertificateAuthorityService.CertificateAuthorityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate CreateCertificate(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(CreateCertificateRequest request, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location and [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// associated with the [Certificate][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the Enterprise [CertificateAuthority.Tier][google.cloud.security.privateca.v1beta1.CertificateAuthority.Tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate CreateCertificate(string parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificate(new CreateCertificateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateId = certificateId ?? "",
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location and [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// associated with the [Certificate][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the Enterprise [CertificateAuthority.Tier][google.cloud.security.privateca.v1beta1.CertificateAuthority.Tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(string parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAsync(new CreateCertificateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateId = certificateId ?? "",
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location and [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// associated with the [Certificate][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the Enterprise [CertificateAuthority.Tier][google.cloud.security.privateca.v1beta1.CertificateAuthority.Tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(string parent, Certificate certificate, string certificateId, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(parent, certificate, certificateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location and [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// associated with the [Certificate][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the Enterprise [CertificateAuthority.Tier][google.cloud.security.privateca.v1beta1.CertificateAuthority.Tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate CreateCertificate(CertificateAuthorityName parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificate(new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateId = certificateId ?? "",
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location and [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// associated with the [Certificate][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the Enterprise [CertificateAuthority.Tier][google.cloud.security.privateca.v1beta1.CertificateAuthority.Tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(CertificateAuthorityName parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAsync(new CreateCertificateRequest
            {
                ParentAsCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateId = certificateId ?? "",
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location and [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// associated with the [Certificate][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the Enterprise [CertificateAuthority.Tier][google.cloud.security.privateca.v1beta1.CertificateAuthority.Tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(CertificateAuthorityName parent, Certificate certificate, string certificateId, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(parent, certificate, certificateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(GetCertificateRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.Certificate.name] of the [Certificate][google.cloud.security.privateca.v1beta1.Certificate] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificate(new GetCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.Certificate.name] of the [Certificate][google.cloud.security.privateca.v1beta1.Certificate] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAsync(new GetCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.Certificate.name] of the [Certificate][google.cloud.security.privateca.v1beta1.Certificate] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.Certificate.name] of the [Certificate][google.cloud.security.privateca.v1beta1.Certificate] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificate(new GetCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.Certificate.name] of the [Certificate][google.cloud.security.privateca.v1beta1.Certificate] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAsync(new GetCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.Certificate.name] of the [Certificate][google.cloud.security.privateca.v1beta1.Certificate] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(CertificateName name, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [Certificates][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateauthorities/*`.
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
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificates(new ListCertificatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [Certificates][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateauthorities/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificatesAsync(new ListCertificatesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [Certificates][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateauthorities/*`.
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
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(CertificateAuthorityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificates(new ListCertificatesRequest
            {
                ParentAsCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [Certificates][google.cloud.security.privateca.v1beta1.Certificate], in the format
        /// `projects/*/locations/*/certificateauthorities/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(CertificateAuthorityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificatesAsync(new ListCertificatesRequest
            {
                ParentAsCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate RevokeCertificate(RevokeCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(RevokeCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(RevokeCertificateRequest request, st::CancellationToken cancellationToken) =>
            RevokeCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in the
        /// format `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate RevokeCertificate(string name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeCertificate(new RevokeCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in the
        /// format `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeCertificateAsync(new RevokeCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in the
        /// format `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(string name, st::CancellationToken cancellationToken) =>
            RevokeCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in the
        /// format `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate RevokeCertificate(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeCertificate(new RevokeCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in the
        /// format `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeCertificateAsync(new RevokeCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in the
        /// format `projects/*/locations/*/certificateAuthorities/*/certificates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(CertificateName name, st::CancellationToken cancellationToken) =>
            RevokeCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1beta1.Certificate]. Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1beta1.Certificate.labels] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate UpdateCertificate(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1beta1.Certificate]. Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1beta1.Certificate.labels] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> UpdateCertificateAsync(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1beta1.Certificate]. Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1beta1.Certificate.labels] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> UpdateCertificateAsync(UpdateCertificateRequest request, st::CancellationToken cancellationToken) =>
            UpdateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1beta1.Certificate]. Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1beta1.Certificate.labels] field.
        /// </summary>
        /// <param name="certificate">
        /// Required. [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate UpdateCertificate(Certificate certificate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificate(new UpdateCertificateRequest
            {
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1beta1.Certificate]. Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1beta1.Certificate.labels] field.
        /// </summary>
        /// <param name="certificate">
        /// Required. [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> UpdateCertificateAsync(Certificate certificate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateAsync(new UpdateCertificateRequest
            {
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1beta1.Certificate]. Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1beta1.Certificate.labels] field.
        /// </summary>
        /// <param name="certificate">
        /// Required. [Certificate][google.cloud.security.privateca.v1beta1.Certificate] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> UpdateCertificateAsync(Certificate certificate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateAsync(certificate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ActivateCertificateAuthority(ActivateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(ActivateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(ActivateCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            ActivateCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ActivateCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient ActivateCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ActivateCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceActivateCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ActivateCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ActivateCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceActivateCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ActivateCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ActivateCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateCertificateAuthority(new ActivateCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateCertificateAuthorityAsync(new ActivateCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            ActivateCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ActivateCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateCertificateAuthority(new ActivateCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateCertificateAuthorityAsync(new ActivateCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            ActivateCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> CreateCertificateAuthority(CreateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            CreateCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient CreateCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceCreateCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceCreateCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> CreateCertificateAuthority(string parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAuthority(new CreateCertificateAuthorityRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateAuthorityId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)),
                CertificateAuthority = gax::GaxPreconditions.CheckNotNull(certificateAuthority, nameof(certificateAuthority)),
            }, callSettings);

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(string parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAuthorityAsync(new CreateCertificateAuthorityRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateAuthorityId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)),
                CertificateAuthority = gax::GaxPreconditions.CheckNotNull(certificateAuthority, nameof(certificateAuthority)),
            }, callSettings);

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(string parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, st::CancellationToken cancellationToken) =>
            CreateCertificateAuthorityAsync(parent, certificateAuthority, certificateAuthorityId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> CreateCertificateAuthority(gagr::LocationName parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAuthority(new CreateCertificateAuthorityRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateAuthorityId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)),
                CertificateAuthority = gax::GaxPreconditions.CheckNotNull(certificateAuthority, nameof(certificateAuthority)),
            }, callSettings);

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(gagr::LocationName parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAuthorityAsync(new CreateCertificateAuthorityRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateAuthorityId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)),
                CertificateAuthority = gax::GaxPreconditions.CheckNotNull(certificateAuthority, nameof(certificateAuthority)),
            }, callSettings);

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(gagr::LocationName parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, st::CancellationToken cancellationToken) =>
            CreateCertificateAuthorityAsync(parent, certificateAuthority, certificateAuthorityId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DisableCertificateAuthority(DisableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(DisableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(DisableCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            DisableCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DisableCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient DisableCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceDisableCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DisableCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceDisableCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DisableCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DisableCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableCertificateAuthority(new DisableCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableCertificateAuthorityAsync(new DisableCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            DisableCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DisableCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableCertificateAuthority(new DisableCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableCertificateAuthorityAsync(new DisableCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            DisableCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> EnableCertificateAuthority(EnableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(EnableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(EnableCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            EnableCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>EnableCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient EnableCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceEnableCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>EnableCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceEnableCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), EnableCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> EnableCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableCertificateAuthority(new EnableCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableCertificateAuthorityAsync(new EnableCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            EnableCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> EnableCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableCertificateAuthority(new EnableCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableCertificateAuthorityAsync(new EnableCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            EnableCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCertificateAuthorityCsrResponse FetchCertificateAuthorityCsr(FetchCertificateAuthorityCsrRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(FetchCertificateAuthorityCsrRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(FetchCertificateAuthorityCsrRequest request, st::CancellationToken cancellationToken) =>
            FetchCertificateAuthorityCsrAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCertificateAuthorityCsrResponse FetchCertificateAuthorityCsr(string name, gaxgrpc::CallSettings callSettings = null) =>
            FetchCertificateAuthorityCsr(new FetchCertificateAuthorityCsrRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            FetchCertificateAuthorityCsrAsync(new FetchCertificateAuthorityCsrRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(string name, st::CancellationToken cancellationToken) =>
            FetchCertificateAuthorityCsrAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCertificateAuthorityCsrResponse FetchCertificateAuthorityCsr(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            FetchCertificateAuthorityCsr(new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            FetchCertificateAuthorityCsrAsync(new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            FetchCertificateAuthorityCsrAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateAuthority.name] of the [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] to
        /// get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthority(new GetCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateAuthority.name] of the [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] to
        /// get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthorityAsync(new GetCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateAuthority.name] of the [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] to
        /// get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateAuthority.name] of the [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] to
        /// get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthority(new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateAuthority.name] of the [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] to
        /// get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthorityAsync(new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateAuthority.name] of the [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] to
        /// get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthorities(ListCertificateAuthoritiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthorities(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateAuthorities(new ListCertificateAuthoritiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthoritiesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateAuthoritiesAsync(new ListCertificateAuthoritiesRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthorities(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateAuthorities(new ListCertificateAuthoritiesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority], in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthoritiesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateAuthoritiesAsync(new ListCertificateAuthoritiesRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> RestoreCertificateAuthority(RestoreCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> RestoreCertificateAuthorityAsync(RestoreCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> RestoreCertificateAuthorityAsync(RestoreCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            RestoreCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RestoreCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient RestoreCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceRestoreCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RestoreCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceRestoreCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RestoreCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> RestoreCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreCertificateAuthority(new RestoreCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> RestoreCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreCertificateAuthorityAsync(new RestoreCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> RestoreCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            RestoreCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> RestoreCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreCertificateAuthority(new RestoreCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> RestoreCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            RestoreCertificateAuthorityAsync(new RestoreCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> RestoreCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            RestoreCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ScheduleDeleteCertificateAuthority(ScheduleDeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ScheduleDeleteCertificateAuthorityAsync(ScheduleDeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ScheduleDeleteCertificateAuthorityAsync(ScheduleDeleteCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            ScheduleDeleteCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ScheduleDeleteCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient ScheduleDeleteCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ScheduleDeleteCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceScheduleDeleteCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ScheduleDeleteCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ScheduleDeleteCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceScheduleDeleteCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ScheduleDeleteCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ScheduleDeleteCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleDeleteCertificateAuthority(new ScheduleDeleteCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ScheduleDeleteCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleDeleteCertificateAuthorityAsync(new ScheduleDeleteCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ScheduleDeleteCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            ScheduleDeleteCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ScheduleDeleteCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleDeleteCertificateAuthority(new ScheduleDeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ScheduleDeleteCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleDeleteCertificateAuthorityAsync(new ScheduleDeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in the
        /// format `projects/*/locations/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ScheduleDeleteCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            ScheduleDeleteCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> UpdateCertificateAuthority(UpdateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            UpdateCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient UpdateCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceUpdateCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceUpdateCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Update a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="certificateAuthority">
        /// Required. [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> UpdateCertificateAuthority(CertificateAuthority certificateAuthority, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateAuthority(new UpdateCertificateAuthorityRequest
            {
                CertificateAuthority = gax::GaxPreconditions.CheckNotNull(certificateAuthority, nameof(certificateAuthority)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="certificateAuthority">
        /// Required. [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UpdateCertificateAuthorityAsync(CertificateAuthority certificateAuthority, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateAuthorityAsync(new UpdateCertificateAuthorityRequest
            {
                CertificateAuthority = gax::GaxPreconditions.CheckNotNull(certificateAuthority, nameof(certificateAuthority)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="certificateAuthority">
        /// Required. [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UpdateCertificateAuthorityAsync(CertificateAuthority certificateAuthority, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateAuthorityAsync(certificateAuthority, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateRevocationList GetCertificateRevocationList(GetCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(GetCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(GetCertificateRevocationListRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateRevocationListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateRevocationList.name] of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateRevocationList GetCertificateRevocationList(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateRevocationList(new GetCertificateRevocationListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateRevocationList.name] of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateRevocationListAsync(new GetCertificateRevocationListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateRevocationList.name] of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateRevocationListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateRevocationList.name] of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateRevocationList GetCertificateRevocationList(CertificateRevocationListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateRevocationList(new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateRevocationList.name] of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(CertificateRevocationListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateRevocationListAsync(new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1beta1.CertificateRevocationList.name] of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(CertificateRevocationListName name, st::CancellationToken cancellationToken) =>
            GetCertificateRevocationListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationLists(ListCertificateRevocationListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationListsAsync(ListCertificateRevocationListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList], in the format
        /// `projects/*/locations/*/certificateauthorities/*`.
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
        /// <returns>A pageable sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationLists(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateRevocationLists(new ListCertificateRevocationListsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList], in the format
        /// `projects/*/locations/*/certificateauthorities/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationListsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateRevocationListsAsync(new ListCertificateRevocationListsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList], in the format
        /// `projects/*/locations/*/certificateauthorities/*`.
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
        /// <returns>A pageable sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationLists(CertificateAuthorityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateRevocationLists(new ListCertificateRevocationListsRequest
            {
                ParentAsCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList], in the format
        /// `projects/*/locations/*/certificateauthorities/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationListsAsync(CertificateAuthorityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCertificateRevocationListsAsync(new ListCertificateRevocationListsRequest
            {
                ParentAsCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Update a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateRevocationList, OperationMetadata> UpdateCertificateRevocationList(UpdateCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> UpdateCertificateRevocationListAsync(UpdateCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> UpdateCertificateRevocationListAsync(UpdateCertificateRevocationListRequest request, st::CancellationToken cancellationToken) =>
            UpdateCertificateRevocationListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCertificateRevocationList</c>.</summary>
        public virtual lro::OperationsClient UpdateCertificateRevocationListOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateRevocationList</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateRevocationList, OperationMetadata> PollOnceUpdateCertificateRevocationList(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateRevocationList, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateRevocationListOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateRevocationList</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> PollOnceUpdateCertificateRevocationListAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateRevocationList, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateRevocationListOperationsClient, callSettings);

        /// <summary>
        /// Update a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="certificateRevocationList">
        /// Required. [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateRevocationList, OperationMetadata> UpdateCertificateRevocationList(CertificateRevocationList certificateRevocationList, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateRevocationList(new UpdateCertificateRevocationListRequest
            {
                CertificateRevocationList = gax::GaxPreconditions.CheckNotNull(certificateRevocationList, nameof(certificateRevocationList)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="certificateRevocationList">
        /// Required. [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> UpdateCertificateRevocationListAsync(CertificateRevocationList certificateRevocationList, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateRevocationListAsync(new UpdateCertificateRevocationListRequest
            {
                CertificateRevocationList = gax::GaxPreconditions.CheckNotNull(certificateRevocationList, nameof(certificateRevocationList)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="certificateRevocationList">
        /// Required. [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList] with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> UpdateCertificateRevocationListAsync(CertificateRevocationList certificateRevocationList, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateRevocationListAsync(certificateRevocationList, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReusableConfig GetReusableConfig(GetReusableConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReusableConfig> GetReusableConfigAsync(GetReusableConfigRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReusableConfig> GetReusableConfigAsync(GetReusableConfigRequest request, st::CancellationToken cancellationToken) =>
            GetReusableConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][ReusableConfigs.name] of the [ReusableConfigs][] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReusableConfig GetReusableConfig(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReusableConfig(new GetReusableConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][ReusableConfigs.name] of the [ReusableConfigs][] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReusableConfig> GetReusableConfigAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetReusableConfigAsync(new GetReusableConfigRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][ReusableConfigs.name] of the [ReusableConfigs][] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReusableConfig> GetReusableConfigAsync(string name, st::CancellationToken cancellationToken) =>
            GetReusableConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][ReusableConfigs.name] of the [ReusableConfigs][] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ReusableConfig GetReusableConfig(ReusableConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReusableConfig(new GetReusableConfigRequest
            {
                ReusableConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][ReusableConfigs.name] of the [ReusableConfigs][] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReusableConfig> GetReusableConfigAsync(ReusableConfigName name, gaxgrpc::CallSettings callSettings = null) =>
            GetReusableConfigAsync(new GetReusableConfigRequest
            {
                ReusableConfigName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][ReusableConfigs.name] of the [ReusableConfigs][] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ReusableConfig> GetReusableConfigAsync(ReusableConfigName name, st::CancellationToken cancellationToken) =>
            GetReusableConfigAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReusableConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReusableConfigsResponse, ReusableConfig> ListReusableConfigs(ListReusableConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReusableConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReusableConfigsResponse, ReusableConfig> ListReusableConfigsAsync(ListReusableConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig], in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="ReusableConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReusableConfigsResponse, ReusableConfig> ListReusableConfigs(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReusableConfigs(new ListReusableConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig], in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReusableConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReusableConfigsResponse, ReusableConfig> ListReusableConfigsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReusableConfigsAsync(new ListReusableConfigsRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig], in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="ReusableConfig"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListReusableConfigsResponse, ReusableConfig> ListReusableConfigs(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReusableConfigs(new ListReusableConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Lists [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig], in the format
        /// `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="ReusableConfig"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListReusableConfigsResponse, ReusableConfig> ListReusableConfigsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListReusableConfigsAsync(new ListReusableConfigsRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>CertificateAuthorityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// [Certificate Authority Service][google.cloud.security.privateca.v1beta1.CertificateAuthorityService] manages private
    /// certificate authorities and issued certificates.
    /// </remarks>
    public sealed partial class CertificateAuthorityServiceClientImpl : CertificateAuthorityServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateCertificateRequest, Certificate> _callCreateCertificate;

        private readonly gaxgrpc::ApiCall<GetCertificateRequest, Certificate> _callGetCertificate;

        private readonly gaxgrpc::ApiCall<ListCertificatesRequest, ListCertificatesResponse> _callListCertificates;

        private readonly gaxgrpc::ApiCall<RevokeCertificateRequest, Certificate> _callRevokeCertificate;

        private readonly gaxgrpc::ApiCall<UpdateCertificateRequest, Certificate> _callUpdateCertificate;

        private readonly gaxgrpc::ApiCall<ActivateCertificateAuthorityRequest, lro::Operation> _callActivateCertificateAuthority;

        private readonly gaxgrpc::ApiCall<CreateCertificateAuthorityRequest, lro::Operation> _callCreateCertificateAuthority;

        private readonly gaxgrpc::ApiCall<DisableCertificateAuthorityRequest, lro::Operation> _callDisableCertificateAuthority;

        private readonly gaxgrpc::ApiCall<EnableCertificateAuthorityRequest, lro::Operation> _callEnableCertificateAuthority;

        private readonly gaxgrpc::ApiCall<FetchCertificateAuthorityCsrRequest, FetchCertificateAuthorityCsrResponse> _callFetchCertificateAuthorityCsr;

        private readonly gaxgrpc::ApiCall<GetCertificateAuthorityRequest, CertificateAuthority> _callGetCertificateAuthority;

        private readonly gaxgrpc::ApiCall<ListCertificateAuthoritiesRequest, ListCertificateAuthoritiesResponse> _callListCertificateAuthorities;

        private readonly gaxgrpc::ApiCall<RestoreCertificateAuthorityRequest, lro::Operation> _callRestoreCertificateAuthority;

        private readonly gaxgrpc::ApiCall<ScheduleDeleteCertificateAuthorityRequest, lro::Operation> _callScheduleDeleteCertificateAuthority;

        private readonly gaxgrpc::ApiCall<UpdateCertificateAuthorityRequest, lro::Operation> _callUpdateCertificateAuthority;

        private readonly gaxgrpc::ApiCall<GetCertificateRevocationListRequest, CertificateRevocationList> _callGetCertificateRevocationList;

        private readonly gaxgrpc::ApiCall<ListCertificateRevocationListsRequest, ListCertificateRevocationListsResponse> _callListCertificateRevocationLists;

        private readonly gaxgrpc::ApiCall<UpdateCertificateRevocationListRequest, lro::Operation> _callUpdateCertificateRevocationList;

        private readonly gaxgrpc::ApiCall<GetReusableConfigRequest, ReusableConfig> _callGetReusableConfig;

        private readonly gaxgrpc::ApiCall<ListReusableConfigsRequest, ListReusableConfigsResponse> _callListReusableConfigs;

        /// <summary>
        /// Constructs a client wrapper for the CertificateAuthorityService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CertificateAuthorityServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CertificateAuthorityServiceClientImpl(CertificateAuthorityService.CertificateAuthorityServiceClient grpcClient, CertificateAuthorityServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CertificateAuthorityServiceSettings effectiveSettings = settings ?? CertificateAuthorityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            ActivateCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ActivateCertificateAuthorityOperationsSettings, logger);
            CreateCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCertificateAuthorityOperationsSettings, logger);
            DisableCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableCertificateAuthorityOperationsSettings, logger);
            EnableCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableCertificateAuthorityOperationsSettings, logger);
            RestoreCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RestoreCertificateAuthorityOperationsSettings, logger);
            ScheduleDeleteCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ScheduleDeleteCertificateAuthorityOperationsSettings, logger);
            UpdateCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCertificateAuthorityOperationsSettings, logger);
            UpdateCertificateRevocationListOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCertificateRevocationListOperationsSettings, logger);
            _callCreateCertificate = clientHelper.BuildApiCall<CreateCertificateRequest, Certificate>("CreateCertificate", grpcClient.CreateCertificateAsync, grpcClient.CreateCertificate, effectiveSettings.CreateCertificateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCertificate);
            Modify_CreateCertificateApiCall(ref _callCreateCertificate);
            _callGetCertificate = clientHelper.BuildApiCall<GetCertificateRequest, Certificate>("GetCertificate", grpcClient.GetCertificateAsync, grpcClient.GetCertificate, effectiveSettings.GetCertificateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificate);
            Modify_GetCertificateApiCall(ref _callGetCertificate);
            _callListCertificates = clientHelper.BuildApiCall<ListCertificatesRequest, ListCertificatesResponse>("ListCertificates", grpcClient.ListCertificatesAsync, grpcClient.ListCertificates, effectiveSettings.ListCertificatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCertificates);
            Modify_ListCertificatesApiCall(ref _callListCertificates);
            _callRevokeCertificate = clientHelper.BuildApiCall<RevokeCertificateRequest, Certificate>("RevokeCertificate", grpcClient.RevokeCertificateAsync, grpcClient.RevokeCertificate, effectiveSettings.RevokeCertificateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRevokeCertificate);
            Modify_RevokeCertificateApiCall(ref _callRevokeCertificate);
            _callUpdateCertificate = clientHelper.BuildApiCall<UpdateCertificateRequest, Certificate>("UpdateCertificate", grpcClient.UpdateCertificateAsync, grpcClient.UpdateCertificate, effectiveSettings.UpdateCertificateSettings).WithGoogleRequestParam("certificate.name", request => request.Certificate?.Name);
            Modify_ApiCall(ref _callUpdateCertificate);
            Modify_UpdateCertificateApiCall(ref _callUpdateCertificate);
            _callActivateCertificateAuthority = clientHelper.BuildApiCall<ActivateCertificateAuthorityRequest, lro::Operation>("ActivateCertificateAuthority", grpcClient.ActivateCertificateAuthorityAsync, grpcClient.ActivateCertificateAuthority, effectiveSettings.ActivateCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callActivateCertificateAuthority);
            Modify_ActivateCertificateAuthorityApiCall(ref _callActivateCertificateAuthority);
            _callCreateCertificateAuthority = clientHelper.BuildApiCall<CreateCertificateAuthorityRequest, lro::Operation>("CreateCertificateAuthority", grpcClient.CreateCertificateAuthorityAsync, grpcClient.CreateCertificateAuthority, effectiveSettings.CreateCertificateAuthoritySettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCertificateAuthority);
            Modify_CreateCertificateAuthorityApiCall(ref _callCreateCertificateAuthority);
            _callDisableCertificateAuthority = clientHelper.BuildApiCall<DisableCertificateAuthorityRequest, lro::Operation>("DisableCertificateAuthority", grpcClient.DisableCertificateAuthorityAsync, grpcClient.DisableCertificateAuthority, effectiveSettings.DisableCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDisableCertificateAuthority);
            Modify_DisableCertificateAuthorityApiCall(ref _callDisableCertificateAuthority);
            _callEnableCertificateAuthority = clientHelper.BuildApiCall<EnableCertificateAuthorityRequest, lro::Operation>("EnableCertificateAuthority", grpcClient.EnableCertificateAuthorityAsync, grpcClient.EnableCertificateAuthority, effectiveSettings.EnableCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callEnableCertificateAuthority);
            Modify_EnableCertificateAuthorityApiCall(ref _callEnableCertificateAuthority);
            _callFetchCertificateAuthorityCsr = clientHelper.BuildApiCall<FetchCertificateAuthorityCsrRequest, FetchCertificateAuthorityCsrResponse>("FetchCertificateAuthorityCsr", grpcClient.FetchCertificateAuthorityCsrAsync, grpcClient.FetchCertificateAuthorityCsr, effectiveSettings.FetchCertificateAuthorityCsrSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callFetchCertificateAuthorityCsr);
            Modify_FetchCertificateAuthorityCsrApiCall(ref _callFetchCertificateAuthorityCsr);
            _callGetCertificateAuthority = clientHelper.BuildApiCall<GetCertificateAuthorityRequest, CertificateAuthority>("GetCertificateAuthority", grpcClient.GetCertificateAuthorityAsync, grpcClient.GetCertificateAuthority, effectiveSettings.GetCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificateAuthority);
            Modify_GetCertificateAuthorityApiCall(ref _callGetCertificateAuthority);
            _callListCertificateAuthorities = clientHelper.BuildApiCall<ListCertificateAuthoritiesRequest, ListCertificateAuthoritiesResponse>("ListCertificateAuthorities", grpcClient.ListCertificateAuthoritiesAsync, grpcClient.ListCertificateAuthorities, effectiveSettings.ListCertificateAuthoritiesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCertificateAuthorities);
            Modify_ListCertificateAuthoritiesApiCall(ref _callListCertificateAuthorities);
            _callRestoreCertificateAuthority = clientHelper.BuildApiCall<RestoreCertificateAuthorityRequest, lro::Operation>("RestoreCertificateAuthority", grpcClient.RestoreCertificateAuthorityAsync, grpcClient.RestoreCertificateAuthority, effectiveSettings.RestoreCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callRestoreCertificateAuthority);
            Modify_RestoreCertificateAuthorityApiCall(ref _callRestoreCertificateAuthority);
            _callScheduleDeleteCertificateAuthority = clientHelper.BuildApiCall<ScheduleDeleteCertificateAuthorityRequest, lro::Operation>("ScheduleDeleteCertificateAuthority", grpcClient.ScheduleDeleteCertificateAuthorityAsync, grpcClient.ScheduleDeleteCertificateAuthority, effectiveSettings.ScheduleDeleteCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callScheduleDeleteCertificateAuthority);
            Modify_ScheduleDeleteCertificateAuthorityApiCall(ref _callScheduleDeleteCertificateAuthority);
            _callUpdateCertificateAuthority = clientHelper.BuildApiCall<UpdateCertificateAuthorityRequest, lro::Operation>("UpdateCertificateAuthority", grpcClient.UpdateCertificateAuthorityAsync, grpcClient.UpdateCertificateAuthority, effectiveSettings.UpdateCertificateAuthoritySettings).WithGoogleRequestParam("certificate_authority.name", request => request.CertificateAuthority?.Name);
            Modify_ApiCall(ref _callUpdateCertificateAuthority);
            Modify_UpdateCertificateAuthorityApiCall(ref _callUpdateCertificateAuthority);
            _callGetCertificateRevocationList = clientHelper.BuildApiCall<GetCertificateRevocationListRequest, CertificateRevocationList>("GetCertificateRevocationList", grpcClient.GetCertificateRevocationListAsync, grpcClient.GetCertificateRevocationList, effectiveSettings.GetCertificateRevocationListSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificateRevocationList);
            Modify_GetCertificateRevocationListApiCall(ref _callGetCertificateRevocationList);
            _callListCertificateRevocationLists = clientHelper.BuildApiCall<ListCertificateRevocationListsRequest, ListCertificateRevocationListsResponse>("ListCertificateRevocationLists", grpcClient.ListCertificateRevocationListsAsync, grpcClient.ListCertificateRevocationLists, effectiveSettings.ListCertificateRevocationListsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCertificateRevocationLists);
            Modify_ListCertificateRevocationListsApiCall(ref _callListCertificateRevocationLists);
            _callUpdateCertificateRevocationList = clientHelper.BuildApiCall<UpdateCertificateRevocationListRequest, lro::Operation>("UpdateCertificateRevocationList", grpcClient.UpdateCertificateRevocationListAsync, grpcClient.UpdateCertificateRevocationList, effectiveSettings.UpdateCertificateRevocationListSettings).WithGoogleRequestParam("certificate_revocation_list.name", request => request.CertificateRevocationList?.Name);
            Modify_ApiCall(ref _callUpdateCertificateRevocationList);
            Modify_UpdateCertificateRevocationListApiCall(ref _callUpdateCertificateRevocationList);
            _callGetReusableConfig = clientHelper.BuildApiCall<GetReusableConfigRequest, ReusableConfig>("GetReusableConfig", grpcClient.GetReusableConfigAsync, grpcClient.GetReusableConfig, effectiveSettings.GetReusableConfigSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetReusableConfig);
            Modify_GetReusableConfigApiCall(ref _callGetReusableConfig);
            _callListReusableConfigs = clientHelper.BuildApiCall<ListReusableConfigsRequest, ListReusableConfigsResponse>("ListReusableConfigs", grpcClient.ListReusableConfigsAsync, grpcClient.ListReusableConfigs, effectiveSettings.ListReusableConfigsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListReusableConfigs);
            Modify_ListReusableConfigsApiCall(ref _callListReusableConfigs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateCertificateApiCall(ref gaxgrpc::ApiCall<CreateCertificateRequest, Certificate> call);

        partial void Modify_GetCertificateApiCall(ref gaxgrpc::ApiCall<GetCertificateRequest, Certificate> call);

        partial void Modify_ListCertificatesApiCall(ref gaxgrpc::ApiCall<ListCertificatesRequest, ListCertificatesResponse> call);

        partial void Modify_RevokeCertificateApiCall(ref gaxgrpc::ApiCall<RevokeCertificateRequest, Certificate> call);

        partial void Modify_UpdateCertificateApiCall(ref gaxgrpc::ApiCall<UpdateCertificateRequest, Certificate> call);

        partial void Modify_ActivateCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<ActivateCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_CreateCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<CreateCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_DisableCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<DisableCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_EnableCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<EnableCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_FetchCertificateAuthorityCsrApiCall(ref gaxgrpc::ApiCall<FetchCertificateAuthorityCsrRequest, FetchCertificateAuthorityCsrResponse> call);

        partial void Modify_GetCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<GetCertificateAuthorityRequest, CertificateAuthority> call);

        partial void Modify_ListCertificateAuthoritiesApiCall(ref gaxgrpc::ApiCall<ListCertificateAuthoritiesRequest, ListCertificateAuthoritiesResponse> call);

        partial void Modify_RestoreCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<RestoreCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_ScheduleDeleteCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<ScheduleDeleteCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_UpdateCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<UpdateCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_GetCertificateRevocationListApiCall(ref gaxgrpc::ApiCall<GetCertificateRevocationListRequest, CertificateRevocationList> call);

        partial void Modify_ListCertificateRevocationListsApiCall(ref gaxgrpc::ApiCall<ListCertificateRevocationListsRequest, ListCertificateRevocationListsResponse> call);

        partial void Modify_UpdateCertificateRevocationListApiCall(ref gaxgrpc::ApiCall<UpdateCertificateRevocationListRequest, lro::Operation> call);

        partial void Modify_GetReusableConfigApiCall(ref gaxgrpc::ApiCall<GetReusableConfigRequest, ReusableConfig> call);

        partial void Modify_ListReusableConfigsApiCall(ref gaxgrpc::ApiCall<ListReusableConfigsRequest, ListReusableConfigsResponse> call);

        partial void OnConstruction(CertificateAuthorityService.CertificateAuthorityServiceClient grpcClient, CertificateAuthorityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CertificateAuthorityService client</summary>
        public override CertificateAuthorityService.CertificateAuthorityServiceClient GrpcClient { get; }

        partial void Modify_CreateCertificateRequest(ref CreateCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateRequest(ref GetCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCertificatesRequest(ref ListCertificatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RevokeCertificateRequest(ref RevokeCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateRequest(ref UpdateCertificateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ActivateCertificateAuthorityRequest(ref ActivateCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCertificateAuthorityRequest(ref CreateCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DisableCertificateAuthorityRequest(ref DisableCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnableCertificateAuthorityRequest(ref EnableCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchCertificateAuthorityCsrRequest(ref FetchCertificateAuthorityCsrRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateAuthorityRequest(ref GetCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCertificateAuthoritiesRequest(ref ListCertificateAuthoritiesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RestoreCertificateAuthorityRequest(ref RestoreCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ScheduleDeleteCertificateAuthorityRequest(ref ScheduleDeleteCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateAuthorityRequest(ref UpdateCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateRevocationListRequest(ref GetCertificateRevocationListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCertificateRevocationListsRequest(ref ListCertificateRevocationListsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateRevocationListRequest(ref UpdateCertificateRevocationListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetReusableConfigRequest(ref GetReusableConfigRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListReusableConfigsRequest(ref ListReusableConfigsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Certificate CreateCertificate(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateRequest(ref request, ref callSettings);
            return _callCreateCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1beta1.Certificate] in a given Project, Location from a particular
        /// [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Certificate> CreateCertificateAsync(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateRequest(ref request, ref callSettings);
            return _callCreateCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Certificate GetCertificate(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateRequest(ref request, ref callSettings);
            return _callGetCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Certificate> GetCertificateAsync(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateRequest(ref request, ref callSettings);
            return _callGetCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public override gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCertificatesRequest, ListCertificatesResponse, Certificate>(_callListCertificates, request, callSettings);
        }

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCertificatesRequest, ListCertificatesResponse, Certificate>(_callListCertificates, request, callSettings);
        }

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Certificate RevokeCertificate(RevokeCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevokeCertificateRequest(ref request, ref callSettings);
            return _callRevokeCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1beta1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Certificate> RevokeCertificateAsync(RevokeCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RevokeCertificateRequest(ref request, ref callSettings);
            return _callRevokeCertificate.Async(request, callSettings);
        }

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1beta1.Certificate]. Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1beta1.Certificate.labels] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override Certificate UpdateCertificate(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateRequest(ref request, ref callSettings);
            return _callUpdateCertificate.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1beta1.Certificate]. Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1beta1.Certificate.labels] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<Certificate> UpdateCertificateAsync(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateRequest(ref request, ref callSettings);
            return _callUpdateCertificate.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ActivateCertificateAuthority</c>.</summary>
        public override lro::OperationsClient ActivateCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> ActivateCertificateAuthority(ActivateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ActivateCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callActivateCertificateAuthority.Sync(request, callSettings), ActivateCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Activate a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. After the
        /// parent Certificate Authority signs a certificate signing request from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.FetchCertificateAuthorityCsr], this method can complete the activation
        /// process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(ActivateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ActivateCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callActivateCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), ActivateCertificateAuthorityOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateCertificateAuthority</c>.</summary>
        public override lro::OperationsClient CreateCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> CreateCertificateAuthority(CreateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callCreateCertificateAuthority.Sync(request, callSettings), CreateCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Create a new [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callCreateCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), CreateCertificateAuthorityOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DisableCertificateAuthority</c>.</summary>
        public override lro::OperationsClient DisableCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> DisableCertificateAuthority(DisableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callDisableCertificateAuthority.Sync(request, callSettings), DisableCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Disable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(DisableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DisableCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callDisableCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), DisableCertificateAuthorityOperationsClient);
        }

        /// <summary>The long-running operations client for <c>EnableCertificateAuthority</c>.</summary>
        public override lro::OperationsClient EnableCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> EnableCertificateAuthority(EnableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callEnableCertificateAuthority.Sync(request, callSettings), EnableCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Enable a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(EnableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnableCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callEnableCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), EnableCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchCertificateAuthorityCsrResponse FetchCertificateAuthorityCsr(FetchCertificateAuthorityCsrRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchCertificateAuthorityCsrRequest(ref request, ref callSettings);
            return _callFetchCertificateAuthorityCsr.Sync(request, callSettings);
        }

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority]
        /// that is in state
        /// [PENDING_ACTIVATION][google.cloud.security.privateca.v1beta1.CertificateAuthority.State.PENDING_ACTIVATION] and is
        /// of type [SUBORDINATE][google.cloud.security.privateca.v1beta1.CertificateAuthority.Type.SUBORDINATE]. The CSR must
        /// then be signed by the desired parent Certificate Authority, which could be
        /// another [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] resource, or could be an on-prem
        /// certificate authority. See also [ActivateCertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(FetchCertificateAuthorityCsrRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchCertificateAuthorityCsrRequest(ref request, ref callSettings);
            return _callFetchCertificateAuthorityCsr.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CertificateAuthority GetCertificateAuthority(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetCertificateAuthority.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateAuthorityRequest(ref request, ref callSettings);
            return _callGetCertificateAuthority.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public override gax::PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthorities(ListCertificateAuthoritiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateAuthoritiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCertificateAuthoritiesRequest, ListCertificateAuthoritiesResponse, CertificateAuthority>(_callListCertificateAuthorities, request, callSettings);
        }

        /// <summary>
        /// Lists [CertificateAuthorities][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateAuthoritiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCertificateAuthoritiesRequest, ListCertificateAuthoritiesResponse, CertificateAuthority>(_callListCertificateAuthorities, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RestoreCertificateAuthority</c>.</summary>
        public override lro::OperationsClient RestoreCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> RestoreCertificateAuthority(RestoreCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callRestoreCertificateAuthority.Sync(request, callSettings), RestoreCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Restore a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] that is scheduled for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> RestoreCertificateAuthorityAsync(RestoreCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RestoreCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callRestoreCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), RestoreCertificateAuthorityOperationsClient);
        }

        /// <summary>The long-running operations client for <c>ScheduleDeleteCertificateAuthority</c>.</summary>
        public override lro::OperationsClient ScheduleDeleteCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> ScheduleDeleteCertificateAuthority(ScheduleDeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ScheduleDeleteCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callScheduleDeleteCertificateAuthority.Sync(request, callSettings), ScheduleDeleteCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Schedule a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority] for deletion.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ScheduleDeleteCertificateAuthorityAsync(ScheduleDeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ScheduleDeleteCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callScheduleDeleteCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), ScheduleDeleteCertificateAuthorityOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCertificateAuthority</c>.</summary>
        public override lro::OperationsClient UpdateCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Update a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> UpdateCertificateAuthority(UpdateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callUpdateCertificateAuthority.Sync(request, callSettings), UpdateCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Update a [CertificateAuthority][google.cloud.security.privateca.v1beta1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callUpdateCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), UpdateCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CertificateRevocationList GetCertificateRevocationList(GetCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateRevocationListRequest(ref request, ref callSettings);
            return _callGetCertificateRevocationList.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(GetCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateRevocationListRequest(ref request, ref callSettings);
            return _callGetCertificateRevocationList.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public override gax::PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationLists(ListCertificateRevocationListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateRevocationListsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCertificateRevocationListsRequest, ListCertificateRevocationListsResponse, CertificateRevocationList>(_callListCertificateRevocationLists, request, callSettings);
        }

        /// <summary>
        /// Lists [CertificateRevocationLists][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationListsAsync(ListCertificateRevocationListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateRevocationListsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCertificateRevocationListsRequest, ListCertificateRevocationListsResponse, CertificateRevocationList>(_callListCertificateRevocationLists, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateCertificateRevocationList</c>.</summary>
        public override lro::OperationsClient UpdateCertificateRevocationListOperationsClient { get; }

        /// <summary>
        /// Update a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateRevocationList, OperationMetadata> UpdateCertificateRevocationList(UpdateCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateRevocationListRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateRevocationList, OperationMetadata>(_callUpdateCertificateRevocationList.Sync(request, callSettings), UpdateCertificateRevocationListOperationsClient);
        }

        /// <summary>
        /// Update a [CertificateRevocationList][google.cloud.security.privateca.v1beta1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> UpdateCertificateRevocationListAsync(UpdateCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateRevocationListRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateRevocationList, OperationMetadata>(await _callUpdateCertificateRevocationList.Async(request, callSettings).ConfigureAwait(false), UpdateCertificateRevocationListOperationsClient);
        }

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ReusableConfig GetReusableConfig(GetReusableConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReusableConfigRequest(ref request, ref callSettings);
            return _callGetReusableConfig.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a [ReusableConfig][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ReusableConfig> GetReusableConfigAsync(GetReusableConfigRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetReusableConfigRequest(ref request, ref callSettings);
            return _callGetReusableConfig.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="ReusableConfig"/> resources.</returns>
        public override gax::PagedEnumerable<ListReusableConfigsResponse, ReusableConfig> ListReusableConfigs(ListReusableConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReusableConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListReusableConfigsRequest, ListReusableConfigsResponse, ReusableConfig>(_callListReusableConfigs, request, callSettings);
        }

        /// <summary>
        /// Lists [ReusableConfigs][google.cloud.security.privateca.v1beta1.ReusableConfig].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="ReusableConfig"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListReusableConfigsResponse, ReusableConfig> ListReusableConfigsAsync(ListReusableConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListReusableConfigsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListReusableConfigsRequest, ListReusableConfigsResponse, ReusableConfig>(_callListReusableConfigs, request, callSettings);
        }
    }

    public partial class ListCertificatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificateAuthoritiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificateRevocationListsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListReusableConfigsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificatesResponse : gaxgrpc::IPageResponse<Certificate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<Certificate> GetEnumerator() => Certificates.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCertificateAuthoritiesResponse : gaxgrpc::IPageResponse<CertificateAuthority>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CertificateAuthority> GetEnumerator() => CertificateAuthorities.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCertificateRevocationListsResponse : gaxgrpc::IPageResponse<CertificateRevocationList>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CertificateRevocationList> GetEnumerator() => CertificateRevocationLists.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListReusableConfigsResponse : gaxgrpc::IPageResponse<ReusableConfig>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<ReusableConfig> GetEnumerator() => ReusableConfigs.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CertificateAuthorityService
    {
        public partial class CertificateAuthorityServiceClient
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
