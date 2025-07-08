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

namespace Google.Cloud.Security.PrivateCA.V1
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
            UndeleteCertificateAuthoritySettings = existing.UndeleteCertificateAuthoritySettings;
            UndeleteCertificateAuthorityOperationsSettings = existing.UndeleteCertificateAuthorityOperationsSettings.Clone();
            DeleteCertificateAuthoritySettings = existing.DeleteCertificateAuthoritySettings;
            DeleteCertificateAuthorityOperationsSettings = existing.DeleteCertificateAuthorityOperationsSettings.Clone();
            UpdateCertificateAuthoritySettings = existing.UpdateCertificateAuthoritySettings;
            UpdateCertificateAuthorityOperationsSettings = existing.UpdateCertificateAuthorityOperationsSettings.Clone();
            CreateCaPoolSettings = existing.CreateCaPoolSettings;
            CreateCaPoolOperationsSettings = existing.CreateCaPoolOperationsSettings.Clone();
            UpdateCaPoolSettings = existing.UpdateCaPoolSettings;
            UpdateCaPoolOperationsSettings = existing.UpdateCaPoolOperationsSettings.Clone();
            GetCaPoolSettings = existing.GetCaPoolSettings;
            ListCaPoolsSettings = existing.ListCaPoolsSettings;
            DeleteCaPoolSettings = existing.DeleteCaPoolSettings;
            DeleteCaPoolOperationsSettings = existing.DeleteCaPoolOperationsSettings.Clone();
            FetchCaCertsSettings = existing.FetchCaCertsSettings;
            GetCertificateRevocationListSettings = existing.GetCertificateRevocationListSettings;
            ListCertificateRevocationListsSettings = existing.ListCertificateRevocationListsSettings;
            UpdateCertificateRevocationListSettings = existing.UpdateCertificateRevocationListSettings;
            UpdateCertificateRevocationListOperationsSettings = existing.UpdateCertificateRevocationListOperationsSettings.Clone();
            CreateCertificateTemplateSettings = existing.CreateCertificateTemplateSettings;
            CreateCertificateTemplateOperationsSettings = existing.CreateCertificateTemplateOperationsSettings.Clone();
            DeleteCertificateTemplateSettings = existing.DeleteCertificateTemplateSettings;
            DeleteCertificateTemplateOperationsSettings = existing.DeleteCertificateTemplateOperationsSettings.Clone();
            GetCertificateTemplateSettings = existing.GetCertificateTemplateSettings;
            ListCertificateTemplatesSettings = existing.ListCertificateTemplatesSettings;
            UpdateCertificateTemplateSettings = existing.UpdateCertificateTemplateSettings;
            UpdateCertificateTemplateOperationsSettings = existing.UpdateCertificateTemplateOperationsSettings.Clone();
            LocationsSettings = existing.LocationsSettings;
            IAMPolicySettings = existing.IAMPolicySettings;
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
        /// <c>CertificateAuthorityServiceClient.UndeleteCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.UndeleteCertificateAuthorityAsync</c>.
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
        public gaxgrpc::CallSettings UndeleteCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to
        /// <c>CertificateAuthorityServiceClient.UndeleteCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.UndeleteCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings UndeleteCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.DeleteCertificateAuthority</c> and
        /// <c>CertificateAuthorityServiceClient.DeleteCertificateAuthorityAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCertificateAuthoritySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.DeleteCertificateAuthority</c>
        ///  and <c>CertificateAuthorityServiceClient.DeleteCertificateAuthorityAsync</c>.
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
        public lro::OperationsSettings DeleteCertificateAuthorityOperationsSettings { get; set; } = new lro::OperationsSettings
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
        /// <c>CertificateAuthorityServiceClient.CreateCaPool</c> and
        /// <c>CertificateAuthorityServiceClient.CreateCaPoolAsync</c>.
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
        public gaxgrpc::CallSettings CreateCaPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.CreateCaPool</c> and
        /// <c>CertificateAuthorityServiceClient.CreateCaPoolAsync</c>.
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
        public lro::OperationsSettings CreateCaPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.UpdateCaPool</c> and
        /// <c>CertificateAuthorityServiceClient.UpdateCaPoolAsync</c>.
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
        public gaxgrpc::CallSettings UpdateCaPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.UpdateCaPool</c> and
        /// <c>CertificateAuthorityServiceClient.UpdateCaPoolAsync</c>.
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
        public lro::OperationsSettings UpdateCaPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.GetCaPool</c> and <c>CertificateAuthorityServiceClient.GetCaPoolAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GetCaPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.ListCaPools</c> and
        /// <c>CertificateAuthorityServiceClient.ListCaPoolsAsync</c>.
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
        public gaxgrpc::CallSettings ListCaPoolsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.DeleteCaPool</c> and
        /// <c>CertificateAuthorityServiceClient.DeleteCaPoolAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCaPoolSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.DeleteCaPool</c> and
        /// <c>CertificateAuthorityServiceClient.DeleteCaPoolAsync</c>.
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
        public lro::OperationsSettings DeleteCaPoolOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.FetchCaCerts</c> and
        /// <c>CertificateAuthorityServiceClient.FetchCaCertsAsync</c>.
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
        public gaxgrpc::CallSettings FetchCaCertsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

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
        /// <c>CertificateAuthorityServiceClient.CreateCertificateTemplate</c> and
        /// <c>CertificateAuthorityServiceClient.CreateCertificateTemplateAsync</c>.
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
        public gaxgrpc::CallSettings CreateCertificateTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.CreateCertificateTemplate</c>
        ///  and <c>CertificateAuthorityServiceClient.CreateCertificateTemplateAsync</c>.
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
        public lro::OperationsSettings CreateCertificateTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.DeleteCertificateTemplate</c> and
        /// <c>CertificateAuthorityServiceClient.DeleteCertificateTemplateAsync</c>.
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
        public gaxgrpc::CallSettings DeleteCertificateTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.DeleteCertificateTemplate</c>
        ///  and <c>CertificateAuthorityServiceClient.DeleteCertificateTemplateAsync</c>.
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
        public lro::OperationsSettings DeleteCertificateTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.GetCertificateTemplate</c> and
        /// <c>CertificateAuthorityServiceClient.GetCertificateTemplateAsync</c>.
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
        public gaxgrpc::CallSettings GetCertificateTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.ListCertificateTemplates</c> and
        /// <c>CertificateAuthorityServiceClient.ListCertificateTemplatesAsync</c>.
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
        public gaxgrpc::CallSettings ListCertificateTemplatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateTemplate</c> and
        /// <c>CertificateAuthorityServiceClient.UpdateCertificateTemplateAsync</c>.
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
        public gaxgrpc::CallSettings UpdateCertificateTemplateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(60000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(100), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unknown, grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CertificateAuthorityServiceClient.UpdateCertificateTemplate</c>
        ///  and <c>CertificateAuthorityServiceClient.UpdateCertificateTemplateAsync</c>.
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
        public lro::OperationsSettings UpdateCertificateTemplateOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// The settings to use for the <see cref="gcl::LocationsClient"/> associated with the client.
        /// </summary>
        public gcl::LocationsSettings LocationsSettings { get; set; } = gcl::LocationsSettings.GetDefault();

        /// <summary>
        /// The settings to use for the <see cref="gciv::IAMPolicyClient"/> associated with the client.
        /// </summary>
        public gciv::IAMPolicySettings IAMPolicySettings { get; set; } = gciv::IAMPolicySettings.GetDefault();

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
            return CertificateAuthorityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CertificateAuthorityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CertificateAuthorityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CertificateAuthorityServiceClient.ChannelPool;
    }

    /// <summary>CertificateAuthorityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// [Certificate Authority
    /// Service][google.cloud.security.privateca.v1.CertificateAuthorityService]
    /// manages private certificate authorities and issued certificates.
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
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CertificateAuthorityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc | gax::ApiTransports.Rest, PackageApiMetadata.ApiMetadata);

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

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public virtual gcl::LocationsClient LocationsClient => throw new sys::NotImplementedException();

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public virtual gciv::IAMPolicyClient IAMPolicyClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate CreateCertificate(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(CreateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(CreateCertificateRequest request, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [Certificate][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the Enterprise
        /// [CertificateAuthority.tier][google.cloud.security.privateca.v1.CertificateAuthority.tier],
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
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [Certificate][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the Enterprise
        /// [CertificateAuthority.tier][google.cloud.security.privateca.v1.CertificateAuthority.tier],
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
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [Certificate][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the Enterprise
        /// [CertificateAuthority.tier][google.cloud.security.privateca.v1.CertificateAuthority.tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(string parent, Certificate certificate, string certificateId, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(parent, certificate, certificateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [Certificate][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the Enterprise
        /// [CertificateAuthority.tier][google.cloud.security.privateca.v1.CertificateAuthority.tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate CreateCertificate(CaPoolName parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificate(new CreateCertificateRequest
            {
                ParentAsCaPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateId = certificateId ?? "",
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [Certificate][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the Enterprise
        /// [CertificateAuthority.tier][google.cloud.security.privateca.v1.CertificateAuthority.tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(CaPoolName parent, Certificate certificate, string certificateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAsync(new CreateCertificateRequest
            {
                ParentAsCaPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateId = certificateId ?? "",
                Certificate = gax::GaxPreconditions.CheckNotNull(certificate, nameof(certificate)),
            }, callSettings);

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [Certificate][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificate">
        /// Required. A [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateId">
        /// Optional. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`. This field is required when using a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the Enterprise
        /// [CertificateAuthority.tier][google.cloud.security.privateca.v1.CertificateAuthority.tier],
        /// but is optional and its value is ignored otherwise.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> CreateCertificateAsync(CaPoolName parent, Certificate certificate, string certificateId, st::CancellationToken cancellationToken) =>
            CreateCertificateAsync(parent, certificate, certificateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(GetCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(GetCertificateRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.Certificate.name]
        /// of the [Certificate][google.cloud.security.privateca.v1.Certificate] to
        /// get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificate(new GetCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.Certificate.name]
        /// of the [Certificate][google.cloud.security.privateca.v1.Certificate] to
        /// get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAsync(new GetCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.Certificate.name]
        /// of the [Certificate][google.cloud.security.privateca.v1.Certificate] to
        /// get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.Certificate.name]
        /// of the [Certificate][google.cloud.security.privateca.v1.Certificate] to
        /// get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate GetCertificate(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificate(new GetCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.Certificate.name]
        /// of the [Certificate][google.cloud.security.privateca.v1.Certificate] to
        /// get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAsync(new GetCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.Certificate.name]
        /// of the [Certificate][google.cloud.security.privateca.v1.Certificate] to
        /// get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> GetCertificateAsync(CertificateName name, st::CancellationToken cancellationToken) =>
            GetCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="Certificate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(ListCertificatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [Certificates][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
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
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificatesRequest request = new ListCertificatesRequest
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
            return ListCertificates(request, callSettings);
        }

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [Certificates][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
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
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificatesRequest request = new ListCertificatesRequest
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
            return ListCertificatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [Certificates][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
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
        public virtual gax::PagedEnumerable<ListCertificatesResponse, Certificate> ListCertificates(CaPoolName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificatesRequest request = new ListCertificatesRequest
            {
                ParentAsCaPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCertificates(request, callSettings);
        }

        /// <summary>
        /// Lists [Certificates][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [Certificates][google.cloud.security.privateca.v1.Certificate], in the
        /// format `projects/*/locations/*/caPools/*`.
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
        public virtual gax::PagedAsyncEnumerable<ListCertificatesResponse, Certificate> ListCertificatesAsync(CaPoolName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificatesRequest request = new ListCertificatesRequest
            {
                ParentAsCaPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCertificatesAsync(request, callSettings);
        }

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate RevokeCertificate(RevokeCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(RevokeCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(RevokeCertificateRequest request, st::CancellationToken cancellationToken) =>
            RevokeCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [Certificate][google.cloud.security.privateca.v1.Certificate] in the format
        /// `projects/*/locations/*/caPools/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate RevokeCertificate(string name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeCertificate(new RevokeCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [Certificate][google.cloud.security.privateca.v1.Certificate] in the format
        /// `projects/*/locations/*/caPools/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeCertificateAsync(new RevokeCertificateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [Certificate][google.cloud.security.privateca.v1.Certificate] in the format
        /// `projects/*/locations/*/caPools/*/certificates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(string name, st::CancellationToken cancellationToken) =>
            RevokeCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [Certificate][google.cloud.security.privateca.v1.Certificate] in the format
        /// `projects/*/locations/*/caPools/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate RevokeCertificate(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeCertificate(new RevokeCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [Certificate][google.cloud.security.privateca.v1.Certificate] in the format
        /// `projects/*/locations/*/caPools/*/certificates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(CertificateName name, gaxgrpc::CallSettings callSettings = null) =>
            RevokeCertificateAsync(new RevokeCertificateRequest
            {
                CertificateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [Certificate][google.cloud.security.privateca.v1.Certificate] in the format
        /// `projects/*/locations/*/caPools/*/certificates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> RevokeCertificateAsync(CertificateName name, st::CancellationToken cancellationToken) =>
            RevokeCertificateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1.Certificate.labels] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual Certificate UpdateCertificate(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1.Certificate.labels] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> UpdateCertificateAsync(UpdateCertificateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1.Certificate.labels] field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> UpdateCertificateAsync(UpdateCertificateRequest request, st::CancellationToken cancellationToken) =>
            UpdateCertificateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1.Certificate.labels] field.
        /// </summary>
        /// <param name="certificate">
        /// Required. [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with updated values.
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
        /// Update a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1.Certificate.labels] field.
        /// </summary>
        /// <param name="certificate">
        /// Required. [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with updated values.
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
        /// Update a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1.Certificate.labels] field.
        /// </summary>
        /// <param name="certificate">
        /// Required. [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<Certificate> UpdateCertificateAsync(Certificate certificate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateAsync(certificate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ActivateCertificateAuthority(ActivateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(ActivateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
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
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ActivateCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateCertificateAuthority(new ActivateCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateCertificateAuthorityAsync(new ActivateCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            ActivateCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> ActivateCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateCertificateAuthority(new ActivateCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            ActivateCertificateAuthorityAsync(new ActivateCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> ActivateCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            ActivateCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> CreateCertificateAuthority(CreateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(CreateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
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
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with initial field values.
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
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with initial field values.
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
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with initial field values.
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
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> CreateCertificateAuthority(CaPoolName parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAuthority(new CreateCertificateAuthorityRequest
            {
                ParentAsCaPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateAuthorityId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)),
                CertificateAuthority = gax::GaxPreconditions.CheckNotNull(certificateAuthority, nameof(certificateAuthority)),
            }, callSettings);

        /// <summary>
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(CaPoolName parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateAuthorityAsync(new CreateCertificateAuthorityRequest
            {
                ParentAsCaPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateAuthorityId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateAuthorityId, nameof(certificateAuthorityId)),
                CertificateAuthority = gax::GaxPreconditions.CheckNotNull(certificateAuthority, nameof(certificateAuthority)),
            }, callSettings);

        /// <summary>
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="certificateAuthority">
        /// Required. A
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with initial field values.
        /// </param>
        /// <param name="certificateAuthorityId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> CreateCertificateAuthorityAsync(CaPoolName parent, CertificateAuthority certificateAuthority, string certificateAuthorityId, st::CancellationToken cancellationToken) =>
            CreateCertificateAuthorityAsync(parent, certificateAuthority, certificateAuthorityId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DisableCertificateAuthority(DisableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(DisableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DisableCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableCertificateAuthority(new DisableCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DisableCertificateAuthorityAsync(new DisableCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            DisableCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DisableCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableCertificateAuthority(new DisableCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            DisableCertificateAuthorityAsync(new DisableCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DisableCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            DisableCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> EnableCertificateAuthority(EnableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(EnableCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> EnableCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableCertificateAuthority(new EnableCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            EnableCertificateAuthorityAsync(new EnableCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            EnableCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> EnableCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableCertificateAuthority(new EnableCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            EnableCertificateAuthorityAsync(new EnableCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> EnableCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            EnableCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCertificateAuthorityCsrResponse FetchCertificateAuthorityCsr(FetchCertificateAuthorityCsrRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(FetchCertificateAuthorityCsrRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(FetchCertificateAuthorityCsrRequest request, st::CancellationToken cancellationToken) =>
            FetchCertificateAuthorityCsrAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCertificateAuthorityCsrResponse FetchCertificateAuthorityCsr(string name, gaxgrpc::CallSettings callSettings = null) =>
            FetchCertificateAuthorityCsr(new FetchCertificateAuthorityCsrRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            FetchCertificateAuthorityCsrAsync(new FetchCertificateAuthorityCsrRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(string name, st::CancellationToken cancellationToken) =>
            FetchCertificateAuthorityCsrAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCertificateAuthorityCsrResponse FetchCertificateAuthorityCsr(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            FetchCertificateAuthorityCsr(new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            FetchCertificateAuthorityCsrAsync(new FetchCertificateAuthorityCsrRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCertificateAuthorityCsrResponse> FetchCertificateAuthorityCsrAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            FetchCertificateAuthorityCsrAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(GetCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateAuthority.name] of the
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthority(new GetCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateAuthority.name] of the
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthorityAsync(new GetCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateAuthority.name] of the
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateAuthority.name] of the
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateAuthority GetCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthority(new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateAuthority.name] of the
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateAuthorityAsync(new GetCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateAuthority.name] of the
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateAuthority> GetCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            GetCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthorities(ListCertificateAuthoritiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
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
        public virtual gax::PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthorities(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateAuthoritiesRequest request = new ListCertificateAuthoritiesRequest
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
            return ListCertificateAuthorities(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
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
        public virtual gax::PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthoritiesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateAuthoritiesRequest request = new ListCertificateAuthoritiesRequest
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
            return ListCertificateAuthoritiesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
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
        public virtual gax::PagedEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthorities(CaPoolName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateAuthoritiesRequest request = new ListCertificateAuthoritiesRequest
            {
                ParentAsCaPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCertificateAuthorities(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] associated with the
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority],
        /// in the format `projects/*/locations/*/caPools/*`.
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
        public virtual gax::PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthoritiesAsync(CaPoolName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateAuthoritiesRequest request = new ListCertificateAuthoritiesRequest
            {
                ParentAsCaPoolName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCertificateAuthoritiesAsync(request, callSettings);
        }

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> UndeleteCertificateAuthority(UndeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UndeleteCertificateAuthorityAsync(UndeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UndeleteCertificateAuthorityAsync(UndeleteCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            UndeleteCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UndeleteCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient UndeleteCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceUndeleteCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UndeleteCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceUndeleteCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UndeleteCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> UndeleteCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteCertificateAuthority(new UndeleteCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UndeleteCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteCertificateAuthorityAsync(new UndeleteCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UndeleteCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            UndeleteCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> UndeleteCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteCertificateAuthority(new UndeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UndeleteCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            UndeleteCertificateAuthorityAsync(new UndeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UndeleteCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            UndeleteCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DeleteCertificateAuthority(DeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest request, st::CancellationToken cancellationToken) =>
            DeleteCertificateAuthorityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCertificateAuthority</c>.</summary>
        public virtual lro::OperationsClient DeleteCertificateAuthorityOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> PollOnceDeleteCertificateAuthority(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCertificateAuthority</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> PollOnceDeleteCertificateAuthorityAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateAuthority, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateAuthorityOperationsClient, callSettings);

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DeleteCertificateAuthority(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateAuthority(new DeleteCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DeleteCertificateAuthorityAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateAuthorityAsync(new DeleteCertificateAuthorityRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DeleteCertificateAuthorityAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> DeleteCertificateAuthority(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateAuthority(new DeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DeleteCertificateAuthorityAsync(CertificateAuthorityName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateAuthorityAsync(new DeleteCertificateAuthorityRequest
            {
                CertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DeleteCertificateAuthorityAsync(CertificateAuthorityName name, st::CancellationToken cancellationToken) =>
            DeleteCertificateAuthorityAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateAuthority, OperationMetadata> UpdateCertificateAuthority(UpdateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Update a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="certificateAuthority">
        /// Required.
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with updated values.
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
        /// Update a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="certificateAuthority">
        /// Required.
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with updated values.
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
        /// Update a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="certificateAuthority">
        /// Required.
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UpdateCertificateAuthorityAsync(CertificateAuthority certificateAuthority, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateAuthorityAsync(certificateAuthority, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CaPool, OperationMetadata> CreateCaPool(CreateCaPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> CreateCaPoolAsync(CreateCaPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> CreateCaPoolAsync(CreateCaPoolRequest request, st::CancellationToken cancellationToken) =>
            CreateCaPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCaPool</c>.</summary>
        public virtual lro::OperationsClient CreateCaPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>CreateCaPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CaPool, OperationMetadata> PollOnceCreateCaPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CaPool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCaPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCaPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> PollOnceCreateCaPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CaPool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCaPoolOperationsClient, callSettings);

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="caPool">
        /// Required. A [CaPool][google.cloud.security.privateca.v1.CaPool] with
        /// initial field values.
        /// </param>
        /// <param name="caPoolId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CaPool, OperationMetadata> CreateCaPool(string parent, CaPool caPool, string caPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCaPool(new CreateCaPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CaPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)),
                CaPool = gax::GaxPreconditions.CheckNotNull(caPool, nameof(caPool)),
            }, callSettings);

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="caPool">
        /// Required. A [CaPool][google.cloud.security.privateca.v1.CaPool] with
        /// initial field values.
        /// </param>
        /// <param name="caPoolId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> CreateCaPoolAsync(string parent, CaPool caPool, string caPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCaPoolAsync(new CreateCaPoolRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CaPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)),
                CaPool = gax::GaxPreconditions.CheckNotNull(caPool, nameof(caPool)),
            }, callSettings);

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="caPool">
        /// Required. A [CaPool][google.cloud.security.privateca.v1.CaPool] with
        /// initial field values.
        /// </param>
        /// <param name="caPoolId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> CreateCaPoolAsync(string parent, CaPool caPool, string caPoolId, st::CancellationToken cancellationToken) =>
            CreateCaPoolAsync(parent, caPool, caPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="caPool">
        /// Required. A [CaPool][google.cloud.security.privateca.v1.CaPool] with
        /// initial field values.
        /// </param>
        /// <param name="caPoolId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CaPool, OperationMetadata> CreateCaPool(gagr::LocationName parent, CaPool caPool, string caPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCaPool(new CreateCaPoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CaPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)),
                CaPool = gax::GaxPreconditions.CheckNotNull(caPool, nameof(caPool)),
            }, callSettings);

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="caPool">
        /// Required. A [CaPool][google.cloud.security.privateca.v1.CaPool] with
        /// initial field values.
        /// </param>
        /// <param name="caPoolId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> CreateCaPoolAsync(gagr::LocationName parent, CaPool caPool, string caPoolId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCaPoolAsync(new CreateCaPoolRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CaPoolId = gax::GaxPreconditions.CheckNotNullOrEmpty(caPoolId, nameof(caPoolId)),
                CaPool = gax::GaxPreconditions.CheckNotNull(caPool, nameof(caPool)),
            }, callSettings);

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool], in the format
        /// `projects/*/locations/*`.
        /// </param>
        /// <param name="caPool">
        /// Required. A [CaPool][google.cloud.security.privateca.v1.CaPool] with
        /// initial field values.
        /// </param>
        /// <param name="caPoolId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> CreateCaPoolAsync(gagr::LocationName parent, CaPool caPool, string caPoolId, st::CancellationToken cancellationToken) =>
            CreateCaPoolAsync(parent, caPool, caPoolId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CaPool, OperationMetadata> UpdateCaPool(UpdateCaPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> UpdateCaPoolAsync(UpdateCaPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> UpdateCaPoolAsync(UpdateCaPoolRequest request, st::CancellationToken cancellationToken) =>
            UpdateCaPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCaPool</c>.</summary>
        public virtual lro::OperationsClient UpdateCaPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>UpdateCaPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CaPool, OperationMetadata> PollOnceUpdateCaPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CaPool, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCaPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCaPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> PollOnceUpdateCaPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CaPool, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCaPoolOperationsClient, callSettings);

        /// <summary>
        /// Update a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="caPool">
        /// Required. [CaPool][google.cloud.security.privateca.v1.CaPool] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CaPool, OperationMetadata> UpdateCaPool(CaPool caPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCaPool(new UpdateCaPoolRequest
            {
                CaPool = gax::GaxPreconditions.CheckNotNull(caPool, nameof(caPool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="caPool">
        /// Required. [CaPool][google.cloud.security.privateca.v1.CaPool] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> UpdateCaPoolAsync(CaPool caPool, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCaPoolAsync(new UpdateCaPoolRequest
            {
                CaPool = gax::GaxPreconditions.CheckNotNull(caPool, nameof(caPool)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="caPool">
        /// Required. [CaPool][google.cloud.security.privateca.v1.CaPool] with updated
        /// values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CaPool, OperationMetadata>> UpdateCaPoolAsync(CaPool caPool, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCaPoolAsync(caPool, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CaPool GetCaPool(GetCaPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CaPool> GetCaPoolAsync(GetCaPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CaPool> GetCaPoolAsync(GetCaPoolRequest request, st::CancellationToken cancellationToken) =>
            GetCaPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.CaPool.name] of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CaPool GetCaPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCaPool(new GetCaPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.CaPool.name] of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CaPool> GetCaPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCaPoolAsync(new GetCaPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.CaPool.name] of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CaPool> GetCaPoolAsync(string name, st::CancellationToken cancellationToken) =>
            GetCaPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.CaPool.name] of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CaPool GetCaPool(CaPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCaPool(new GetCaPoolRequest
            {
                CaPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.CaPool.name] of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CaPool> GetCaPoolAsync(CaPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCaPoolAsync(new GetCaPoolRequest
            {
                CaPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The [name][google.cloud.security.privateca.v1.CaPool.name] of the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CaPool> GetCaPoolAsync(CaPoolName name, st::CancellationToken cancellationToken) =>
            GetCaPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists [CaPools][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CaPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCaPoolsResponse, CaPool> ListCaPools(ListCaPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [CaPools][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CaPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCaPoolsResponse, CaPool> ListCaPoolsAsync(ListCaPoolsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists [CaPools][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPools][google.cloud.security.privateca.v1.CaPool], in the format
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
        /// <returns>A pageable sequence of <see cref="CaPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCaPoolsResponse, CaPool> ListCaPools(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCaPoolsRequest request = new ListCaPoolsRequest
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
            return ListCaPools(request, callSettings);
        }

        /// <summary>
        /// Lists [CaPools][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPools][google.cloud.security.privateca.v1.CaPool], in the format
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
        /// <returns>A pageable asynchronous sequence of <see cref="CaPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCaPoolsResponse, CaPool> ListCaPoolsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCaPoolsRequest request = new ListCaPoolsRequest
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
            return ListCaPoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists [CaPools][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPools][google.cloud.security.privateca.v1.CaPool], in the format
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
        /// <returns>A pageable sequence of <see cref="CaPool"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCaPoolsResponse, CaPool> ListCaPools(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCaPoolsRequest request = new ListCaPoolsRequest
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
            return ListCaPools(request, callSettings);
        }

        /// <summary>
        /// Lists [CaPools][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CaPools][google.cloud.security.privateca.v1.CaPool], in the format
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
        /// <returns>A pageable asynchronous sequence of <see cref="CaPool"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCaPoolsResponse, CaPool> ListCaPoolsAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCaPoolsRequest request = new ListCaPoolsRequest
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
            return ListCaPoolsAsync(request, callSettings);
        }

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCaPool(DeleteCaPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCaPoolAsync(DeleteCaPoolRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCaPoolAsync(DeleteCaPoolRequest request, st::CancellationToken cancellationToken) =>
            DeleteCaPoolAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCaPool</c>.</summary>
        public virtual lro::OperationsClient DeleteCaPoolOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>DeleteCaPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCaPool(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCaPoolOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCaPool</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCaPoolAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCaPoolOperationsClient, callSettings);

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCaPool(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCaPool(new DeleteCaPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCaPoolAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCaPoolAsync(new DeleteCaPoolRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCaPoolAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCaPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCaPool(CaPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCaPool(new DeleteCaPoolRequest
            {
                CaPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCaPoolAsync(CaPoolName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCaPoolAsync(new DeleteCaPoolRequest
            {
                CaPoolName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCaPoolAsync(CaPoolName name, st::CancellationToken cancellationToken) =>
            DeleteCaPoolAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCaCertsResponse FetchCaCerts(FetchCaCertsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCaCertsResponse> FetchCaCertsAsync(FetchCaCertsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCaCertsResponse> FetchCaCertsAsync(FetchCaCertsRequest request, st::CancellationToken cancellationToken) =>
            FetchCaCertsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="caPool">
        /// Required. The resource name for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCaCertsResponse FetchCaCerts(string caPool, gaxgrpc::CallSettings callSettings = null) =>
            FetchCaCerts(new FetchCaCertsRequest
            {
                CaPool = gax::GaxPreconditions.CheckNotNullOrEmpty(caPool, nameof(caPool)),
            }, callSettings);

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="caPool">
        /// Required. The resource name for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCaCertsResponse> FetchCaCertsAsync(string caPool, gaxgrpc::CallSettings callSettings = null) =>
            FetchCaCertsAsync(new FetchCaCertsRequest
            {
                CaPool = gax::GaxPreconditions.CheckNotNullOrEmpty(caPool, nameof(caPool)),
            }, callSettings);

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="caPool">
        /// Required. The resource name for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCaCertsResponse> FetchCaCertsAsync(string caPool, st::CancellationToken cancellationToken) =>
            FetchCaCertsAsync(caPool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="caPool">
        /// Required. The resource name for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual FetchCaCertsResponse FetchCaCerts(CaPoolName caPool, gaxgrpc::CallSettings callSettings = null) =>
            FetchCaCerts(new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = gax::GaxPreconditions.CheckNotNull(caPool, nameof(caPool)),
            }, callSettings);

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="caPool">
        /// Required. The resource name for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCaCertsResponse> FetchCaCertsAsync(CaPoolName caPool, gaxgrpc::CallSettings callSettings = null) =>
            FetchCaCertsAsync(new FetchCaCertsRequest
            {
                CaPoolAsCaPoolName = gax::GaxPreconditions.CheckNotNull(caPool, nameof(caPool)),
            }, callSettings);

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="caPool">
        /// Required. The resource name for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool] in the format
        /// `projects/*/locations/*/caPools/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<FetchCaCertsResponse> FetchCaCertsAsync(CaPoolName caPool, st::CancellationToken cancellationToken) =>
            FetchCaCertsAsync(caPool, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateRevocationList GetCertificateRevocationList(GetCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(GetCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(GetCertificateRevocationListRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateRevocationListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateRevocationList.name]
        /// of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateRevocationList GetCertificateRevocationList(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateRevocationList(new GetCertificateRevocationListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateRevocationList.name]
        /// of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateRevocationListAsync(new GetCertificateRevocationListRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateRevocationList.name]
        /// of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateRevocationListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateRevocationList.name]
        /// of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateRevocationList GetCertificateRevocationList(CertificateRevocationListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateRevocationList(new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateRevocationList.name]
        /// of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(CertificateRevocationListName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateRevocationListAsync(new GetCertificateRevocationListRequest
            {
                CertificateRevocationListName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateRevocationList.name]
        /// of the
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateRevocationList> GetCertificateRevocationListAsync(CertificateRevocationListName name, st::CancellationToken cancellationToken) =>
            GetCertificateRevocationListAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationLists(ListCertificateRevocationListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateRevocationList"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationListsAsync(ListCertificateRevocationListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList],
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
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
        public virtual gax::PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationLists(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateRevocationListsRequest request = new ListCertificateRevocationListsRequest
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
            return ListCertificateRevocationLists(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList],
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
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
        public virtual gax::PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationListsAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateRevocationListsRequest request = new ListCertificateRevocationListsRequest
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
            return ListCertificateRevocationListsAsync(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList],
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
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
        public virtual gax::PagedEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationLists(CertificateAuthorityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateRevocationListsRequest request = new ListCertificateRevocationListsRequest
            {
                ParentAsCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCertificateRevocationLists(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList],
        /// in the format `projects/*/locations/*/caPools/*/certificateAuthorities/*`.
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
        public virtual gax::PagedAsyncEnumerable<ListCertificateRevocationListsResponse, CertificateRevocationList> ListCertificateRevocationListsAsync(CertificateAuthorityName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateRevocationListsRequest request = new ListCertificateRevocationListsRequest
            {
                ParentAsCertificateAuthorityName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCertificateRevocationListsAsync(request, callSettings);
        }

        /// <summary>
        /// Update a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateRevocationList, OperationMetadata> UpdateCertificateRevocationList(UpdateCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> UpdateCertificateRevocationListAsync(UpdateCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
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
        /// Update a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="certificateRevocationList">
        /// Required.
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// with updated values.
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
        /// Update a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="certificateRevocationList">
        /// Required.
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// with updated values.
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
        /// Update a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="certificateRevocationList">
        /// Required.
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList]
        /// with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> UpdateCertificateRevocationListAsync(CertificateRevocationList certificateRevocationList, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateRevocationListAsync(certificateRevocationList, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateTemplate, OperationMetadata> CreateCertificateTemplate(CreateCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> CreateCertificateTemplateAsync(CreateCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> CreateCertificateTemplateAsync(CreateCertificateTemplateRequest request, st::CancellationToken cancellationToken) =>
            CreateCertificateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCertificateTemplate</c>.</summary>
        public virtual lro::OperationsClient CreateCertificateTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCertificateTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateTemplate, OperationMetadata> PollOnceCreateCertificateTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateTemplate, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCertificateTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> PollOnceCreateCertificateTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateTemplate, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCertificateTemplateOperationsClient, callSettings);

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateTemplate">
        /// Required. A
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateTemplateId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateTemplate, OperationMetadata> CreateCertificateTemplate(string parent, CertificateTemplate certificateTemplate, string certificateTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateTemplate(new CreateCertificateTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateTemplateId, nameof(certificateTemplateId)),
                CertificateTemplate = gax::GaxPreconditions.CheckNotNull(certificateTemplate, nameof(certificateTemplate)),
            }, callSettings);

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateTemplate">
        /// Required. A
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateTemplateId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> CreateCertificateTemplateAsync(string parent, CertificateTemplate certificateTemplate, string certificateTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateTemplateAsync(new CreateCertificateTemplateRequest
            {
                Parent = gax::GaxPreconditions.CheckNotNullOrEmpty(parent, nameof(parent)),
                CertificateTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateTemplateId, nameof(certificateTemplateId)),
                CertificateTemplate = gax::GaxPreconditions.CheckNotNull(certificateTemplate, nameof(certificateTemplate)),
            }, callSettings);

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateTemplate">
        /// Required. A
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateTemplateId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> CreateCertificateTemplateAsync(string parent, CertificateTemplate certificateTemplate, string certificateTemplateId, st::CancellationToken cancellationToken) =>
            CreateCertificateTemplateAsync(parent, certificateTemplate, certificateTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateTemplate">
        /// Required. A
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateTemplateId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateTemplate, OperationMetadata> CreateCertificateTemplate(gagr::LocationName parent, CertificateTemplate certificateTemplate, string certificateTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateTemplate(new CreateCertificateTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateTemplateId, nameof(certificateTemplateId)),
                CertificateTemplate = gax::GaxPreconditions.CheckNotNull(certificateTemplate, nameof(certificateTemplate)),
            }, callSettings);

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateTemplate">
        /// Required. A
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateTemplateId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> CreateCertificateTemplateAsync(gagr::LocationName parent, CertificateTemplate certificateTemplate, string certificateTemplateId, gaxgrpc::CallSettings callSettings = null) =>
            CreateCertificateTemplateAsync(new CreateCertificateTemplateRequest
            {
                ParentAsLocationName = gax::GaxPreconditions.CheckNotNull(parent, nameof(parent)),
                CertificateTemplateId = gax::GaxPreconditions.CheckNotNullOrEmpty(certificateTemplateId, nameof(certificateTemplateId)),
                CertificateTemplate = gax::GaxPreconditions.CheckNotNull(certificateTemplate, nameof(certificateTemplate)),
            }, callSettings);

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
        /// </param>
        /// <param name="certificateTemplate">
        /// Required. A
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with initial field values.
        /// </param>
        /// <param name="certificateTemplateId">
        /// Required. It must be unique within a location and match the regular
        /// expression `[a-zA-Z0-9_-]{1,63}`
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> CreateCertificateTemplateAsync(gagr::LocationName parent, CertificateTemplate certificateTemplate, string certificateTemplateId, st::CancellationToken cancellationToken) =>
            CreateCertificateTemplateAsync(parent, certificateTemplate, certificateTemplateId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateTemplate(DeleteCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateTemplateAsync(DeleteCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateTemplateAsync(DeleteCertificateTemplateRequest request, st::CancellationToken cancellationToken) =>
            DeleteCertificateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>DeleteCertificateTemplate</c>.</summary>
        public virtual lro::OperationsClient DeleteCertificateTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCertificateTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> PollOnceDeleteCertificateTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>DeleteCertificateTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> PollOnceDeleteCertificateTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), DeleteCertificateTemplateOperationsClient, callSettings);

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in the format `projects/*/locations/*/certificateTemplates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateTemplate(new DeleteCertificateTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in the format `projects/*/locations/*/certificateTemplates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateTemplateAsync(new DeleteCertificateTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in the format `projects/*/locations/*/certificateTemplates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            DeleteCertificateTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in the format `projects/*/locations/*/certificateTemplates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateTemplate(CertificateTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateTemplate(new DeleteCertificateTemplateRequest
            {
                CertificateTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in the format `projects/*/locations/*/certificateTemplates/*`.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateTemplateAsync(CertificateTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            DeleteCertificateTemplateAsync(new DeleteCertificateTemplateRequest
            {
                CertificateTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The resource name for this
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in the format `projects/*/locations/*/certificateTemplates/*`.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateTemplateAsync(CertificateTemplateName name, st::CancellationToken cancellationToken) =>
            DeleteCertificateTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateTemplate GetCertificateTemplate(GetCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateTemplate> GetCertificateTemplateAsync(GetCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateTemplate> GetCertificateTemplateAsync(GetCertificateTemplateRequest request, st::CancellationToken cancellationToken) =>
            GetCertificateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateTemplate.name] of the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateTemplate GetCertificateTemplate(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateTemplate(new GetCertificateTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateTemplate.name] of the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateTemplate> GetCertificateTemplateAsync(string name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateTemplateAsync(new GetCertificateTemplateRequest
            {
                Name = gax::GaxPreconditions.CheckNotNullOrEmpty(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateTemplate.name] of the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateTemplate> GetCertificateTemplateAsync(string name, st::CancellationToken cancellationToken) =>
            GetCertificateTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateTemplate.name] of the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CertificateTemplate GetCertificateTemplate(CertificateTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateTemplate(new GetCertificateTemplateRequest
            {
                CertificateTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateTemplate.name] of the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateTemplate> GetCertificateTemplateAsync(CertificateTemplateName name, gaxgrpc::CallSettings callSettings = null) =>
            GetCertificateTemplateAsync(new GetCertificateTemplateRequest
            {
                CertificateTemplateName = gax::GaxPreconditions.CheckNotNull(name, nameof(name)),
            }, callSettings);

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="name">
        /// Required. The
        /// [name][google.cloud.security.privateca.v1.CertificateTemplate.name] of the
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CertificateTemplate> GetCertificateTemplateAsync(CertificateTemplateName name, st::CancellationToken cancellationToken) =>
            GetCertificateTemplateAsync(name, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Lists
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> ListCertificateTemplates(ListCertificateTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> ListCertificateTemplatesAsync(ListCertificateTemplatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Lists
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="CertificateTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> ListCertificateTemplates(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateTemplatesRequest request = new ListCertificateTemplatesRequest
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
            return ListCertificateTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> ListCertificateTemplatesAsync(string parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateTemplatesRequest request = new ListCertificateTemplatesRequest
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
            return ListCertificateTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
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
        /// <returns>A pageable sequence of <see cref="CertificateTemplate"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> ListCertificateTemplates(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateTemplatesRequest request = new ListCertificateTemplatesRequest
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
            return ListCertificateTemplates(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="parent">
        /// Required. The resource name of the location associated with the
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate],
        /// in the format `projects/*/locations/*`.
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
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateTemplate"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> ListCertificateTemplatesAsync(gagr::LocationName parent, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCertificateTemplatesRequest request = new ListCertificateTemplatesRequest
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
            return ListCertificateTemplatesAsync(request, callSettings);
        }

        /// <summary>
        /// Update a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateTemplate, OperationMetadata> UpdateCertificateTemplate(UpdateCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> UpdateCertificateTemplateAsync(UpdateCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> UpdateCertificateTemplateAsync(UpdateCertificateTemplateRequest request, st::CancellationToken cancellationToken) =>
            UpdateCertificateTemplateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>UpdateCertificateTemplate</c>.</summary>
        public virtual lro::OperationsClient UpdateCertificateTemplateOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<CertificateTemplate, OperationMetadata> PollOnceUpdateCertificateTemplate(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateTemplate, OperationMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateTemplateOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>UpdateCertificateTemplate</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> PollOnceUpdateCertificateTemplateAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<CertificateTemplate, OperationMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), UpdateCertificateTemplateOperationsClient, callSettings);

        /// <summary>
        /// Update a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="certificateTemplate">
        /// Required.
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<CertificateTemplate, OperationMetadata> UpdateCertificateTemplate(CertificateTemplate certificateTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateTemplate(new UpdateCertificateTemplateRequest
            {
                CertificateTemplate = gax::GaxPreconditions.CheckNotNull(certificateTemplate, nameof(certificateTemplate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="certificateTemplate">
        /// Required.
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> UpdateCertificateTemplateAsync(CertificateTemplate certificateTemplate, wkt::FieldMask updateMask, gaxgrpc::CallSettings callSettings = null) =>
            UpdateCertificateTemplateAsync(new UpdateCertificateTemplateRequest
            {
                CertificateTemplate = gax::GaxPreconditions.CheckNotNull(certificateTemplate, nameof(certificateTemplate)),
                UpdateMask = gax::GaxPreconditions.CheckNotNull(updateMask, nameof(updateMask)),
            }, callSettings);

        /// <summary>
        /// Update a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="certificateTemplate">
        /// Required.
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// with updated values.
        /// </param>
        /// <param name="updateMask">
        /// Required. A list of fields to be updated in this request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> UpdateCertificateTemplateAsync(CertificateTemplate certificateTemplate, wkt::FieldMask updateMask, st::CancellationToken cancellationToken) =>
            UpdateCertificateTemplateAsync(certificateTemplate, updateMask, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CertificateAuthorityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// [Certificate Authority
    /// Service][google.cloud.security.privateca.v1.CertificateAuthorityService]
    /// manages private certificate authorities and issued certificates.
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

        private readonly gaxgrpc::ApiCall<UndeleteCertificateAuthorityRequest, lro::Operation> _callUndeleteCertificateAuthority;

        private readonly gaxgrpc::ApiCall<DeleteCertificateAuthorityRequest, lro::Operation> _callDeleteCertificateAuthority;

        private readonly gaxgrpc::ApiCall<UpdateCertificateAuthorityRequest, lro::Operation> _callUpdateCertificateAuthority;

        private readonly gaxgrpc::ApiCall<CreateCaPoolRequest, lro::Operation> _callCreateCaPool;

        private readonly gaxgrpc::ApiCall<UpdateCaPoolRequest, lro::Operation> _callUpdateCaPool;

        private readonly gaxgrpc::ApiCall<GetCaPoolRequest, CaPool> _callGetCaPool;

        private readonly gaxgrpc::ApiCall<ListCaPoolsRequest, ListCaPoolsResponse> _callListCaPools;

        private readonly gaxgrpc::ApiCall<DeleteCaPoolRequest, lro::Operation> _callDeleteCaPool;

        private readonly gaxgrpc::ApiCall<FetchCaCertsRequest, FetchCaCertsResponse> _callFetchCaCerts;

        private readonly gaxgrpc::ApiCall<GetCertificateRevocationListRequest, CertificateRevocationList> _callGetCertificateRevocationList;

        private readonly gaxgrpc::ApiCall<ListCertificateRevocationListsRequest, ListCertificateRevocationListsResponse> _callListCertificateRevocationLists;

        private readonly gaxgrpc::ApiCall<UpdateCertificateRevocationListRequest, lro::Operation> _callUpdateCertificateRevocationList;

        private readonly gaxgrpc::ApiCall<CreateCertificateTemplateRequest, lro::Operation> _callCreateCertificateTemplate;

        private readonly gaxgrpc::ApiCall<DeleteCertificateTemplateRequest, lro::Operation> _callDeleteCertificateTemplate;

        private readonly gaxgrpc::ApiCall<GetCertificateTemplateRequest, CertificateTemplate> _callGetCertificateTemplate;

        private readonly gaxgrpc::ApiCall<ListCertificateTemplatesRequest, ListCertificateTemplatesResponse> _callListCertificateTemplates;

        private readonly gaxgrpc::ApiCall<UpdateCertificateTemplateRequest, lro::Operation> _callUpdateCertificateTemplate;

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
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ActivateCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ActivateCertificateAuthorityOperationsSettings, logger);
            CreateCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCertificateAuthorityOperationsSettings, logger);
            DisableCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DisableCertificateAuthorityOperationsSettings, logger);
            EnableCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.EnableCertificateAuthorityOperationsSettings, logger);
            UndeleteCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UndeleteCertificateAuthorityOperationsSettings, logger);
            DeleteCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCertificateAuthorityOperationsSettings, logger);
            UpdateCertificateAuthorityOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCertificateAuthorityOperationsSettings, logger);
            CreateCaPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCaPoolOperationsSettings, logger);
            UpdateCaPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCaPoolOperationsSettings, logger);
            DeleteCaPoolOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCaPoolOperationsSettings, logger);
            UpdateCertificateRevocationListOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCertificateRevocationListOperationsSettings, logger);
            CreateCertificateTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCertificateTemplateOperationsSettings, logger);
            DeleteCertificateTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.DeleteCertificateTemplateOperationsSettings, logger);
            UpdateCertificateTemplateOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.UpdateCertificateTemplateOperationsSettings, logger);
            LocationsClient = new gcl::LocationsClientImpl(grpcClient.CreateLocationsClient(), effectiveSettings.LocationsSettings, logger);
            IAMPolicyClient = new gciv::IAMPolicyClientImpl(grpcClient.CreateIAMPolicyClient(), effectiveSettings.IAMPolicySettings, logger);
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
            _callUndeleteCertificateAuthority = clientHelper.BuildApiCall<UndeleteCertificateAuthorityRequest, lro::Operation>("UndeleteCertificateAuthority", grpcClient.UndeleteCertificateAuthorityAsync, grpcClient.UndeleteCertificateAuthority, effectiveSettings.UndeleteCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callUndeleteCertificateAuthority);
            Modify_UndeleteCertificateAuthorityApiCall(ref _callUndeleteCertificateAuthority);
            _callDeleteCertificateAuthority = clientHelper.BuildApiCall<DeleteCertificateAuthorityRequest, lro::Operation>("DeleteCertificateAuthority", grpcClient.DeleteCertificateAuthorityAsync, grpcClient.DeleteCertificateAuthority, effectiveSettings.DeleteCertificateAuthoritySettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCertificateAuthority);
            Modify_DeleteCertificateAuthorityApiCall(ref _callDeleteCertificateAuthority);
            _callUpdateCertificateAuthority = clientHelper.BuildApiCall<UpdateCertificateAuthorityRequest, lro::Operation>("UpdateCertificateAuthority", grpcClient.UpdateCertificateAuthorityAsync, grpcClient.UpdateCertificateAuthority, effectiveSettings.UpdateCertificateAuthoritySettings).WithGoogleRequestParam("certificate_authority.name", request => request.CertificateAuthority?.Name);
            Modify_ApiCall(ref _callUpdateCertificateAuthority);
            Modify_UpdateCertificateAuthorityApiCall(ref _callUpdateCertificateAuthority);
            _callCreateCaPool = clientHelper.BuildApiCall<CreateCaPoolRequest, lro::Operation>("CreateCaPool", grpcClient.CreateCaPoolAsync, grpcClient.CreateCaPool, effectiveSettings.CreateCaPoolSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCaPool);
            Modify_CreateCaPoolApiCall(ref _callCreateCaPool);
            _callUpdateCaPool = clientHelper.BuildApiCall<UpdateCaPoolRequest, lro::Operation>("UpdateCaPool", grpcClient.UpdateCaPoolAsync, grpcClient.UpdateCaPool, effectiveSettings.UpdateCaPoolSettings).WithGoogleRequestParam("ca_pool.name", request => request.CaPool?.Name);
            Modify_ApiCall(ref _callUpdateCaPool);
            Modify_UpdateCaPoolApiCall(ref _callUpdateCaPool);
            _callGetCaPool = clientHelper.BuildApiCall<GetCaPoolRequest, CaPool>("GetCaPool", grpcClient.GetCaPoolAsync, grpcClient.GetCaPool, effectiveSettings.GetCaPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCaPool);
            Modify_GetCaPoolApiCall(ref _callGetCaPool);
            _callListCaPools = clientHelper.BuildApiCall<ListCaPoolsRequest, ListCaPoolsResponse>("ListCaPools", grpcClient.ListCaPoolsAsync, grpcClient.ListCaPools, effectiveSettings.ListCaPoolsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCaPools);
            Modify_ListCaPoolsApiCall(ref _callListCaPools);
            _callDeleteCaPool = clientHelper.BuildApiCall<DeleteCaPoolRequest, lro::Operation>("DeleteCaPool", grpcClient.DeleteCaPoolAsync, grpcClient.DeleteCaPool, effectiveSettings.DeleteCaPoolSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCaPool);
            Modify_DeleteCaPoolApiCall(ref _callDeleteCaPool);
            _callFetchCaCerts = clientHelper.BuildApiCall<FetchCaCertsRequest, FetchCaCertsResponse>("FetchCaCerts", grpcClient.FetchCaCertsAsync, grpcClient.FetchCaCerts, effectiveSettings.FetchCaCertsSettings).WithGoogleRequestParam("ca_pool", request => request.CaPool);
            Modify_ApiCall(ref _callFetchCaCerts);
            Modify_FetchCaCertsApiCall(ref _callFetchCaCerts);
            _callGetCertificateRevocationList = clientHelper.BuildApiCall<GetCertificateRevocationListRequest, CertificateRevocationList>("GetCertificateRevocationList", grpcClient.GetCertificateRevocationListAsync, grpcClient.GetCertificateRevocationList, effectiveSettings.GetCertificateRevocationListSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificateRevocationList);
            Modify_GetCertificateRevocationListApiCall(ref _callGetCertificateRevocationList);
            _callListCertificateRevocationLists = clientHelper.BuildApiCall<ListCertificateRevocationListsRequest, ListCertificateRevocationListsResponse>("ListCertificateRevocationLists", grpcClient.ListCertificateRevocationListsAsync, grpcClient.ListCertificateRevocationLists, effectiveSettings.ListCertificateRevocationListsSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCertificateRevocationLists);
            Modify_ListCertificateRevocationListsApiCall(ref _callListCertificateRevocationLists);
            _callUpdateCertificateRevocationList = clientHelper.BuildApiCall<UpdateCertificateRevocationListRequest, lro::Operation>("UpdateCertificateRevocationList", grpcClient.UpdateCertificateRevocationListAsync, grpcClient.UpdateCertificateRevocationList, effectiveSettings.UpdateCertificateRevocationListSettings).WithGoogleRequestParam("certificate_revocation_list.name", request => request.CertificateRevocationList?.Name);
            Modify_ApiCall(ref _callUpdateCertificateRevocationList);
            Modify_UpdateCertificateRevocationListApiCall(ref _callUpdateCertificateRevocationList);
            _callCreateCertificateTemplate = clientHelper.BuildApiCall<CreateCertificateTemplateRequest, lro::Operation>("CreateCertificateTemplate", grpcClient.CreateCertificateTemplateAsync, grpcClient.CreateCertificateTemplate, effectiveSettings.CreateCertificateTemplateSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callCreateCertificateTemplate);
            Modify_CreateCertificateTemplateApiCall(ref _callCreateCertificateTemplate);
            _callDeleteCertificateTemplate = clientHelper.BuildApiCall<DeleteCertificateTemplateRequest, lro::Operation>("DeleteCertificateTemplate", grpcClient.DeleteCertificateTemplateAsync, grpcClient.DeleteCertificateTemplate, effectiveSettings.DeleteCertificateTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callDeleteCertificateTemplate);
            Modify_DeleteCertificateTemplateApiCall(ref _callDeleteCertificateTemplate);
            _callGetCertificateTemplate = clientHelper.BuildApiCall<GetCertificateTemplateRequest, CertificateTemplate>("GetCertificateTemplate", grpcClient.GetCertificateTemplateAsync, grpcClient.GetCertificateTemplate, effectiveSettings.GetCertificateTemplateSettings).WithGoogleRequestParam("name", request => request.Name);
            Modify_ApiCall(ref _callGetCertificateTemplate);
            Modify_GetCertificateTemplateApiCall(ref _callGetCertificateTemplate);
            _callListCertificateTemplates = clientHelper.BuildApiCall<ListCertificateTemplatesRequest, ListCertificateTemplatesResponse>("ListCertificateTemplates", grpcClient.ListCertificateTemplatesAsync, grpcClient.ListCertificateTemplates, effectiveSettings.ListCertificateTemplatesSettings).WithGoogleRequestParam("parent", request => request.Parent);
            Modify_ApiCall(ref _callListCertificateTemplates);
            Modify_ListCertificateTemplatesApiCall(ref _callListCertificateTemplates);
            _callUpdateCertificateTemplate = clientHelper.BuildApiCall<UpdateCertificateTemplateRequest, lro::Operation>("UpdateCertificateTemplate", grpcClient.UpdateCertificateTemplateAsync, grpcClient.UpdateCertificateTemplate, effectiveSettings.UpdateCertificateTemplateSettings).WithGoogleRequestParam("certificate_template.name", request => request.CertificateTemplate?.Name);
            Modify_ApiCall(ref _callUpdateCertificateTemplate);
            Modify_UpdateCertificateTemplateApiCall(ref _callUpdateCertificateTemplate);
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

        partial void Modify_UndeleteCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<UndeleteCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_DeleteCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<DeleteCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_UpdateCertificateAuthorityApiCall(ref gaxgrpc::ApiCall<UpdateCertificateAuthorityRequest, lro::Operation> call);

        partial void Modify_CreateCaPoolApiCall(ref gaxgrpc::ApiCall<CreateCaPoolRequest, lro::Operation> call);

        partial void Modify_UpdateCaPoolApiCall(ref gaxgrpc::ApiCall<UpdateCaPoolRequest, lro::Operation> call);

        partial void Modify_GetCaPoolApiCall(ref gaxgrpc::ApiCall<GetCaPoolRequest, CaPool> call);

        partial void Modify_ListCaPoolsApiCall(ref gaxgrpc::ApiCall<ListCaPoolsRequest, ListCaPoolsResponse> call);

        partial void Modify_DeleteCaPoolApiCall(ref gaxgrpc::ApiCall<DeleteCaPoolRequest, lro::Operation> call);

        partial void Modify_FetchCaCertsApiCall(ref gaxgrpc::ApiCall<FetchCaCertsRequest, FetchCaCertsResponse> call);

        partial void Modify_GetCertificateRevocationListApiCall(ref gaxgrpc::ApiCall<GetCertificateRevocationListRequest, CertificateRevocationList> call);

        partial void Modify_ListCertificateRevocationListsApiCall(ref gaxgrpc::ApiCall<ListCertificateRevocationListsRequest, ListCertificateRevocationListsResponse> call);

        partial void Modify_UpdateCertificateRevocationListApiCall(ref gaxgrpc::ApiCall<UpdateCertificateRevocationListRequest, lro::Operation> call);

        partial void Modify_CreateCertificateTemplateApiCall(ref gaxgrpc::ApiCall<CreateCertificateTemplateRequest, lro::Operation> call);

        partial void Modify_DeleteCertificateTemplateApiCall(ref gaxgrpc::ApiCall<DeleteCertificateTemplateRequest, lro::Operation> call);

        partial void Modify_GetCertificateTemplateApiCall(ref gaxgrpc::ApiCall<GetCertificateTemplateRequest, CertificateTemplate> call);

        partial void Modify_ListCertificateTemplatesApiCall(ref gaxgrpc::ApiCall<ListCertificateTemplatesRequest, ListCertificateTemplatesResponse> call);

        partial void Modify_UpdateCertificateTemplateApiCall(ref gaxgrpc::ApiCall<UpdateCertificateTemplateRequest, lro::Operation> call);

        partial void OnConstruction(CertificateAuthorityService.CertificateAuthorityServiceClient grpcClient, CertificateAuthorityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CertificateAuthorityService client</summary>
        public override CertificateAuthorityService.CertificateAuthorityServiceClient GrpcClient { get; }

        /// <summary>The <see cref="gcl::LocationsClient"/> associated with this client.</summary>
        public override gcl::LocationsClient LocationsClient { get; }

        /// <summary>The <see cref="gciv::IAMPolicyClient"/> associated with this client.</summary>
        public override gciv::IAMPolicyClient IAMPolicyClient { get; }

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

        partial void Modify_UndeleteCertificateAuthorityRequest(ref UndeleteCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCertificateAuthorityRequest(ref DeleteCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateAuthorityRequest(ref UpdateCertificateAuthorityRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCaPoolRequest(ref CreateCaPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCaPoolRequest(ref UpdateCaPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCaPoolRequest(ref GetCaPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCaPoolsRequest(ref ListCaPoolsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCaPoolRequest(ref DeleteCaPoolRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_FetchCaCertsRequest(ref FetchCaCertsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateRevocationListRequest(ref GetCertificateRevocationListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCertificateRevocationListsRequest(ref ListCertificateRevocationListsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateRevocationListRequest(ref UpdateCertificateRevocationListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCertificateTemplateRequest(ref CreateCertificateTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_DeleteCertificateTemplateRequest(ref DeleteCertificateTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetCertificateTemplateRequest(ref GetCertificateTemplateRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCertificateTemplatesRequest(ref ListCertificateTemplatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateCertificateTemplateRequest(ref UpdateCertificateTemplateRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
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
        /// Create a new [Certificate][google.cloud.security.privateca.v1.Certificate]
        /// in a given Project, Location from a particular
        /// [CaPool][google.cloud.security.privateca.v1.CaPool].
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
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
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
        /// Returns a [Certificate][google.cloud.security.privateca.v1.Certificate].
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
        /// Lists [Certificates][google.cloud.security.privateca.v1.Certificate].
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
        /// Lists [Certificates][google.cloud.security.privateca.v1.Certificate].
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
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
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
        /// Revoke a [Certificate][google.cloud.security.privateca.v1.Certificate].
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
        /// Update a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1.Certificate.labels] field.
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
        /// Update a [Certificate][google.cloud.security.privateca.v1.Certificate].
        /// Currently, the only field you can update is the
        /// [labels][google.cloud.security.privateca.v1.Certificate.labels] field.
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
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
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
        /// Activate a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// After the parent Certificate Authority signs a certificate signing request
        /// from
        /// [FetchCertificateAuthorityCsr][google.cloud.security.privateca.v1.CertificateAuthorityService.FetchCertificateAuthorityCsr],
        /// this method can complete the activation process.
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
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
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
        /// Create a new
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// in a given Project and Location.
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
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Disable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Enable a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
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
        /// Fetch a certificate signing request (CSR) from a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that is in state
        /// [AWAITING_USER_ACTIVATION][google.cloud.security.privateca.v1.CertificateAuthority.State.AWAITING_USER_ACTIVATION]
        /// and is of type
        /// [SUBORDINATE][google.cloud.security.privateca.v1.CertificateAuthority.Type.SUBORDINATE].
        /// The CSR must then be signed by the desired parent Certificate Authority,
        /// which could be another
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// resource, or could be an on-prem certificate authority. See also
        /// [ActivateCertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthorityService.ActivateCertificateAuthority].
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
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Returns a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Lists
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Lists
        /// [CertificateAuthorities][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateAuthority"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCertificateAuthoritiesResponse, CertificateAuthority> ListCertificateAuthoritiesAsync(ListCertificateAuthoritiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateAuthoritiesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCertificateAuthoritiesRequest, ListCertificateAuthoritiesResponse, CertificateAuthority>(_callListCertificateAuthorities, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UndeleteCertificateAuthority</c>.</summary>
        public override lro::OperationsClient UndeleteCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> UndeleteCertificateAuthority(UndeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callUndeleteCertificateAuthority.Sync(request, callSettings), UndeleteCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Undelete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority]
        /// that has been deleted.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UndeleteCertificateAuthorityAsync(UndeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UndeleteCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callUndeleteCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), UndeleteCertificateAuthorityOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCertificateAuthority</c>.</summary>
        public override lro::OperationsClient DeleteCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateAuthority, OperationMetadata> DeleteCertificateAuthority(DeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(_callDeleteCertificateAuthority.Sync(request, callSettings), DeleteCertificateAuthorityOperationsClient);
        }

        /// <summary>
        /// Delete a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> DeleteCertificateAuthorityAsync(DeleteCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callDeleteCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), DeleteCertificateAuthorityOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCertificateAuthority</c>.</summary>
        public override lro::OperationsClient UpdateCertificateAuthorityOperationsClient { get; }

        /// <summary>
        /// Update a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
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
        /// Update a
        /// [CertificateAuthority][google.cloud.security.privateca.v1.CertificateAuthority].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateAuthority, OperationMetadata>> UpdateCertificateAuthorityAsync(UpdateCertificateAuthorityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateAuthorityRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateAuthority, OperationMetadata>(await _callUpdateCertificateAuthority.Async(request, callSettings).ConfigureAwait(false), UpdateCertificateAuthorityOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateCaPool</c>.</summary>
        public override lro::OperationsClient CreateCaPoolOperationsClient { get; }

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CaPool, OperationMetadata> CreateCaPool(CreateCaPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCaPoolRequest(ref request, ref callSettings);
            return new lro::Operation<CaPool, OperationMetadata>(_callCreateCaPool.Sync(request, callSettings), CreateCaPoolOperationsClient);
        }

        /// <summary>
        /// Create a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CaPool, OperationMetadata>> CreateCaPoolAsync(CreateCaPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCaPoolRequest(ref request, ref callSettings);
            return new lro::Operation<CaPool, OperationMetadata>(await _callCreateCaPool.Async(request, callSettings).ConfigureAwait(false), CreateCaPoolOperationsClient);
        }

        /// <summary>The long-running operations client for <c>UpdateCaPool</c>.</summary>
        public override lro::OperationsClient UpdateCaPoolOperationsClient { get; }

        /// <summary>
        /// Update a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CaPool, OperationMetadata> UpdateCaPool(UpdateCaPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCaPoolRequest(ref request, ref callSettings);
            return new lro::Operation<CaPool, OperationMetadata>(_callUpdateCaPool.Sync(request, callSettings), UpdateCaPoolOperationsClient);
        }

        /// <summary>
        /// Update a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CaPool, OperationMetadata>> UpdateCaPoolAsync(UpdateCaPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCaPoolRequest(ref request, ref callSettings);
            return new lro::Operation<CaPool, OperationMetadata>(await _callUpdateCaPool.Async(request, callSettings).ConfigureAwait(false), UpdateCaPoolOperationsClient);
        }

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CaPool GetCaPool(GetCaPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCaPoolRequest(ref request, ref callSettings);
            return _callGetCaPool.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CaPool> GetCaPoolAsync(GetCaPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCaPoolRequest(ref request, ref callSettings);
            return _callGetCaPool.Async(request, callSettings);
        }

        /// <summary>
        /// Lists [CaPools][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CaPool"/> resources.</returns>
        public override gax::PagedEnumerable<ListCaPoolsResponse, CaPool> ListCaPools(ListCaPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCaPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCaPoolsRequest, ListCaPoolsResponse, CaPool>(_callListCaPools, request, callSettings);
        }

        /// <summary>
        /// Lists [CaPools][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CaPool"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCaPoolsResponse, CaPool> ListCaPoolsAsync(ListCaPoolsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCaPoolsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCaPoolsRequest, ListCaPoolsResponse, CaPool>(_callListCaPools, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>DeleteCaPool</c>.</summary>
        public override lro::OperationsClient DeleteCaPoolOperationsClient { get; }

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCaPool(DeleteCaPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCaPoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCaPool.Sync(request, callSettings), DeleteCaPoolOperationsClient);
        }

        /// <summary>
        /// Delete a [CaPool][google.cloud.security.privateca.v1.CaPool].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCaPoolAsync(DeleteCaPoolRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCaPoolRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCaPool.Async(request, callSettings).ConfigureAwait(false), DeleteCaPoolOperationsClient);
        }

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override FetchCaCertsResponse FetchCaCerts(FetchCaCertsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchCaCertsRequest(ref request, ref callSettings);
            return _callFetchCaCerts.Sync(request, callSettings);
        }

        /// <summary>
        /// FetchCaCerts returns the current trust anchor for the
        /// [CaPool][google.cloud.security.privateca.v1.CaPool]. This will include CA
        /// certificate chains for all certificate authorities in the ENABLED,
        /// DISABLED, or STAGED states.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<FetchCaCertsResponse> FetchCaCertsAsync(FetchCaCertsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_FetchCaCertsRequest(ref request, ref callSettings);
            return _callFetchCaCerts.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
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
        /// Returns a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
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
        /// Lists
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList].
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
        /// Lists
        /// [CertificateRevocationLists][google.cloud.security.privateca.v1.CertificateRevocationList].
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
        /// Update a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
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
        /// Update a
        /// [CertificateRevocationList][google.cloud.security.privateca.v1.CertificateRevocationList].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateRevocationList, OperationMetadata>> UpdateCertificateRevocationListAsync(UpdateCertificateRevocationListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateRevocationListRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateRevocationList, OperationMetadata>(await _callUpdateCertificateRevocationList.Async(request, callSettings).ConfigureAwait(false), UpdateCertificateRevocationListOperationsClient);
        }

        /// <summary>The long-running operations client for <c>CreateCertificateTemplate</c>.</summary>
        public override lro::OperationsClient CreateCertificateTemplateOperationsClient { get; }

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateTemplate, OperationMetadata> CreateCertificateTemplate(CreateCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateTemplate, OperationMetadata>(_callCreateCertificateTemplate.Sync(request, callSettings), CreateCertificateTemplateOperationsClient);
        }

        /// <summary>
        /// Create a new
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate]
        /// in a given Project and Location.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> CreateCertificateTemplateAsync(CreateCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCertificateTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateTemplate, OperationMetadata>(await _callCreateCertificateTemplate.Async(request, callSettings).ConfigureAwait(false), CreateCertificateTemplateOperationsClient);
        }

        /// <summary>The long-running operations client for <c>DeleteCertificateTemplate</c>.</summary>
        public override lro::OperationsClient DeleteCertificateTemplateOperationsClient { get; }

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, OperationMetadata> DeleteCertificateTemplate(DeleteCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(_callDeleteCertificateTemplate.Sync(request, callSettings), DeleteCertificateTemplateOperationsClient);
        }

        /// <summary>
        /// DeleteCertificateTemplate deletes a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, OperationMetadata>> DeleteCertificateTemplateAsync(DeleteCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_DeleteCertificateTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, OperationMetadata>(await _callDeleteCertificateTemplate.Async(request, callSettings).ConfigureAwait(false), DeleteCertificateTemplateOperationsClient);
        }

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CertificateTemplate GetCertificateTemplate(GetCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateTemplateRequest(ref request, ref callSettings);
            return _callGetCertificateTemplate.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CertificateTemplate> GetCertificateTemplateAsync(GetCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCertificateTemplateRequest(ref request, ref callSettings);
            return _callGetCertificateTemplate.Async(request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="CertificateTemplate"/> resources.</returns>
        public override gax::PagedEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> ListCertificateTemplates(ListCertificateTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCertificateTemplatesRequest, ListCertificateTemplatesResponse, CertificateTemplate>(_callListCertificateTemplates, request, callSettings);
        }

        /// <summary>
        /// Lists
        /// [CertificateTemplates][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="CertificateTemplate"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListCertificateTemplatesResponse, CertificateTemplate> ListCertificateTemplatesAsync(ListCertificateTemplatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCertificateTemplatesRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCertificateTemplatesRequest, ListCertificateTemplatesResponse, CertificateTemplate>(_callListCertificateTemplates, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>UpdateCertificateTemplate</c>.</summary>
        public override lro::OperationsClient UpdateCertificateTemplateOperationsClient { get; }

        /// <summary>
        /// Update a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<CertificateTemplate, OperationMetadata> UpdateCertificateTemplate(UpdateCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateTemplate, OperationMetadata>(_callUpdateCertificateTemplate.Sync(request, callSettings), UpdateCertificateTemplateOperationsClient);
        }

        /// <summary>
        /// Update a
        /// [CertificateTemplate][google.cloud.security.privateca.v1.CertificateTemplate].
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<CertificateTemplate, OperationMetadata>> UpdateCertificateTemplateAsync(UpdateCertificateTemplateRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateCertificateTemplateRequest(ref request, ref callSettings);
            return new lro::Operation<CertificateTemplate, OperationMetadata>(await _callUpdateCertificateTemplate.Async(request, callSettings).ConfigureAwait(false), UpdateCertificateTemplateOperationsClient);
        }
    }

    public partial class ListCertificatesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificateAuthoritiesRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCaPoolsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificateRevocationListsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCertificateTemplatesRequest : gaxgrpc::IPageRequest
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

    public partial class ListCaPoolsResponse : gaxgrpc::IPageResponse<CaPool>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CaPool> GetEnumerator() => CaPools.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCertificateRevocationListsResponse : gaxgrpc::IPageResponse<CertificateRevocationList>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CertificateRevocationList> GetEnumerator() => CertificateRevocationLists.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public partial class ListCertificateTemplatesResponse : gaxgrpc::IPageResponse<CertificateTemplate>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<CertificateTemplate> GetEnumerator() => CertificateTemplates.GetEnumerator();

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

    public static partial class CertificateAuthorityService
    {
        public partial class CertificateAuthorityServiceClient
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
